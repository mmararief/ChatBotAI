<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImageGeneration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnGenerateImage = New Guna.UI2.WinForms.Guna2Button()
        Me.txtImage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSaveImage = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPnlWa = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlWa = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnWa = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNomer = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWa.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ImageRotate = 0!
        Me.PictureBox1.Location = New System.Drawing.Point(320, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Roboto Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(67, 44)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(211, 30)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Image Generation"
        '
        'btnGenerateImage
        '
        Me.btnGenerateImage.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerateImage.BorderRadius = 15
        Me.btnGenerateImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGenerateImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGenerateImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGenerateImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGenerateImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnGenerateImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGenerateImage.ForeColor = System.Drawing.Color.White
        Me.btnGenerateImage.Image = Global.ChatBotAI.My.Resources.Resources._0090e9b8adf1a5fccf110625b6969a2f
        Me.btnGenerateImage.Location = New System.Drawing.Point(699, 405)
        Me.btnGenerateImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerateImage.Name = "btnGenerateImage"
        Me.btnGenerateImage.Size = New System.Drawing.Size(36, 38)
        Me.btnGenerateImage.TabIndex = 8
        Me.btnGenerateImage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnGenerateImage.UseTransparentBackground = True
        '
        'txtImage
        '
        Me.txtImage.BorderColor = System.Drawing.Color.Transparent
        Me.txtImage.BorderRadius = 15
        Me.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImage.DefaultText = ""
        Me.txtImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtImage.Location = New System.Drawing.Point(59, 405)
        Me.txtImage.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtImage.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtImage.PlaceholderText = "Generate image"
        Me.txtImage.SelectedText = ""
        Me.txtImage.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(15)
        Me.txtImage.Size = New System.Drawing.Size(677, 38)
        Me.txtImage.TabIndex = 7
        '
        'btnSaveImage
        '
        Me.btnSaveImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaveImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaveImage.FillColor = System.Drawing.Color.Green
        Me.btnSaveImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSaveImage.ForeColor = System.Drawing.Color.White
        Me.btnSaveImage.Location = New System.Drawing.Point(59, 324)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(95, 27)
        Me.btnSaveImage.TabIndex = 9
        Me.btnSaveImage.Text = "Save Image"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "Image generation adalah proses menghasilkan gambar-gambar baru menggunakan algori" &
    "tma atau model komputer."
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(59, 81)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox1.Multiline = True
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(228, 221)
        Me.Guna2TextBox1.TabIndex = 10
        '
        'btnPnlWa
        '
        Me.btnPnlWa.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPnlWa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPnlWa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPnlWa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPnlWa.FillColor = System.Drawing.Color.Green
        Me.btnPnlWa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPnlWa.ForeColor = System.Drawing.Color.White
        Me.btnPnlWa.Location = New System.Drawing.Point(159, 324)
        Me.btnPnlWa.Name = "btnPnlWa"
        Me.btnPnlWa.Size = New System.Drawing.Size(127, 27)
        Me.btnPnlWa.TabIndex = 11
        Me.btnPnlWa.Text = "Share"
        '
        'pnlWa
        '
        Me.pnlWa.BackColor = System.Drawing.Color.White
        Me.pnlWa.BorderRadius = 10
        Me.pnlWa.Controls.Add(Me.btnWa)
        Me.pnlWa.Controls.Add(Me.Guna2CircleButton1)
        Me.pnlWa.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnlWa.Controls.Add(Me.txtNomer)
        Me.pnlWa.Location = New System.Drawing.Point(184, 147)
        Me.pnlWa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlWa.Name = "pnlWa"
        Me.pnlWa.Size = New System.Drawing.Size(450, 144)
        Me.pnlWa.TabIndex = 12
        Me.pnlWa.Visible = False
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
        Me.btnWa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWa.Name = "btnWa"
        Me.btnWa.Size = New System.Drawing.Size(36, 31)
        Me.btnWa.TabIndex = 13
        Me.btnWa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.btnWa.UseTransparentBackground = True
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
        Me.Guna2CircleButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(19, 18)
        Me.Guna2CircleButton1.TabIndex = 14
        Me.Guna2CircleButton1.Text = "Guna2CircleButton1"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Roboto Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(20, 31)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(250, 30)
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
        'ImageGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(791, 468)
        Me.Controls.Add(Me.pnlWa)
        Me.Controls.Add(Me.btnPnlWa)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.btnGenerateImage)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.txtImage)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImageGeneration"
        Me.Text = "ImageGeneration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWa.ResumeLayout(False)
        Me.pnlWa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnGenerateImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtImage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSaveImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPnlWa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlWa As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtNomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnWa As Guna.UI2.WinForms.Guna2Button
End Class
