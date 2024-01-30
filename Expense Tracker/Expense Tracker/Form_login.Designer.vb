<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_login
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
        Label1 = New Label()
        Login_btn = New Button()
        Exit_btn = New Button()
        username_txt = New TextBox()
        Password_txt = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Registerlink = New LinkLabel()
        Remove_user_btn = New Button()
        ShowPasswordCheckBox = New CheckBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 37)
        Label1.TabIndex = 0
        Label1.Text = "Login:"
        ' 
        ' Login_btn
        ' 
        Login_btn.BackColor = SystemColors.Highlight
        Login_btn.Cursor = Cursors.Hand
        Login_btn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login_btn.ForeColor = SystemColors.ControlLight
        Login_btn.Location = New Point(19, 218)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(235, 35)
        Login_btn.TabIndex = 3
        Login_btn.Text = "Login"
        Login_btn.UseVisualStyleBackColor = False
        ' 
        ' Exit_btn
        ' 
        Exit_btn.BackColor = SystemColors.Highlight
        Exit_btn.Cursor = Cursors.Hand
        Exit_btn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Exit_btn.ForeColor = SystemColors.ControlLight
        Exit_btn.Location = New Point(18, 324)
        Exit_btn.Name = "Exit_btn"
        Exit_btn.Size = New Size(236, 29)
        Exit_btn.TabIndex = 5
        Exit_btn.Text = "Exit"
        Exit_btn.UseVisualStyleBackColor = False
        ' 
        ' username_txt
        ' 
        username_txt.BackColor = SystemColors.ActiveCaptionText
        username_txt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        username_txt.ForeColor = Color.DeepSkyBlue
        username_txt.Location = New Point(18, 92)
        username_txt.Multiline = True
        username_txt.Name = "username_txt"
        username_txt.Size = New Size(236, 23)
        username_txt.TabIndex = 1
        username_txt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Password_txt
        ' 
        Password_txt.BackColor = SystemColors.ActiveCaptionText
        Password_txt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Password_txt.ForeColor = Color.DeepSkyBlue
        Password_txt.Location = New Point(19, 162)
        Password_txt.Multiline = True
        Password_txt.Name = "Password_txt"
        Password_txt.Size = New Size(235, 25)
        Password_txt.TabIndex = 2
        Password_txt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DeepSkyBlue
        Label2.Location = New Point(18, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 26)
        Label2.TabIndex = 0
        Label2.Text = "User Name:"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DeepSkyBlue
        Label3.Location = New Point(18, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 28)
        Label3.TabIndex = 6
        Label3.Text = "Password:"
        ' 
        ' Registerlink
        ' 
        Registerlink.ActiveLinkColor = Color.DodgerBlue
        Registerlink.AutoSize = True
        Registerlink.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Registerlink.LinkColor = Color.White
        Registerlink.Location = New Point(12, 363)
        Registerlink.Name = "Registerlink"
        Registerlink.Size = New Size(139, 15)
        Registerlink.TabIndex = 6
        Registerlink.TabStop = True
        Registerlink.Text = "New User... Register Now"
        ' 
        ' Remove_user_btn
        ' 
        Remove_user_btn.BackColor = SystemColors.Highlight
        Remove_user_btn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Remove_user_btn.ForeColor = SystemColors.ControlLight
        Remove_user_btn.Location = New Point(19, 274)
        Remove_user_btn.Name = "Remove_user_btn"
        Remove_user_btn.Size = New Size(235, 32)
        Remove_user_btn.TabIndex = 4
        Remove_user_btn.Text = "Remove User"
        Remove_user_btn.UseVisualStyleBackColor = False
        ' 
        ' ShowPasswordCheckBox
        ' 
        ShowPasswordCheckBox.AutoSize = True
        ShowPasswordCheckBox.ForeColor = SystemColors.ControlLight
        ShowPasswordCheckBox.Location = New Point(239, 194)
        ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        ShowPasswordCheckBox.Size = New Size(15, 14)
        ShowPasswordCheckBox.TabIndex = 8
        ShowPasswordCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(144, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 15)
        Label4.TabIndex = 9
        Label4.Text = "Show Password"
        ' 
        ' Form_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(292, 387)
        Controls.Add(Label4)
        Controls.Add(ShowPasswordCheckBox)
        Controls.Add(Remove_user_btn)
        Controls.Add(Registerlink)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Password_txt)
        Controls.Add(username_txt)
        Controls.Add(Exit_btn)
        Controls.Add(Login_btn)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Login_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents username_txt As TextBox
    Friend WithEvents Password_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Registerlink As LinkLabel
    Friend WithEvents Remove_user_btn As Button
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents Label4 As Label

End Class
