Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2Instance As New Form2
        form2Instance.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'call application.Exit() to terminate the application
        Application.Exit()
    End Sub
End Class
