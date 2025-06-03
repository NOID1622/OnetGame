Imports System.Text.Json
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class ScoreForm
    Public mainMenuRef As Form
    Private kembaliKeMenu As Boolean = False

    Private Sub ScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyButtonHoverEffects(Me)
        LoadLeaderboard()
        SoundHelper.InitPlayer(Me)
        DataGridView1.setcellTransparent()
    End Sub




    Public Sub LoadLeaderboard()
        Dim db As New dbManager()
        Dim table As DataTable = db.GetLeaderboardTable()
        table.Columns.Add("No", GetType(Integer))
        For i As Integer = 0 To table.Rows.Count - 1
            table.Rows(i)("No") = i + 1
        Next
        table.Columns("No").SetOrdinal(0)
        If table.Columns.Contains("tanggal") Then
            table.Columns.Remove("tanggal")
        End If
        table.Columns("nama").ColumnName = "Nama"
        table.Columns("skor").ColumnName = "Score"
        table.Columns("tingkat_kesulitan").ColumnName = "Kesulitan"
        table.Columns("mode_permainan").ColumnName = "Mode"

        DataGridView1.DataSource = table
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.Columns("No").DisplayIndex = 0
        DataGridView1.Columns("Nama").DisplayIndex = 1
        DataGridView1.Columns("Score").DisplayIndex = 2
        DataGridView1.Columns("Kesulitan").DisplayIndex = 3
        DataGridView1.Columns("Mode").DisplayIndex = 4
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        SoundHelper.PlayButtonSound2()

        mainMenuRef?.Show()
        'kembaliKeMenu = True
        Me.Close()
    End Sub

    'Private Sub ScoreForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    If kembaliKeMenu Then
    '        mainMenuRef?.Show()
    '    Else
    '        Application.Exit()
    '    End If
    'End Sub

End Class
