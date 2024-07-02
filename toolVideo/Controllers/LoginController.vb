Imports System.Net
Imports System.Threading.Tasks
Imports System.Web.Http
Imports toolVideo.Helpter
Imports toolVideo.Models

Namespace Controllers
    <RoutePrefix("api/login")>
    Public Class LoginController
        Inherits ApiController

        Private ReadOnly db As New OracleDatabase()
        <HttpPost>
        <Route("")>
        Public Async Function Login(ByVal model As Login) As Task(Of IHttpActionResult)
            If model Is Nothing Then
                Return BadRequest("Vui lòng nhập đầy đủ!")
            End If
            Dim query As String = "Select * from users where Mail = N'" + model.Email.ToString() + "' AND Password = N'" + Reuse.HashPassword(model.Password.ToString()).ToString() + "'"
            Dim dataTable As DataTable = db.ExecuteQuery(query)
            Dim users As New List(Of User)()
            For Each row As DataRow In dataTable.Rows
                Dim user As New User() With {
                    .User_Id = Convert.ToInt32(row("User_Id")),
                    .Username = row("USERNAME").ToString(),
                    .Password = row("PASSWORD").ToString(),
                    .Email = row("MAIL").ToString(),
                    .Auth = Convert.ToInt32(row("AUTH"))
                }
                users.Add(user)
            Next
            If users.Count < 1 Then
                Return BadRequest("Sai tài khoản hoặc mật khẩu!")
            End If
            Dim token = Reuse.GenerateToken(model.Email)
            Dim refresh = Reuse.GenerateRefreshToken()
            Dim nd = users.FirstOrDefault()
            Dim query1 As String = "Insert into RefreshToken (User_Id,Token,Expried_at,is_used) values (" & nd.User_Id.ToString() & ",'" & refresh & "',SYSTIMESTAMP + INTERVAL '7' DAY,1)"
            db.ExecuteNonQuery(query1)
            Dim data = New With {
                .accsess = token,
                .refresh = refresh,
                .uid = nd.User_Id
            }
            Return Ok(data)
        End Function
        <HttpPost>
        <Route("register")>
        Public Async Function Register(ByVal model As Register) As Task(Of IHttpActionResult)
            If model.UserName Is Nothing Or model.Email Is Nothing Or model.Password Is Nothing Then
                Return BadRequest("Vui lòng nhập đầy đủ!")
            End If
            Dim query1 As String = "Select * from users where Mail = N'" & model.Email & "'"
            Dim dataTable As DataTable = db.ExecuteQuery(query1)
            Dim users As New List(Of User)()
            For Each row As DataRow In dataTable.Rows
                Dim user As New User() With {
                    .User_Id = Convert.ToInt32(row("User_Id")),
                    .Username = row("USERNAME").ToString(),
                    .Password = row("PASSWORD").ToString(),
                    .Email = row("MAIL").ToString(),
                    .Auth = Convert.ToInt32(row("AUTH"))
                }
                users.Add(user)
            Next
            If users.Count > 0 Then
                Return BadRequest("Email đã tồn tại!")
            End If
            Dim query2 As String = "Insert into users (Username,Password,Mail,Auth) values (N'" & model.UserName.ToString() & "',N'" & Reuse.HashPassword(model.Password.ToString()).ToString() & "',N'" & model.Email.ToString() & "',1)"
            db.ExecuteNonQuery(query2)
            Return Ok("Thêm thành công")
        End Function
    End Class
End Namespace