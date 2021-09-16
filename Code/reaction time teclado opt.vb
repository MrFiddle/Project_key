Public Class reaction_time_teclado
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Reaction_time_teclado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        gamemode_menu.Show()
        Me.Close()
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles start.Click
        reaction_time_tecladog.ShowDialog()
    End Sub
End Class