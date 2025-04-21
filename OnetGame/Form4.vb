Imports System.Text.Json
Imports System.IO
Public Class ScoreForm
    Private Sub LeaderboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadLeaderboard()
    End Sub

    Private Sub LoadLeaderboard()
        Dim path As String = "leaderboard.json"

        If File.Exists(path) Then
            Dim jsonString = File.ReadAllText(path)
            Dim daftarSkor As List(Of CreateJson) = JsonSerializer.Deserialize(Of List(Of CreateJson))(jsonString)
            DataGridView1.DataSource = daftarSkor
        Else
            MessageBox.Show("Leaderboard tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim MainMenuForm As New MainMenuForm()
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class