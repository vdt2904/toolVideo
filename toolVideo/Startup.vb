Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Jwt
Imports Microsoft.Owin.Security
Imports Owin
Imports Microsoft.IdentityModel.Tokens
Imports System.Text

' Chỉ định rằng OWIN sẽ sử dụng lớp này để khởi động
<Assembly: OwinStartup(GetType(toolVideo.Startup))>

Namespace toolVideo
    Public Class Startup
        Public Sub Configuration(app As IAppBuilder)
            ConfigureAuth(app)
        End Sub

        Public Sub ConfigureAuth(app As IAppBuilder)
            Dim issuer As String = ConfigurationManager.AppSettings("JwtIssuer")
            Dim audience As String = ConfigurationManager.AppSettings("JwtAudience")
            Dim secret As String = ConfigurationManager.AppSettings("JwtSecret")

            Dim key As Byte() = Encoding.UTF8.GetBytes(secret)

            app.UseJwtBearerAuthentication(New JwtBearerAuthenticationOptions With {
                .AuthenticationMode = AuthenticationMode.Active,
                .TokenValidationParameters = New TokenValidationParameters() With {
                    .ValidateIssuer = True,
                    .ValidateAudience = True,
                    .ValidateIssuerSigningKey = True,
                    .ValidIssuer = issuer,
                    .ValidAudience = audience,
                    .IssuerSigningKey = New SymmetricSecurityKey(key)
                }
            })
        End Sub
    End Class
End Namespace
