Public Class MainMenuForm

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = New Icon("images\icon.ico")

    End Sub

    Private Sub strBtn_Click(sender As Object, e As EventArgs) Handles strBtn.Click
        Dim gmForm As New GameModeForm
        gmForm.Show()
        Hide()
    End Sub

    Private Sub extBtn_Click(sender As Object, e As EventArgs) Handles extBtn.Click
        Me.Close()
    End Sub

    Private Sub scrBtn_Click(sender As Object, e As EventArgs) Handles scrBtn.Click
        Dim scoreForm As New ScoreForm()
        scoreForm.Show()
        Me.Hide()
    End Sub

    '
    'lbl
    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    'End Sub
End Class
