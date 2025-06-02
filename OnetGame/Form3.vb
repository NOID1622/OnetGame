Imports System.Text.Json
Imports System.IO

Public Class GameForm
    ' === Variabel Konfigurasi ===
    Private SkinFolder As String = "images"
    Private coverImage As Image

    ' === Variabel Informasi Pemain ===
    Public mainMenuRef As Form
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

    ' === Form Load ===
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub KonfigurasiTingkatKesulitan()
        Select Case TingkatKesulitan
            Case "Mudah"
                jumlahKolom = 3 : jumlahBaris = 4 : totalPasangan = 6 : waktuTunggu = 1.5
                If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(1)
                If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 3
            Case "Sedang"
                jumlahKolom = 4 : jumlahBaris = 4 : totalPasangan = 8 : waktuTunggu = 1.0
                If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(2)
                If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 6
            Case "Sulit"
                jumlahKolom = 6 : jumlahBaris = 6 : totalPasangan = 18 : waktuTunggu = 0.8
                If ModePermainan = "Waktu" Then waktuAwalCountdown = TimeSpan.FromMinutes(3)
                If ModePermainan = "Tantangan" Then langkahUntukAcakUlang = 12
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

        If File.Exists(coverPath) Then
            coverImage?.Dispose()
            coverImage = Image.FromFile(coverPath)
        Else
            coverImage?.Dispose()
            coverImage = Image.FromFile(Path.Combine(Application.StartupPath, "images", "cover.png"))
        End If

        ' Tampilkan ke PictureBox jika ada (pastikan kontrolnya bernama PictureBoxCover)
        'If PictureBoxCover IsNot Nothing Then
        '    PictureBoxCover.Image = coverImage
        'End If
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
            '        MessageBox.Show("Kartu diacak ulang!", "Tantangan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    End If
            'End If
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
        Else
            For Each k In kartuTerbuka
                k.Image = coverImage
            Next
        End If


        kartuTerbuka.Clear()



        isProcessing = False


        If ModePermainan = "Tantangan" AndAlso langkahSejakAcakUlang >= langkahUntukAcakUlang Then
            langkahSejakAcakUlang = 0
            AcakUlangKartu()
            MessageBox.Show("Kartu diacak ulang!", "Tantangan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If kartuSelesai.Count = totalPasangan * 2 Then
            gameTimer.Stop()
            Dim skor = HitungSkor()
            MessageBox.Show($"Selamat! Kamu menyelesaikan permainan.{vbCrLf}" &
                            $"Waktu: {waktuMain:mm\:ss}{vbCrLf}" &
                            $"Langkah: {jumlahLangkah}{vbCrLf}" &
                            $"Skor: {skor}", "Permainan Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)

            SimpanSkor(NamaPemain, skor, TingkatKesulitan, ModePermainan)

            Dim scoreForm As New ScoreForm With {.mainMenuRef = mainMenuRef}
            scoreForm.Show()
            Me.Hide()
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

            'Dim gameModeForm As New GameModeForm()
            'GameModeForm
            GameModeForm.mainMenuRef = mainMenuRef
            GameModeForm.Show()
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
        MessageBox.Show("Temukan semua pasangan gambar dengan mengingat letaknya. Selamat bermain!", "Petunjuk")
    End Sub

    ' === Skor dan Penyimpanan ===
    Private Function HitungSkor() As Integer
        Dim faktor As Double = If(TingkatKesulitan = "Sulit", 2.0, If(TingkatKesulitan = "Sedang", 1.5, 1.0))
        Dim waktuDetik = CInt(waktuMain.TotalSeconds)
        Dim skor = CInt((1000 * faktor) - (jumlahLangkah * 5) - (waktuDetik * 2))
        Return Math.Max(skor, 0)
    End Function

    Public Sub SimpanSkor(nama As String, skor As Integer, tingkatKesulitan As String, modePermainan As String)
        Dim path As String = "resources/leaderboard.json"
        Dim daftarSkor As New List(Of CreateJson)

        If File.Exists(path) Then
            Dim jsonString = File.ReadAllText(path)
            daftarSkor = JsonSerializer.Deserialize(Of List(Of CreateJson))(jsonString)
        End If

        daftarSkor.Add(New CreateJson With {
            .Nama = nama,
            .Skor = skor,
            .TingkatKesulitan = tingkatKesulitan,
            .ModePermainan = modePermainan
        })

        Dim output = JsonSerializer.Serialize(daftarSkor, New JsonSerializerOptions With {.WriteIndented = True})
        File.WriteAllText(path, output)
    End Sub

    ' === Penanganan Form Close ===

    Private Sub GameForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isExiting Then
            Application.Exit()
        ElseIf isGoingBackToMenu Then
            ' biarkan tutup
        Else
            e.Cancel = True
            Me.Hide()
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
