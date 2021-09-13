Imports MySqlConnector
Imports Conexion

Public Class buscarModificar
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


        Dim consulta As String
        Dim lista As Byte
        Dim adaptador = New MySqlDataAdapter
        Dim datos As DataSet
        If TextBox1.Text <> "" Then
            consulta = "SELECT * FROM registro WHERE email ='" & TextBox1.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, Conexion)
            datos = New DataSet
            adaptador.Fill(datos, "registro")
            lista = datos.Tables("registro").Rows.Count
        End If

        If lista <> 0 Then
            TextBox2.Text = datos.Tables("registro").Rows(0).Item("nombre")
            TextBox3.Text = datos.Tables("registro").Rows(0).Item("usuario")
        Else
            MsgBox("No fueron encontrados Tu datos")




        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = Conexion


        Try
            Conexion.ConnectionString = "server = db4free.net; user = usuariovb123; password = Usuariovb123;database = u_app123"
            Conexion.Open()
            Conexion.Open()
            '''MsgBox("CONECTADO")
            '''login.Show()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Dim modificar As String
        modificar = "UPDATE registro Set nombre ='" & TextBox2.Text & "',usuario='" & TextBox3.Text & "' WHERE email ='" & TextBox1.Text & "'"
        comando = New MySqlCommand(modificar, Conexion)
        comando.ExecuteNonQuery()
        MsgBox("Registro Actualizado Exitosamente")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        principal.Show()
        Me.Hide()


    End Sub
End Class