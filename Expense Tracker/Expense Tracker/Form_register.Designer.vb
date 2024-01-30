<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_register
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
        Label1 = New Label()
        Register_username = New TextBox()
        Register_password = New TextBox()
        Register_btn = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ShowPasswordCheckBox2 = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 34)
        Label1.TabIndex = 0
        Label1.Text = "Register:"
        ' 
        ' Register_username
        ' 
        Register_username.BackColor = SystemColors.ActiveCaptionText
        Register_username.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Register_username.ForeColor = Color.DeepSkyBlue
        Register_username.Location = New Point(73, 90)
        Register_username.Multiline = True
        Register_username.Name = "Register_username"
        Register_username.Size = New Size(170, 30)
        Register_username.TabIndex = 1
        Register_username.TextAlign = HorizontalAlignment.Center
        ' 
        ' Register_password
        ' 
        Register_password.BackColor = SystemColors.ActiveCaptionText
        Register_password.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Register_password.ForeColor = Color.DeepSkyBlue
        Register_password.Location = New Point(73, 160)
        Register_password.Multiline = True
        Register_password.Name = "Register_password"
        Register_password.Size = New Size(170, 31)
        Register_password.TabIndex = 2
        Register_password.TextAlign = HorizontalAlignment.Center
        ' 
        ' Register_btn
        ' 
        Register_btn.BackColor = SystemColors.Highlight
        Register_btn.Cursor = Cursors.Hand
        Register_btn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Register_btn.ForeColor = SystemColors.ControlLight
        Register_btn.Location = New Point(53, 234)
        Register_btn.Name = "Register_btn"
        Register_btn.Size = New Size(206, 40)
        Register_btn.TabIndex = 3
        Register_btn.Text = "Register"
        Register_btn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DeepSkyBlue
        Label2.Location = New Point(53, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 4
        Label2.Text = "User Name:"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DeepSkyBlue
        Label3.Location = New Point(53, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 23)
        Label3.TabIndex = 5
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(135, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 15)
        Label4.TabIndex = 10
        Label4.Text = "Show Password"
        ' 
        ' ShowPasswordCheckBox2
        ' 
        ShowPasswordCheckBox2.AutoSize = True
        ShowPasswordCheckBox2.ForeColor = SystemColors.ControlLight
        ShowPasswordCheckBox2.Location = New Point(228, 195)
        ShowPasswordCheckBox2.Name = "ShowPasswordCheckBox2"
        ShowPasswordCheckBox2.Size = New Size(15, 14)
        ShowPasswordCheckBox2.TabIndex = 11
        ShowPasswordCheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Form_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(331, 298)
        Controls.Add(ShowPasswordCheckBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Register_btn)
        Controls.Add(Register_password)
        Controls.Add(Register_username)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form_register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Register_username As TextBox
    Friend WithEvents Register_password As TextBox
    Friend WithEvents Register_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ShowPasswordCheckBox2 As CheckBox
End Class
