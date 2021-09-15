Public Class reaction_time_tecladog
    Dim x As Integer
    Dim y As Integer
    Dim asci As Integer
    Dim ascnumb As Integer
    Dim rand As New Random
    Dim tiempo As Integer
    Dim segundo As Integer
    Dim segundo_hold As Integer
    Dim segundo_inicio As Integer
    Dim contador_c As Integer
    Dim contador_i As Integer
    Dim difficult As Integer
    Private Sub Matematicas_rap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        score.Text = "Puntaje: "
        tiempo_inicio.Start()
        tiempo_num.Stop()
        dificultad()
    End Sub
    Private Sub random_numb()
        If reaction_time_teclado.full_kb.Checked = True Then
            asci = rand.Next(65, 90)
            operacion.Text = CChar(ChrW(asci))
        ElseIf reaction_time_teclado.num_pad.Checked = True Then

            ascnumb = rand.Next(48, 57)
            operacion.Text = CChar(ChrW(ascnumb))
        End If
    End Sub
    Private Sub hp()
        If contador_i = 1 Then
            h3.Image = My.Resources.not_filled_heart
        ElseIf contador_i = 2 Then
            h2.Image = My.Resources.not_filled_heart
        ElseIf contador_i = 3 Then
            h1.Image = My.Resources.not_filled_heart
            PictureBox1.Image = My.Resources.city_destroyed
            operacion.Text = "boom"
            input_u.Enabled = False
            tiempo_hold.Stop()
            tiempo_num.Stop()
            tiempo_juego.Stop()
            MsgBox("Has perdido, la ciudad ha explotado, tu puntaje ha sido " & contador_c)
            Application.Restart()
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles input_u.KeyDown

    End Sub
    Sub input_algorithm()

        If input_u.Text = operacion.Text Then
            input_u.Text = ""
            tiempo_hold.Start()
            segundo = 0
            tiempo_num.Stop()
            operacion.Text = ""
            contador_c = contador_c + 1
            score.Text = "Puntaje: " & contador_c
        Else
            input_u.Text = ""
            tiempo_hold.Start()
            segundo = 0
            tiempo_num.Stop()
            operacion.Text = ""
            contador_i = contador_i + 1
            hp()
        End If
    End Sub
    Sub dificultad()
        If reaction_time_teclado.easy.Checked = True Then
            difficult = 20
        ElseIf reaction_time_teclado.reg.Checked = True Then
            difficult = 10
        ElseIf reaction_time_teclado.hard.Checked = True Then
            difficult = 7
        ElseIf reaction_time_teclado.custom.Checked = True Then
            difficult = Val(matematicas_rap_opt.TextBox1.Text)
        End If
    End Sub

    Private Sub Tiempo_num_Tick(sender As Object, e As EventArgs) Handles tiempo_num.Tick

        segundo = segundo + 1

        If segundo = difficult Then
            contador_i = contador_i + 1
            hp()
            random_numb()
            segundo = 0
            tiempo_num.Start()
        End If
    End Sub
    Private Sub Tiempo_hold_Tick(sender As Object, e As EventArgs) Handles tiempo_hold.Tick
        segundo_hold = segundo_hold + 1

        If segundo_hold = 1 Then

            tiempo_hold.Enabled = False
            tiempo_hold.Stop()
            segundo_hold = 0
            random_numb()
            segundo = 0
            tiempo_num.Start()
        End If
    End Sub

    Private Sub Tiempo_juego_Tick(sender As Object, e As EventArgs) Handles tiempo_juego.Tick
        tiempo = tiempo + 1

        If tiempo = 60 Then
            operacion.Text = ":)"
            input_u.Enabled = False
            tiempo_hold.Stop()
            tiempo_num.Stop()
            tiempo_juego.Stop()
            MsgBox("Has sobrevivido, la ciudad no ha explotado, tu puntaje ha sido " & contador_c)
            Application.Restart()
        End If
    End Sub

    Private Sub Tiempo_inicio_Tick(sender As Object, e As EventArgs) Handles tiempo_inicio.Tick
        segundo_inicio = segundo_inicio + 1


        If segundo_inicio = 3 Then
            random_numb()
            tiempo_juego.Start()
            tiempo_num.Start()
            tiempo_hold.Stop()
            tiempo_inicio.Stop()
        End If
    End Sub

    Private Sub Input_u_KeyUp(sender As Object, e As KeyEventArgs) Handles input_u.KeyUp
        input_u.CharacterCasing = CharacterCasing.Upper

        If (e.KeyCode = Keys.Escape) Then
            Application.Restart()
        End If

        input_algorithm()
    End Sub
End Class