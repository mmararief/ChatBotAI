﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(59, 44)
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
        Me.btnGenerateImage.Location = New System.Drawing.Point(694, 389)
        Me.btnGenerateImage.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerateImage.Name = "btnGenerateImage"
        Me.btnGenerateImage.Size = New System.Drawing.Size(42, 54)
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
        Me.txtImage.Location = New System.Drawing.Point(59, 389)
        Me.txtImage.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtImage.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtImage.PlaceholderText = "Generate image"
        Me.txtImage.SelectedText = ""
        Me.txtImage.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(15)
        Me.txtImage.Size = New System.Drawing.Size(661, 54)
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
        Me.btnSaveImage.Location = New System.Drawing.Point(98, 324)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(135, 27)
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
        Me.Guna2TextBox1.Size = New System.Drawing.Size(211, 221)
        Me.Guna2TextBox1.TabIndex = 10
        '
        'ImageGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(791, 468)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.btnGenerateImage)
        Me.Controls.Add(Me.txtImage)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImageGeneration"
        Me.Text = "ImageGeneration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnGenerateImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtImage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSaveImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class