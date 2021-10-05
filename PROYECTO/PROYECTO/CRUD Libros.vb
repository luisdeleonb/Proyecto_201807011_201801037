Public Class CRUD_Libros
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Administrador.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
    End Sub

End Class