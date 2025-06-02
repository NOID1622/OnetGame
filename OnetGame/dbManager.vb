Imports System.Data.SQLite
Imports System.IO

Public Class dbManager
    Private ReadOnly dbPath As String = "resources\leaderboard.db"
    Private ReadOnly connectionString As String

    Public Sub New()
        connectionString = $"Data Source={dbPath};Version=3;"
    End Sub

    Public Sub SimpanSkor(nama As String, skor As Integer, tingkatKesulitan As String, modePermainan As String)
        InitDatabase() ' Ensure DB and table exist

        Dim connectionString As String = $"Data Source=resources\leaderboard.db;Version=3;"
        Dim insertQuery As String = "INSERT INTO leaderboard (nama, skor, tingkat_kesulitan, mode_permainan) 
                                 VALUES (@nama, @skor, @tingkat, @mode)"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@skor", skor)
                cmd.Parameters.AddWithValue("@tingkat", tingkatKesulitan)
                cmd.Parameters.AddWithValue("@mode", modePermainan)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Public Sub InitDatabase()
        If Not Directory.Exists("resources") Then
            Directory.CreateDirectory("resources")
        End If

        If Not File.Exists(dbPath) Then
            SQLiteConnection.CreateFile(dbPath)
        End If

        Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS leaderboard (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nama TEXT,
            skor INTEGER,
            tingkat_kesulitan TEXT,
            mode_permainan TEXT,
            tanggal TEXT DEFAULT (datetime('now','localtime'))
        )"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(createTableQuery, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
