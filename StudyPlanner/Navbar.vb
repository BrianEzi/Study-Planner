Public Class Navbar
    Private Sub BtnCalendar_Click(sender As Object, e As EventArgs) Handles BtnCalendar.Click
        MonthFrm.Show()
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        PlusFrm.Show()
    End Sub

    Private Sub BtnActivities_Click(sender As Object, e As EventArgs) Handles BtnActivities.Click
        ActivityFrm.Show()
    End Sub
End Class
