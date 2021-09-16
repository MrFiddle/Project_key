<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class matematicas_rap_opt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.suma = New System.Windows.Forms.RadioButton()
        Me.resta = New System.Windows.Forms.RadioButton()
        Me.mult = New System.Windows.Forms.RadioButton()
        Me.hard = New System.Windows.Forms.RadioButton()
        Me.reg = New System.Windows.Forms.RadioButton()
        Me.easy = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.custom = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.start = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue Book", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operación"
        '
        'suma
        '
        Me.suma.AutoSize = True
        Me.suma.Location = New System.Drawing.Point(19, 46)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(52, 17)
        Me.suma.TabIndex = 1
        Me.suma.TabStop = True
        Me.suma.Text = "Suma"
        Me.suma.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.Location = New System.Drawing.Point(19, 69)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(53, 17)
        Me.resta.TabIndex = 2
        Me.resta.TabStop = True
        Me.resta.Text = "Resta"
        Me.resta.UseVisualStyleBackColor = True
        '
        'mult
        '
        Me.mult.AutoSize = True
        Me.mult.Location = New System.Drawing.Point(19, 92)
        Me.mult.Name = "mult"
        Me.mult.Size = New System.Drawing.Size(89, 17)
        Me.mult.TabIndex = 3
        Me.mult.TabStop = True
        Me.mult.Text = "Multiplicación"
        Me.mult.UseVisualStyleBackColor = True
        '
        'hard
        '
        Me.hard.AutoSize = True
        Me.hard.Location = New System.Drawing.Point(21, 83)
        Me.hard.Name = "hard"
        Me.hard.Size = New System.Drawing.Size(50, 17)
        Me.hard.TabIndex = 7
        Me.hard.TabStop = True
        Me.hard.Text = "Dificil"
        Me.hard.UseVisualStyleBackColor = True
        '
        'reg
        '
        Me.reg.AutoSize = True
        Me.reg.Location = New System.Drawing.Point(21, 60)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(62, 17)
        Me.reg.TabIndex = 6
        Me.reg.TabStop = True
        Me.reg.Text = "Regular"
        Me.reg.UseVisualStyleBackColor = True
        '
        'easy
        '
        Me.easy.AutoSize = True
        Me.easy.Location = New System.Drawing.Point(21, 37)
        Me.easy.Name = "easy"
        Me.easy.Size = New System.Drawing.Size(47, 17)
        Me.easy.TabIndex = 5
        Me.easy.TabStop = True
        Me.easy.Text = "Fácil"
        Me.easy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue Book", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dificultad"
        '
        'custom
        '
        Me.custom.AutoSize = True
        Me.custom.Location = New System.Drawing.Point(21, 106)
        Me.custom.Name = "custom"
        Me.custom.Size = New System.Drawing.Size(60, 17)
        Me.custom.TabIndex = 8
        Me.custom.TabStop = True
        Me.custom.Text = "Custom"
        Me.custom.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 285)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(46, 311)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 10
        Me.start.Text = "Iniciar"
        Me.start.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.custom)
        Me.Panel1.Controls.Add(Me.hard)
        Me.Panel1.Controls.Add(Me.reg)
        Me.Panel1.Controls.Add(Me.easy)
        Me.Panel1.Location = New System.Drawing.Point(11, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 148)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.mult)
        Me.Panel2.Controls.Add(Me.resta)
        Me.Panel2.Controls.Add(Me.suma)
        Me.Panel2.Location = New System.Drawing.Point(13, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 127)
        Me.Panel2.TabIndex = 12
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(46, 340)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 13
        Me.back.Text = "Volver"
        Me.back.UseVisualStyleBackColor = True
        '
        'matematicas_rap_opt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 382)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "matematicas_rap_opt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "matematicas_rap_opt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents suma As RadioButton
    Friend WithEvents resta As RadioButton
    Friend WithEvents mult As RadioButton
    Friend WithEvents hard As RadioButton
    Friend WithEvents reg As RadioButton
    Friend WithEvents easy As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents custom As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents start As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents back As Button
End Class
