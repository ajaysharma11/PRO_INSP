Public Class FORM_ATAG
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CMD_MY_DATA_Click(sender As Object, e As EventArgs) Handles CMD_MY_DATA.Click
        Form2.Show()
    End Sub

    Private Sub CMDJOM_Click(sender As Object, e As EventArgs)
        'Form3.Show()
    End Sub

    Private Sub CMD_BEAT_Click(sender As Object, e As EventArgs) Handles CMD_BEAT.Click
        Form4.Show()
    End Sub
End Class