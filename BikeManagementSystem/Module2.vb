Imports MySql.Data.MySqlClient
Module Module2
    Public Class DBConnection
        Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=mydb_pascua;User=root;Password=;SslMode=none;")
        Public Function Open() As MySqlConnection
            Try
                conn.Open()
            Catch ex As Exception

            End Try
            Return conn
        End Function
        Public Function Close() As MySqlConnection
            Try
                conn.Close()
            Catch ex As Exception

            End Try
            Return conn
        End Function
    End Class
End Module

