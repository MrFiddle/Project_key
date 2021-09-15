Public Class matematicas_rap
    Dim x As Integer
    Dim y As Integer
    Dim res As Integer
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
        'random_numb()
        'tiempo_juego.Start()
        'tiempo_num.Start()
        'tiempo_hold.Stop()
    End Sub
    Private Sub random_numb()

        x = rand.Next(1, 20)
        y = rand.Next(1, 20)

        '¿suma, resta o mult?
        If matematicas_rap_opt.suma.Checked = True Then
            res = x + y
            operacion.Text = Val(x) & "+" & Val(y)
        ElseIf matematicas_rap_opt.resta.Checked = True Then
            resta()
        ElseIf matematicas_rap_opt.mult.Checked = True Then
            multi()
        End If
    End Sub
    Sub resta()
        If y > x Then
            res = y - x
            operacion.Text = Val(y) & "-" & Val(x)
        Else
            res = x - y
            operacion.Text = Val(x) & "-" & Val(y)
        End If
    End Sub
    Sub multi()
        x = rand.Next(1, 10)
        y = rand.Next(1, 10)

        res = x * y
        operacion.Text = Val(x) & "x" & Val(y)
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
    'función fallida xd
    Private Sub refresh_form()
        contador_c = 0
        contador_i = 0
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Sub inp_alg()
        If input_u.Text = "" Then
            input_u.Text = ""
        ElseIf input_u.Text = res Then
            tiempo_hold.Start()
            segundo = 0
            tiempo_num.Stop()
            operacion.Text = ""
            contador_c = contador_c + 1
            score.Text = "Puntaje: " & contador_c
        Else
            tiempo_hold.Start()
            segundo = 0
            tiempo_num.Stop()
            operacion.Text = ""
            contador_i = contador_i + 1
            hp()
        End If

        input_u.Text = ""
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles input_u.KeyDown
        If (e.KeyCode = Keys.Enter) Or (e.KeyCode = Keys.Space) Then
            inp_alg()
        ElseIf (e.KeyCode = Keys.Escape) Then
            Application.Restart()
        End If
    End Sub
    Sub dificultad()
        If matematicas_rap_opt.easy.Checked = True Then
            difficult = 30
        ElseIf matematicas_rap_opt.reg.Checked = True Then
            difficult = 20
        ElseIf matematicas_rap_opt.hard.Checked = True Then
            difficult = 10
        ElseIf matematicas_rap_opt.custom.Checked = True Then
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
        End If
    End Sub

    Private Sub Input_u_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input_u.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class