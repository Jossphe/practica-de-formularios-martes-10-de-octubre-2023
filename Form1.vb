Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtUsuario.Text = "Manuel" And txtPass.Text = "12345" Then
            MessageBox.Show("El usuario es valido 'BIENVENIDO' ")
            Dim v2 = New Formulario2()
            v2.Show()
            Me.Hide()

        Else
            MessageBox.Show("El usuario es incorrecto")
            txtUsuario.Text = ""
            txtPass.Text = ""
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
