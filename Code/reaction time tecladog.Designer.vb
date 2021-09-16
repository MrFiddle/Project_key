<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reaction_time_tecladog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.score = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.input_u = New System.Windows.Forms.TextBox()
        Me.operacion = New System.Windows.Forms.Label()
        Me.h2 = New System.Windows.Forms.PictureBox()
        Me.h3 = New System.Windows.Forms.PictureBox()
        Me.h1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tiempo_juego = New System.Windows.Forms.Timer(Me.components)
        Me.tiempo_num = New System.Windows.Forms.Timer(Me.components)
        Me.tiempo_hold = New System.Windows.Forms.Timer(Me.components)
        Me.tiempo_inicio = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.h2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.h3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.h1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.BackColor = System.Drawing.Color.WhiteSmoke
        Me.score.Font = New System.Drawing.Font("Bebas Neue", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score.ForeColor = System.Drawing.SystemColors.ControlText
        Me.score.Location = New System.Drawing.Point(136, 20)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(60, 25)
        Me.score.TabIndex = 6
        Me.score.Text = "Label1"
        Me.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Panel1.Controls.Add(Me.score)
        Me.Panel1.Controls.Add(Me.input_u)
        Me.Panel1.Controls.Add(Me.operacion)
        Me.Panel1.Controls.Add(Me.h2)
        Me.Panel1.Controls.Add(Me.h3)
        Me.Panel1.Controls.Add(Me.h1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 586)
        Me.Panel1.TabIndex = 4
        '
        'input_u
        '
        Me.input_u.BackColor = System.Drawing.SystemColors.InfoText
        Me.input_u.ForeColor = System.Drawing.SystemColors.Window
        Me.input_u.Location = New System.Drawing.Point(125, 487)
        Me.input_u.Name = "input_u"
        Me.input_u.Size = New System.Drawing.Size(100, 20)
        Me.input_u.TabIndex = 7
        Me.input_u.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'operacion
        '
        Me.operacion.BackColor = System.Drawing.Color.Olive
        Me.operacion.Font = New System.Drawing.Font("C&C Red Alert [LAN]", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operacion.ForeColor = System.Drawing.Color.White
        Me.operacion.Location = New System.Drawing.Point(137, 98)
        Me.operacion.Name = "operacion"
        Me.operacion.Size = New System.Drawing.Size(88, 23)
        Me.operacion.TabIndex = 6
        Me.operacion.Text = "."
        Me.operacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'h2
        '
        Me.h2.Image = Global.Project_Key__beta_.My.Resources.Resources.filled_heart
        Me.h2.Location = New System.Drawing.Point(125, 367)
        Me.h2.Name = "h2"
        Me.h2.Size = New System.Drawing.Size(100, 103)
        Me.h2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.h2.TabIndex = 4
        Me.h2.TabStop = False
        '
        'h3
        '
        Me.h3.Image = Global.Project_Key__beta_.My.Resources.Resources.filled_heart
        Me.h3.Location = New System.Drawing.Point(213, 367)
        Me.h3.Name = "h3"
        Me.h3.Size = New System.Drawing.Size(100, 103)
        Me.h3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.h3.TabIndex = 5
        Me.h3.TabStop = False
        '
        'h1
        '
        Me.h1.Image = Global.Project_Key__beta_.My.Resources.Resources.filled_heart
        Me.h1.Location = New System.Drawing.Point(39, 367)
        Me.h1.Name = "h1"
        Me.h1.Size = New System.Drawing.Size(100, 103)
        Me.h1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.h1.TabIndex = 3
        Me.h1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Project_Key__beta_.My.Resources.Resources.bomb
        Me.PictureBox2.Location = New System.Drawing.Point(0, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(348, 256)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_Key__beta_.My.Resources.Resources.city
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1059, 586)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'tiempo_juego
        '
        Me.tiempo_juego.Interval = 1000
        '
        'tiempo_num
        '
        Me.tiempo_num.Enabled = True
        '
        'tiempo_hold
        '
        Me.tiempo_hold.Interval = 1000
        '
        'tiempo_inicio
        '
        Me.tiempo_inicio.Interval = 1000
        '
        'reaction_time_tecladog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 585)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "reaction_time_tecladog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.h2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.h3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.h1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents score As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents input_u As TextBox
    Friend WithEvents operacion As Label
    Friend WithEvents h2 As PictureBox
    Friend WithEvents h3 As PictureBox
    Friend WithEvents h1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tiempo_juego As Timer
    Friend WithEvents tiempo_num As Timer
    Friend WithEvents tiempo_hold As Timer
    Friend WithEvents tiempo_inicio As Timer
End Class
