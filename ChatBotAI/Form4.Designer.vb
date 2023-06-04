<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.pnlWa = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnWa = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlWa.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlWa
        '
        Me.pnlWa.BackColor = System.Drawing.Color.White
        Me.pnlWa.BorderRadius = 10
        Me.pnlWa.Controls.Add(Me.btnWa)
        Me.pnlWa.Controls.Add(Me.Guna2CircleButton1)
        Me.pnlWa.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnlWa.Controls.Add(Me.txtNomer)
        Me.pnlWa.Location = New System.Drawing.Point(175, 153)
        Me.pnlWa.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlWa.Name = "pnlWa"
        Me.pnlWa.Size = New System.Drawing.Size(450, 144)
        Me.pnlWa.TabIndex = 14
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Red
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(415, 16)
        Me.Guna2CircleButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(19, 18)
        Me.Guna2CircleButton1.TabIndex = 14
        Me.Guna2CircleButton1.Text = "Guna2CircleButton1"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(20, 31)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(235, 27)
        Me.Guna2HtmlLabel2.TabIndex = 13
        Me.Guna2HtmlLabel2.Text = "Bagikan Ke Whatsapp"
        '
        'txtNomer
        '
        Me.txtNomer.BorderColor = System.Drawing.Color.Transparent
        Me.txtNomer.BorderRadius = 15
        Me.txtNomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomer.DefaultText = ""
        Me.txtNomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtNomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomer.Location = New System.Drawing.Point(20, 83)
        Me.txtNomer.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtNomer.Name = "txtNomer"
        Me.txtNomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomer.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNomer.PlaceholderText = "Masukan Nomer Whatsapp"
        Me.txtNomer.SelectedText = ""
        Me.txtNomer.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(15)
        Me.txtNomer.Size = New System.Drawing.Size(371, 31)
        Me.txtNomer.TabIndex = 8
        '
        'btnWa
        '
        Me.btnWa.BackColor = System.Drawing.Color.Transparent
        Me.btnWa.BorderRadius = 5
        Me.btnWa.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWa.FillColor = System.Drawing.Color.Green
        Me.btnWa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnWa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnWa.Image = Global.ChatBotAI.My.Resources.Resources._0090e9b8adf1a5fccf110625b6969a2f
        Me.btnWa.Location = New System.Drawing.Point(398, 83)
        Me.btnWa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWa.Name = "btnWa"
        Me.btnWa.Size = New System.Drawing.Size(36, 31)
        Me.btnWa.TabIndex = 13
        Me.btnWa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnWa.UseTransparentBackground = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlWa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.pnlWa.ResumeLayout(False)
        Me.pnlWa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlWa As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnWa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNomer As Guna.UI2.WinForms.Guna2TextBox
End Class
