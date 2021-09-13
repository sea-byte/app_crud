Imports MySqlConnector


Public Class login
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

        comando.CommandText = "SELECT * FROM registro where usuario ='" + Txtuser.Text + "'and contraseña ='" + Txtpass.Text + "'"
        Dim leer As MySqlDataReader

        leer = comando.ExecuteReader

        If leer.HasRows <> False Then
            leer.Read()
            'MsgBox(leer.GetString("usuario"))
            principal.Show()
        Else
            MsgBox("No Tienes Datos Registrados")
            registro.Show()

        End If

        Me.Hide()
        Txtuser.Clear()
        Txtpass.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        registro.Show()
        Me.Hide()
    End Sub

End Class