<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Expense_btn = New Button()
        Report_btn = New Button()
        Income_btn = New Button()
        Logout_btn = New Button()
        Panel2 = New Panel()
        Login_info2 = New Label()
        Login_info1 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.ForeColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(675, 62)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 33)
        Label1.TabIndex = 1
        Label1.Text = "Expense Tracker"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(Expense_btn, 1, 0)
        TableLayoutPanel1.Controls.Add(Report_btn, 2, 0)
        TableLayoutPanel1.Controls.Add(Income_btn, 0, 0)
        TableLayoutPanel1.Controls.Add(Logout_btn, 3, 0)
        TableLayoutPanel1.Location = New Point(215, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(459, 55)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Expense_btn
        ' 
        Expense_btn.BackColor = SystemColors.Highlight
        Expense_btn.Cursor = Cursors.Hand
        Expense_btn.Dock = DockStyle.Fill
        Expense_btn.FlatAppearance.BorderSize = 0
        Expense_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Expense_btn.ForeColor = SystemColors.Control
        Expense_btn.Location = New Point(117, 3)
        Expense_btn.Name = "Expense_btn"
        Expense_btn.Size = New Size(108, 49)
        Expense_btn.TabIndex = 2
        Expense_btn.Text = "Expense"
        Expense_btn.UseVisualStyleBackColor = False
        ' 
        ' Report_btn
        ' 
        Report_btn.BackColor = SystemColors.Highlight
        Report_btn.Cursor = Cursors.Hand
        Report_btn.Dock = DockStyle.Fill
        Report_btn.FlatAppearance.BorderSize = 0
        Report_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Report_btn.ForeColor = SystemColors.Control
        Report_btn.Location = New Point(231, 3)
        Report_btn.Name = "Report_btn"
        Report_btn.Size = New Size(108, 49)
        Report_btn.TabIndex = 3
        Report_btn.Text = "Report"
        Report_btn.UseVisualStyleBackColor = False
        ' 
        ' Income_btn
        ' 
        Income_btn.BackColor = SystemColors.Highlight
        Income_btn.Cursor = Cursors.Hand
        Income_btn.Dock = DockStyle.Fill
        Income_btn.FlatAppearance.BorderSize = 0
        Income_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Income_btn.ForeColor = SystemColors.Control
        Income_btn.Location = New Point(3, 3)
        Income_btn.Name = "Income_btn"
        Income_btn.Size = New Size(108, 49)
        Income_btn.TabIndex = 1
        Income_btn.Text = "Income"
        Income_btn.UseVisualStyleBackColor = False
        ' 
        ' Logout_btn
        ' 
        Logout_btn.BackColor = SystemColors.Highlight
        Logout_btn.Cursor = Cursors.Hand
        Logout_btn.Dock = DockStyle.Fill
        Logout_btn.FlatAppearance.BorderSize = 0
        Logout_btn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Logout_btn.ForeColor = SystemColors.Control
        Logout_btn.Location = New Point(345, 3)
        Logout_btn.Name = "Logout_btn"
        Logout_btn.Size = New Size(111, 49)
        Logout_btn.TabIndex = 4
        Logout_btn.Text = "Logout"
        Logout_btn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Controls.Add(Login_info2)
        Panel2.Controls.Add(Login_info1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 367)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(675, 38)
        Panel2.TabIndex = 5
        ' 
        ' Login_info2
        ' 
        Login_info2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login_info2.ForeColor = SystemColors.ControlLight
        Login_info2.Location = New Point(332, 0)
        Login_info2.Name = "Login_info2"
        Login_info2.Size = New Size(343, 38)
        Login_info2.TabIndex = 6
        Login_info2.Text = "Date Time"
        ' 
        ' Login_info1
        ' 
        Login_info1.BackColor = SystemColors.ActiveCaptionText
        Login_info1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login_info1.ForeColor = SystemColors.ControlLight
        Login_info1.Location = New Point(0, 0)
        Login_info1.Name = "Login_info1"
        Login_info1.Size = New Size(209, 38)
        Login_info1.TabIndex = 2
        Login_info1.Text = "User:"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Mainform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(675, 405)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Name = "Mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mainform"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Income_btn As Button
    Friend WithEvents Expense_btn As Button
    Friend WithEvents Report_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Login_info1 As Label
    Friend WithEvents Logout_btn As Button
    Friend WithEvents Login_info2 As Label
    Friend WithEvents Timer1 As Timer
End Class
