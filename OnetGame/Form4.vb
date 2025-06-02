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
        Dim dbPath As String = "resources/leaderboard.db"
        Dim connectionString As String = $"Data Source={dbPath};Version=3;"
        Dim query As String = "
        SELECT nama, skor, tingkat_kesulitan, mode_permainan, tanggal
        FROM leaderboard
        ORDER BY 
            CASE mode_permainan
                WHEN 'Tantangan' THEN 1
                WHEN 'Waktu' THEN 2
                WHEN 'Klasik' THEN 3
                ELSE 4
            END,
            skor DESC"

        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()

                Using cmd As New SQLiteCommand(query, conn)
                    Using adapter As New SQLiteDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        table.Columns.Add("No", GetType(Integer))
                        For i As Integer = 0 To table.Rows.Count - 1
                            table.Rows(i)("No") = i + 1
                        Next
                        table.Columns("No").SetOrdinal(0)
                        If table.Columns.Contains("tanggal") Then
                            table.Columns.Remove("tanggal")
                        End If

                        'table.Columns("No").ColumnName = "No"
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

                        'table.Columns.Add("No", GetType(Integer))
                        'For i As Integer = 0 To table.Rows.Count - 1
                        '    table.Rows(i)("No") = i + 1
                        'Next

                        'table.Columns("No").SetOrdinal(0)

                        DataGridView1.DataSource = table
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat leaderboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
