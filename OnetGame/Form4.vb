Imports System.Text.Json
Imports System.IO

Public Class ScoreForm
    Public mainMenuRef As Form
    Private kembaliKeMenu As Boolean = False

    Private Sub ScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyButtonHoverEffects(Me)
        LoadLeaderboard()
        SoundHelper.InitPlayer(Me)
        DataGridView1.setcellTransparent()
    End Sub

    Private Sub LoadLeaderboard()
        Dim path As String = "resources/leaderboard.json"

        If File.Exists(path) Then
            Dim jsonString = File.ReadAllText(path)
            Dim daftarSkor As List(Of CreateJson) = JsonSerializer.Deserialize(Of List(Of CreateJson))(jsonString)
            DataGridView1.DataSource = daftarSkor
        End If

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        SoundHelper.PlayButtonSound2()
        kembaliKeMenu = True
        Me.Close()
    End Sub

    Private Sub ScoreForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If kembaliKeMenu Then
            mainMenuRef?.Show()
        Else
            Application.Exit()
        End If
    End Sub
End Class
