Public Class matematicas_rap_opt
    Private Sub Suma_CheckedChanged(sender As Object, e As EventArgs) Handles suma.CheckedChanged
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles start.Click
        If suma.Checked = False And resta.Checked = False And mult.Checked = False And easy.Checked = False And reg.Checked = False And hard.Checked = False And custom.Checked = False Then
            MsgBox("Por favor selecciona las casillas correspondientes")
        ElseIf custom.Checked = True Then
            TextBox1.ReadOnly = False
        End If
        matematicas_rap.ShowDialog()
    End Sub

    Private Sub Matematicas_rap_opt_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            gamemode_menu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Custom_CheckedChanged(sender As Object, e As EventArgs) Handles custom.CheckedChanged
        If custom.Checked = True Then
            TextBox1.ReadOnly = False
        Else
            TextBox1.ReadOnly = True
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Matematicas_rap_opt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        suma.Select()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        gamemode_menu.Show()
        Me.Close()
    End Sub
End Class