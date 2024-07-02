Imports System.IdentityModel.Tokens.Jwt
Imports System.Security.Claims
Imports System.Security.Cryptography
Imports Microsoft.IdentityModel.Tokens

Namespace Helpter
    Public Class Reuse
        Public Shared Function HashPassword(ByVal password As String) As String
            Using sha256 As SHA256 = SHA256.Create()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
                Dim hash As Byte() = sha256.ComputeHash(bytes)
                Dim sb As New StringBuilder()
                For Each b As Byte In hash
                    sb.Append(b.ToString("x2"))
                Next
                Return sb.ToString()
            End Using
        End Function

        Public Shared Function GenerateToken(ByVal username As String) As String
            Dim issuer = ConfigurationManager.AppSettings("JwtIssuer")
            Dim audience = ConfigurationManager.AppSettings("JwtAudience")
            Dim secret = ConfigurationManager.AppSettings("JwtSecret")
            Dim key = New SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret))
            Dim credentials = New SigningCredentials(key, SecurityAlgorithms.HmacSha256)

            Dim claims = New List(Of Claim)()
            claims.Add(New Claim(ClaimTypes.Name, username))

            Dim token = New JwtSecurityToken(
                issuer:=issuer,
                audience:=audience,
                claims:=claims,
                expires:=DateTime.Now.AddMinutes(30), ' Token expires in 30 minutes
                signingCredentials:=credentials
            )

            Dim tokenHandler = New JwtSecurityTokenHandler()
            Return tokenHandler.WriteToken(token)
        End Function
        Public Shared Function GenerateRefreshToken() As String
            Return Guid.NewGuid().ToString("N")
        End Function
    End Class
End Namespace