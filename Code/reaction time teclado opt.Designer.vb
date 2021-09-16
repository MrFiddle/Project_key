<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reaction_time_teclado
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
        Me.back = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.custom = New System.Windows.Forms.RadioButton()
        Me.hard = New System.Windows.Forms.RadioButton()
        Me.reg = New System.Windows.Forms.RadioButton()
        Me.easy = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.num_pad = New System.Windows.Forms.RadioButton()
        Me.full_kb = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(43, 323)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 20
        Me.back.Text = "Volver"
        Me.back.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(43, 294)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 17
        Me.start.Text = "Iniciar"
        Me.start.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 268)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue Book", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 38)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Dificultad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue Book", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 38)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "modo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.custom)
        Me.Panel1.Controls.Add(Me.hard)
        Me.Panel1.Controls.Add(Me.reg)
        Me.Panel1.Controls.Add(Me.easy)
        Me.Panel1.Location = New System.Drawing.Point(13, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 148)
        Me.Panel1.TabIndex = 18
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.num_pad)
        Me.Panel2.Controls.Add(Me.full_kb)
        Me.Panel2.Location = New System.Drawing.Point(13, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 82)
        Me.Panel2.TabIndex = 19
        '
        'num_pad
        '
        Me.num_pad.AutoSize = True
        Me.num_pad.Location = New System.Drawing.Point(17, 58)
        Me.num_pad.Name = "num_pad"
        Me.num_pad.Size = New System.Drawing.Size(67, 17)
        Me.num_pad.TabIndex = 2
        Me.num_pad.TabStop = True
        Me.num_pad.Text = "Números"
        Me.num_pad.UseVisualStyleBackColor = True
        '
        'full_kb
        '
        Me.full_kb.AutoSize = True
        Me.full_kb.Location = New System.Drawing.Point(16, 35)
        Me.full_kb.Name = "full_kb"
        Me.full_kb.Size = New System.Drawing.Size(42, 17)
        Me.full_kb.TabIndex = 1
        Me.full_kb.TabStop = True
        Me.full_kb.Text = "A-Z"
        Me.full_kb.UseVisualStyleBackColor = True
        '
        'reaction_time_teclado
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "reaction_time_teclado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents start As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents custom As RadioButton
    Friend WithEvents hard As RadioButton
    Friend WithEvents reg As RadioButton
    Friend WithEvents easy As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents num_pad As RadioButton
    Friend WithEvents full_kb As RadioButton
End Class
