Imports MySqlConnector

Public Class registro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = Conexion


        Try
            Conexion.ConnectionString = "server = db4free.net; user = usuariovb123; password = Usuariovb123;database = u_app123"
            Conexion.Open()
            '''MsgBox("CONECTADO")
            '''login.Show()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        comando.CommandText = ("INSERT into registro (nombre,usuario,email,contraseña) values ('" + Regname.Text + "','" + Reguser.Text + "','" + Regemail.Text + "','" + Regpass.Text + "')")

        comando.ExecuteNonQuery()
        MsgBox("Registro Exitoso")


        login.Show()
        Me.Hide()
        Conexion.Close()
    End Sub

End Class