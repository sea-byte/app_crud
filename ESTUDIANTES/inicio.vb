Imports MySqlConnector

Public Class inicio
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub
End Class
