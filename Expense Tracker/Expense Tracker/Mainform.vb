Public Class Mainform

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Login_info2.Text = Date.Now.ToString("dd-MM-yyyy    hh:mm:ss tt")
    End Sub
End Class