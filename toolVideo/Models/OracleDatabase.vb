Imports Oracle.ManagedDataAccess.Client

Public Class OracleDatabase
    Private connectString As String
    Private connection As OracleConnection

    Public Sub New()
        Me.connectString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.11)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=c##toolVideo;Password=123456;"
        Me.connection = New OracleConnection(connectString)
    End Sub

    Public Sub OpenConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Thực hiện truy vấn và trả về kết quả
    Public Function ExecuteQuery(query As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            OpenConnection()
            Using command As New OracleCommand(query, connection)
                Using adapter As New OracleDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Lỗi khi thực hiện truy vấn: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return dataTable
    End Function

    ' Thực hiện lệnh SQL (INSERT, UPDATE, DELETE)
    Public Sub ExecuteNonQuery(sql As String)
        Try
            OpenConnection()
            Using command As New OracleCommand(sql, connection)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Lỗi khi thực hiện lệnh SQL: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

End Class
