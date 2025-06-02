Imports System.Text.Json
Imports System.IO
'Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Public Class GameForm
    Public mainMenuRef As Form


    ' === Variabel Konfigurasi ===
    'Private SkinFolder As String = "images"
    Private SkinFolder As String = Settings.SelectedSkinFolder

    Private coverImage As Image

    ' === Variabel Informasi Pemain ===

    Public TingkatKesulitan As String
    Public ModePermainan As String
    Public NamaPemain As String

    ' === Variabel Game ===
    Private totalPasangan As Integer
    Private jumlahKolom As Integer
    Private jumlahBaris As Integer
    Private waktuTunggu As Double

    'timermodewaktu

    Private waktuAwalCountdown As TimeSpan

    Private gambarList As New List(Of Image)
    Private kartuArray() As PictureBox
    Private kartuTerbuka As New List(Of PictureBox)
    Private kartuSelesai As New List(Of PictureBox)
    Private random As New Random()

    Private isProcessing As Boolean = False
    Private kartuTimer As New Timer()
    Private WithEvents gameTimer As New Timer()
    Private waktuMain As TimeSpan = TimeSpan.Zero
    Private isGameStarted As Boolean = False
    Private isPaused As Boolean = False
    Private jumlahLangkah As Integer = 0

    Private isExiting As Boolean = False
    Private isGoingBackToMenu As Boolean = False

    'mainMenuRef = mainMenuRef


    'modeatantangan

    Private langkahSejakAcakUlang As Integer = 0
    Private langkahUntukAcakUlang As Integer = 0

    'bantuan

    Private bantuanTersisa As Integer = 0

    'db

    Private db As New dbManager()


    ' === Form Load ===
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinFolder = Settings.SelectedSkinFolder
        ApplyButtonHoverEffects(Me)
        SoundHelper.InitPlayer(Me)

        langkahSejakAcakUlang = 0


        KonfigurasiTingkatKesulitan()

        kartuTimer.Interval = CInt(waktuTunggu * 1000)

        AddHandler kartuTimer.Tick, AddressOf KartuTimer_Tick

        gameTimer.Interval = 1000

        If ModePermainan = "Waktu" Then
            waktuMain = waktuAwalCountdown
            lblTimer.Text = waktuMain.ToString("mm\:ss")
        Else
            waktuMain = TimeSpan.Zero
            lblTimer.Text = "00:00"
        End If

        lblLangkah.Text = "Langkah: 0"


        InisialisasiPapan()

        btnMenyerah.Enabled = False
        btnBantuan.Enabled = False
        btnBantuan.Text = $"Bantuan : {bantuanTersisa}"

    End Sub


    'Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ApplyButtonHoverEffects(Me)
    '    SoundHelper.InitPlayer(Me)

    '    KonfigurasiTingkatKesulitan()
    '    kartuTimer.Interval = CInt(waktuTunggu * 1000)
    '    AddHandler kartuTimer.Tick, AddressOf KartuTimer_Tick

    '    gameTimer.Interval = 1000
    '    lblTimer.Text = "00:00"
    '    lblLangkah.Text = "Langkah: 0"

    '    InisialisasiPapan()
    'End Sub

    'Private Sub KonfigurasiTingkatKesulitan()
    '    Select Case TingkatKesulitan
    '        Case "Mudah"
    '            jumlahKolom = 3 : jumlahBaris = 4 : totalPasangan = 6 : waktuTunggu = 1.5
    '        Case "Sedang"
    '            jumlahKolom = 4 : jumlahBaris = 4 : totalPasangan = 8 : waktuTunggu = 1.0
    '        Case "Sulit"
    '            jumlahKolom = 6 : jumlahBaris = 6 : totalPasangan = 18 : waktuTunggu = 0.8
    '    End Select
    'End Sub

    'Private Sub KonfigurasiTingkatKesulitan()
    '    Select Case TingkatKesulitan
    '        Case "Mudah"
    '            jumlahKolom = 3 : jumlahBaris = 4 : totalPasangan = 6 : waktuTunggu = 1.5
    '            If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(1)
    '        Case "Sedang"
    '            jumlahKolom = 4 : jumlahBaris = 4 : totalPasangan = 8 : waktuTunggu = 1.0
    '            If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(2)
    '        Case "Sulit"
    '            jumlahKolom = 6 : jumlahBaris = 6 : totalPasangan = 18 : waktuTunggu = 0.8
    '            If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(3)
    '    End Select
    'End Sub
    'Private Sub KonfigurasiTingkatKesulitan()
    '    Select Case TingkatKesulitan
    '        Case "Mudah"
    '            jumlahKolom = 3 : jumlahBaris = 4 : totalPasangan = 6 : waktuTunggu = 1.5
    '            If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(1)
    '            If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 3
    '        Case "Sedang"
    '            jumlahKolom = 4 : jumlahBaris = 4 : totalPasangan = 8 : waktuTunggu = 1.0
    '            If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(2)
    '            If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 6
    '        Case "Sulit"
    '            jumlahKolom = 6 : jumlahBaris = 6 : totalPasangan = 18 : waktuTunggu = 0.8
    '            If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(3)
    '            If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 12
    '    End Select
    'End Sub

    Private Sub KonfigurasiTingkatKesulitan()
        Select Case TingkatKesulitan
            Case "Mudah"
                jumlahKolom = 3 : jumlahBaris = 4 : totalPasangan = 6 : waktuTunggu = 1.5
                If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(1)
                If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 3
                bantuanTersisa = 1
            Case "Sedang"
                jumlahKolom = 4 : jumlahBaris = 4 : totalPasangan = 8 : waktuTunggu = 1.0
                If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(2)
                If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 6
                bantuanTersisa = 2
            Case "Sulit"
                jumlahKolom = 6 : jumlahBaris = 6 : totalPasangan = 18 : waktuTunggu = 0.8
                If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(3)
                If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 12
                bantuanTersisa = 3
        End Select
    End Sub


    ' === Skin / Cover Management ===
    Public Sub SetSkinFolder(folderName As String)
        SkinFolder = folderName
        LoadCoverImage()
        InisialisasiPapan()
    End Sub

    Private Sub LoadCoverImage()
        Dim coverPath = Path.Combine(Application.StartupPath, SkinFolder, "cover.png")
        'MessageBox.Show($"Cover Path: {coverPath}", "Debug Cover Path", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If File.Exists(coverPath) Then
            coverImage?.Dispose()
            coverImage = Image.FromFile(coverPath)
        Else
            coverImage?.Dispose()
            coverImage = Image.FromFile(Path.Combine(Application.StartupPath, "images", "cover.png"))
        End If

    End Sub

    ' === Inisialisasi Papan Permainan ===
    Private Sub InisialisasiPapan()
        gambarList.Clear()

        For i = 1 To totalPasangan
            Dim imgPath = Path.Combine(Application.StartupPath, SkinFolder, $"{i}.png")
            If Not File.Exists(imgPath) Then
                imgPath = Path.Combine(Application.StartupPath, "images", $"img ({i}).png")
            End If

            Dim img = Image.FromFile(imgPath)
            gambarList.Add(img)
            gambarList.Add(img)
        Next

        gambarList = gambarList.OrderBy(Function() random.Next()).ToList()

        TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel1.RowCount = jumlahBaris
        TableLayoutPanel1.ColumnCount = jumlahKolom
        TableLayoutPanel1.RowStyles.Clear()
        TableLayoutPanel1.ColumnStyles.Clear()

        For i = 0 To jumlahBaris - 1
            TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / jumlahBaris))
        Next

        For j = 0 To jumlahKolom - 1
            TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / jumlahKolom))
        Next

        ReDim kartuArray(jumlahBaris * jumlahKolom - 1)
        For i = 0 To kartuArray.Length - 1
            Dim pb As New PictureBox With {
                .Dock = DockStyle.Fill,
                .SizeMode = PictureBoxSizeMode.Zoom,
                .BorderStyle = BorderStyle.None,
                .Image = coverImage,
                .Tag = gambarList(i),
                .Margin = New Padding(2)
            }
            AddHandler pb.Click, AddressOf KartuKlik
            AddHandler pb.Paint, AddressOf PictureBox_Paint

            kartuArray(i) = pb
            TableLayoutPanel1.Controls.Add(pb, i Mod jumlahKolom, i \ jumlahKolom)
        Next
    End Sub

    Private Sub PictureBox_Paint(sender As Object, e As PaintEventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)
        Dim borderColor As Color = Color.Transparent
        Dim borderWidth As Integer = 3
        Dim rect As New Rectangle(0, 0, pb.Width - 1, pb.Height - 1)
        e.Graphics.DrawRectangle(New Pen(borderColor, borderWidth), rect)
    End Sub

    ' === Interaksi Kartu ===
    Private Sub KartuKlik(sender As Object, e As EventArgs)
        If isPaused OrElse isProcessing Then Exit Sub

        Dim pb As PictureBox = CType(sender, PictureBox)
        If kartuTerbuka.Contains(pb) OrElse kartuSelesai.Contains(pb) Then Exit Sub

        pb.Image = CType(pb.Tag, Image)

        If Not isGameStarted Then
            isGameStarted = True
            gameTimer.Start()

            btnMenyerah.Enabled = True
            btnBantuan.Enabled = True


        End If

        kartuTerbuka.Add(pb)

        If kartuTerbuka.Count = 2 Then
            jumlahLangkah += 1
            lblLangkah.Text = $"Langkah: {jumlahLangkah}"
            isProcessing = True
            kartuTimer.Start()
            'If ModePermainan = "Tantangan" Then
            '    langkahSejakAcakUlang += 1
            '    If langkahSejakAcakUlang >= langkahUntukAcakUlang Then
            '        langkahSejakAcakUlang = 0
            '        AcakUlangKartu()
            '    End If
            'End If

            'gabisa diflip lagi njim

            If ModePermainan = "Tantangan" Then
                langkahSejakAcakUlang += 1
            End If


        End If
    End Sub

    Private Sub KartuTimer_Tick(sender As Object, e As EventArgs)
        kartuTimer.Stop()

        'If kartuTerbuka(0).Tag.Equals(kartuTerbuka(1).Tag) Then
        If kartuTerbuka.Count >= 2 AndAlso kartuTerbuka(0).Tag.Equals(kartuTerbuka(1).Tag) Then
            kartuSelesai.AddRange(kartuTerbuka)
            'SoundHelper.Playcorrect()
        Else
            For Each k In kartuTerbuka
                k.Image = coverImage
            Next
            'SoundHelper.PlayWrong()
        End If



        kartuTerbuka.Clear()



        isProcessing = False


        If ModePermainan = "Tantangan" AndAlso langkahSejakAcakUlang >= langkahUntukAcakUlang Then
            langkahSejakAcakUlang = 0
            AcakUlangKartu()
            MessageBox.Show("Kartu diacak ulang!", "Tantangan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If kartuSelesai.Count = totalPasangan * 2 AndAlso Not isExiting Then
            isExiting = True
            gameTimer.Stop()
            Dim skor = HitungSkor()
            MessageBox.Show($"Selamat! Kamu menyelesaikan permainan.{vbCrLf}" &
                            $"Waktu: {waktuMain:mm\:ss}{vbCrLf}" &
                            $"Langkah: {jumlahLangkah}{vbCrLf}" &
                            $"Skor: {skor}", "Permainan Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)

            SimpanSkor(NamaPemain, skor, TingkatKesulitan, ModePermainan)

            Dim scoreForm As New ScoreForm With {.mainMenuRef = mainMenuRef}
            scoreForm.Show()
            Me.Close()
        End If

    End Sub

    ' === Timer Game ===
    'Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
    '    waktuMain = waktuAwalCountdown

    '    lblTimer.Text = waktuMain.ToString("mm\:ss")
    'End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If ModePermainan = "Waktu" Then
            waktuMain = waktuMain.Subtract(TimeSpan.FromSeconds(1))
            If waktuMain.TotalSeconds <= 0 Then
                waktuMain = TimeSpan.Zero
                lblTimer.Text = waktuMain.ToString("mm\:ss")
                gameTimer.Stop()
                kartuTimer.Stop()
                MessageBox.Show("Waktu habis! Permainan berakhir.", "Waktu Habis", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim gameModeForm As New GameModeForm()
                gameModeForm.mainMenuRef = mainMenuRef
                gameModeForm.Show()
                Me.Close()
                Return
            End If
            lblTimer.Text = waktuMain.ToString("mm\:ss")
        Else
            waktuMain = waktuMain.Add(TimeSpan.FromSeconds(1))
            lblTimer.Text = waktuMain.ToString("mm\:ss")
        End If
    End Sub


    ' === Tombol Kontrol ===
    Private Sub btnMenyerah_Click(sender As Object, e As EventArgs) Handles btnMenyerah.Click
        SoundHelper.PlayButtonSound2()

        If MessageBox.Show("Ingin Menyerah?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            gameTimer.Stop()
            kartuTimer.Stop()

            For Each pb As PictureBox In kartuArray
                pb.Image = CType(pb.Tag, Image)
            Next

            MessageBox.Show("Permainan berakhir. Coba lagi lain waktu!", "Menyerah")

            ' Kembali ke GameModeForm
            Dim gameModeForm As New GameModeForm()
            gameModeForm.mainMenuRef = Me.mainMenuRef
            gameModeForm.Show()

            ' Tambahkan baris berikut:
            isGoingBackToMenu = True

            Me.Close()
        End If
    End Sub



    Private Sub btnJeda_Click(sender As Object, e As EventArgs) Handles btnJeda.Click
        SoundHelper.PlayButtonSound()

        If Not isGameStarted Then Return

        isPaused = Not isPaused

        If isPaused Then
            gameTimer.Stop()
            btnJeda.Text = "Lanjut"
        Else
            gameTimer.Start()
            btnJeda.Text = "Jeda"
        End If
    End Sub

    Private Sub btnBantuan_Click(sender As Object, e As EventArgs) Handles btnBantuan.Click
        SoundHelper.PlayButtonSound2()
        If bantuanTersisa <= 0 Then
            btnBantuan.Enabled = False
            Return
        End If
        bantuanTersisa -= 1
        btnBantuan.Text = $"Bantuan : {bantuanTersisa}"
        For Each pb As PictureBox In kartuArray
            If Not kartuSelesai.Contains(pb) Then
                pb.Image = CType(pb.Tag, Image)
            End If
        Next
        Dim durasiBantuan As Integer

        'durasiBantuan = 5
        Select Case TingkatKesulitan
            Case "Mudah"
                durasiBantuan = 1000
            Case "Sedang"
                durasiBantuan = 1750
            Case "Sulit"
                durasiBantuan = 2500
        End Select



        Dim t As New Timer With {.Interval = durasiBantuan}
        AddHandler t.Tick, Sub()
                               For Each pb As PictureBox In kartuArray
                                   If Not kartuSelesai.Contains(pb) AndAlso Not kartuTerbuka.Contains(pb) Then
                                       pb.Image = coverImage
                                   End If
                               Next
                               t.Stop()
                               t.Dispose()
                           End Sub
        t.Start()

        If bantuanTersisa = 0 Then
            btnBantuan.Enabled = False
        End If
    End Sub



    ' === Skor dan Penyimpanan ===
    'Private Function HitungSkor() As Integer
    '    Dim faktor As Double = If(TingkatKesulitan = "Sulit", 2.0, If(TingkatKesulitan = "Sedang", 1.5, 1.0))
    '    Dim waktuDetik = CInt(waktuMain.TotalSeconds)
    '    Dim skor = CInt((1000 * faktor) - (jumlahLangkah * 5) - (waktuDetik * 2))
    '    Return Math.Max(skor, 0)
    'End Function

    Private Function HitungSkor() As Integer
        Dim faktor As Double = If(TingkatKesulitan = "Sulit", 2.0, If(TingkatKesulitan = "Sedang", 1.5, 1.0))
        Dim skor As Integer

        If ModePermainan = "Waktu" Then
            Dim waktuSisaDetik = CInt(waktuMain.TotalSeconds)
            Dim waktuTotalDetik As Integer
            Select Case TingkatKesulitan
                Case "Mudah"
                    waktuTotalDetik = 60
                Case "Sedang"
                    waktuTotalDetik = 120
                Case "Sulit"
                    waktuTotalDetik = 180
            End Select
            skor = CInt((1000 * faktor) + (waktuSisaDetik * 5) - (jumlahLangkah * 5))
        Else
            Dim waktuPakaiDetik = CInt(waktuMain.TotalSeconds)
            skor = CInt((1000 * faktor) - (jumlahLangkah * 5) - (waktuPakaiDetik * 2))
        End If

        Return Math.Max(skor, 0)
    End Function




    'pindah DbMngr

    'Public Sub SimpanSkor(nama As String, skor As Integer, tingkatKesulitan As String, modePermainan As String)
    '    Dim dbPath As String = "resources\leaderboard.db"
    '    If Not Directory.Exists("resources") Then
    '        Directory.CreateDirectory("resources")
    '    End If

    '    If Not File.Exists(dbPath) Then
    '        SQLiteConnection.CreateFile(dbPath)
    '    End If

    '    Dim connectionString As String = $"Data Source={dbPath};Version=3;"

    '    ' Buat tabel jika belum ada
    '    Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS leaderboard (
    '    id INTEGER PRIMARY KEY AUTOINCREMENT,
    '    nama TEXT,
    '    skor INTEGER,
    '    tingkat_kesulitan TEXT,
    '    mode_permainan TEXT,
    '    tanggal TEXT DEFAULT (datetime('now','localtime'))
    ')"

    '    Using conn As New SQLiteConnection(connectionString)
    '        conn.Open()

    '        ' Pastikan tabel ada
    '        Using cmd As New SQLiteCommand(createTableQuery, conn)
    '            cmd.ExecuteNonQuery()
    '        End Using

    '        ' Simpan skor hasil permainan
    '        Dim insertQuery As String = "INSERT INTO leaderboard (nama, skor, tingkat_kesulitan, mode_permainan) 
    '                                 VALUES (@nama, @skor, @tingkat, @mode)"

    '        Using cmd As New SQLiteCommand(insertQuery, conn)
    '            cmd.Parameters.AddWithValue("@nama", nama)
    '            cmd.Parameters.AddWithValue("@skor", skor)
    '            cmd.Parameters.AddWithValue("@tingkat", tingkatKesulitan)
    '            cmd.Parameters.AddWithValue("@mode", modePermainan)
    '            cmd.ExecuteNonQuery()
    '        End Using
    '    End Using
    'End Sub




    ' === Penanganan Form Close ===
    Public Sub SimpanSkor(nama As String, skor As Integer, tingkatKesulitan As String, modePermainan As String)
        db.SimpanSkor(nama, skor, tingkatKesulitan, modePermainan)
    End Sub


    Private Sub GameForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SoundHelper.PlayBackgroundMusic()
        If isExiting Then
            Application.Exit()
        Else
            mainMenuRef?.Show()

        End If
    End Sub


    Private Sub AcakUlangKartu()
        ' Ambil hanya kartu yang belum selesai
        Dim kartuBelumSelesai = kartuArray.Where(Function(pb) Not kartuSelesai.Contains(pb)).ToList()
        ' Ambil gambar dari kartu yang belum selesai
        Dim gambarBelumSelesai = kartuBelumSelesai.Select(Function(pb) pb.Tag).ToList()
        ' Acak gambar
        gambarBelumSelesai = gambarBelumSelesai.OrderBy(Function() random.Next()).ToList()
        ' Set gambar acak ke kartu
        For i = 0 To kartuBelumSelesai.Count - 1
            kartuBelumSelesai(i).Tag = gambarBelumSelesai(i)
            kartuBelumSelesai(i).Image = coverImage
        Next
        kartuTerbuka.Clear()
        isProcessing = False
    End Sub
End Class
