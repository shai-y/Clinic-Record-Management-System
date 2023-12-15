Public Class Student___New_Record

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        New_Record.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        MessageBox.Show("Record successfully added", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class