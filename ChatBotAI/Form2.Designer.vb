<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnWa = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'btnWa
        '
        Me.btnWa.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWa.FillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnWa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnWa.ForeColor = System.Drawing.Color.White
        Me.btnWa.Location = New System.Drawing.Point(637, 203)
        Me.btnWa.Name = "btnWa"
        Me.btnWa.Size = New System.Drawing.Size(94, 44)
        Me.btnWa.TabIndex = 9
        Me.btnWa.Text = "Send"
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
        Me.txtNomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomer.Location = New System.Drawing.Point(69, 203)
        Me.txtNomer.Name = "txtNomer"
        Me.txtNomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomer.PlaceholderText = "Masukan Nomer Whatsapp"
        Me.txtNomer.SelectedText = ""
        Me.txtNomer.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(15)
        Me.txtNomer.Size = New System.Drawing.Size(581, 44)
        Me.txtNomer.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWa)
        Me.Controls.Add(Me.txtNomer)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNomer As Guna.UI2.WinForms.Guna2TextBox
End Class
