Public Class gamemode_menu
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Me.BackgroundImage = My.Resources.pizarron_multi
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Me.BackgroundImage = My.Resources.PIZARRON_TECL
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Me.BackgroundImage = My.Resources.pizarron
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.BackgroundImage = My.Resources.pizarron
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        matematicas_rap_opt.Show()
        Me.Close()
    End Sub

    Private Sub Gamemode_menu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        reaction_time_teclado.Show()
        Me.Close()
    End Sub
End Class