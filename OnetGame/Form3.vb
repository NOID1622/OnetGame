Imports System.Text.Json
Imports System.IO
Public Class GameForm


    Public TingkatKesulitan As String
    Public ModePermainan As String
    Public NamaPemain As String

    Private totalPasangan As Integer
    Private jumlahKolom As Integer
    Private jumlahBaris As Integer
    Private waktuTunggu As Double

    Private gambarList As New List(Of Image)
    Private kartuArray() As PictureBox
    Private kartuTerbuka As New List(Of PictureBox)
    Private kartuSelesai As New List(Of PictureBox)
    Private random As New Random()

    Private isProcessing As Boolean = False
    Private kartuTimer As New Timer()

    Private gameTimer As New Timer()
    Private waktuMain As TimeSpan = TimeSpan.Zero
    Private isGameStarted As Boolean = False

    Private isPaused As Boolean = False

    Private jumlahLangkah As Integer = 0

    'Private kartuTerbukaCounter As Integer = 0
    'Private maxTerbukaTantangan As Integer = 6 ' 


    'Private isGameOver As Boolean = False
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = New Icon("images\icon.ico")

        Select Case TingkatKesulitan
            Case "Mudah"
                jumlahKolom = 3
                jumlahBaris = 4
                totalPasangan = 6
                waktuTunggu = 1.5
            Case "Sedang"
                jumlahKolom = 4
                jumlahBaris = 4
                totalPasangan = 8
                waktuTunggu = 1.0
            Case "Sulit"
                jumlahKolom = 6
                jumlahBaris = 6
                totalPasangan = 18
                waktuTunggu = 0.8
        End Select

        kartuTimer.Interval = CInt(waktuTunggu * 1000)
        AddHandler kartuTimer.Tick, AddressOf KartuTimer_Tick

        gameTimer.Interval = 1000 ' 1 detik
        AddHandler gameTimer.Tick, AddressOf GameTimer_Tick

        lblTimer.Text = "00:00"

        InisialisasiPapan()
    End Sub


    Private Sub btnJeda_Click(sender As Object, e As EventArgs) Handles btnJeda.Click
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




    Private Sub InisialisasiPapan()

        gambarList.Clear()
        For i = 1 To totalPasangan
            Dim img As Image = Image.FromFile($"images\img ({i}).png")
            gambarList.Add(img)
            gambarList.Add(img)
        Next

        gambarList = gambarList.OrderBy(Function() random.Next()).ToList()

        TableLayoutPanel1.Controls.Clear()
        'TableLayoutPanel1.RowCount 
        TableLayoutPanel1.RowCount = jumlahBaris

        TableLayoutPanel1.ColumnCount = jumlahKolom
        TableLayoutPanel1.RowStyles.Clear()
        TableLayoutPanel1.ColumnStyles.Clear()
        TableLayoutPanel1.Dock = DockStyle.Fill


        ReDim kartuArray(jumlahBaris * jumlahKolom - 1)

        For i = 0 To jumlahBaris - 1
            TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / jumlahBaris))
        Next
        For j = 0 To jumlahKolom - 1
            TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / jumlahKolom))
        Next

        For i = 0 To jumlahBaris * jumlahKolom - 1
            Dim pb As New PictureBox()
            pb.Dock = DockStyle.Fill
            pb.SizeMode = PictureBoxSizeMode.Zoom

            pb.Image = Image.FromFile("images\cover.png")

            pb.Tag = gambarList(i)
            AddHandler pb.Click, AddressOf KartuKlik
            AddHandler pb.Paint, AddressOf PictureBox_Paint
            kartuArray(i) = pb
            TableLayoutPanel1.Controls.Add(pb, i Mod jumlahKolom, i \ jumlahKolom)
        Next
    End Sub

    Private Sub PictureBox_Paint(sender As Object, e As PaintEventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)

        Dim borderColor As Color = Color.Black
        Dim borderWidth As Integer = 3
        Dim rect As New Rectangle(0, 0, pb.Width - 1, pb.Height - 1)
        e.Graphics.DrawRectangle(New Pen(borderColor, borderWidth), rect)

    End Sub


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
            lblLangkah.Text = "Langkah: " & jumlahLangkah
            isProcessing = True
            kartuTimer.Interval = CInt(waktuTunggu * 1000)
            kartuTimer.Start()
        End If

        'mode

        'If ModePermainan = "Tantangan" Then
        '    kartuTerbukaCounter += 1
        '    If kartuTerbukaCounter >= maxTerbukaTantangan Then
        '        kartuTerbukaCounter = 0
        '        'AcakUlangKartu()
        'End If
        'End If
        'If ModePermainan = "Waktu" Then

        'End If
    End Sub

    Private Sub KartuTimer_Tick(sender As Object, e As EventArgs)
        kartuTimer.Stop()

        If kartuTerbuka(0).Tag.Equals(kartuTerbuka(1).Tag) Then
            kartuSelesai.AddRange(kartuTerbuka)
        Else
            For Each k In kartuTerbuka
                k.Image = Image.FromFile("images\cover.png")
            Next
        End If

        kartuTerbuka.Clear()
        isProcessing = False

        If kartuSelesai.Count = totalPasangan * 2 Then
            gameTimer.Stop()
            Dim skor As Integer = HitungSkor()
            MessageBox.Show($"Selamat! Kamu menyelesaikan permainan." & vbCrLf &
                            $"Waktu: {waktuMain.ToString("mm\:ss")}" & vbCrLf &
                            $"Langkah: {jumlahLangkah}" & vbCrLf &
                            $"Skor: {skor}", "Permainan Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Dim skor As Integer = HitungSkor()
            SimpanSkor(NamaPemain, skor, TingkatKesulitan, ModePermainan)

            Dim gameModeForm As New GameModeForm()
            gameModeForm.Show()
            Me.Close()
        End If
    End Sub
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs)
        waktuMain = waktuMain.Add(TimeSpan.FromSeconds(1))
        lblTimer.Text = waktuMain.ToString("mm\:ss")
    End Sub

    Private Sub btnMenyerah_Click(sender As Object, e As EventArgs) Handles btnMenyerah.Click


        Dim result = MessageBox.Show("Ingin Menyerah?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            gameTimer.Stop()
            For Each pb In kartuArray
                pb.Image = CType(pb.Tag, Image)
            Next
            MessageBox.Show("Permainan berakhir. Coba lagi lain waktu!", "Menyerah")
            GameModeForm.Show()
            Me.Close()
        End If
    End Sub



    Private Function HitungSkor() As Integer

        'Skor = (1000 × TingkatKesulitan) - (JumlahLangkah × 5) - (WaktuDetik × 2)

        Dim faktorKesulitan As Double
        Select Case TingkatKesulitan
            Case "Mudah"
                faktorKesulitan = 1.0
            Case "Sedang"
                faktorKesulitan = 1.5
            Case "Sulit"
                faktorKesulitan = 2.0
        End Select

        Dim waktuDetik As Integer = CInt(waktuMain.TotalSeconds)
        Dim skor As Integer = CInt((1000 * faktorKesulitan) - (jumlahLangkah * 5) - (waktuDetik * 2))

        Return skor
    End Function

    Public Sub SimpanSkor(nama As String, skor As Integer, tingkatKesulitan As String, modePermainan As String)

        Dim path As String = "resources/leaderboard.json"

        Dim daftarSkor As New List(Of CreateJson)

        If File.Exists(path) Then
            Dim jsonString = File.ReadAllText(path)
            daftarSkor = JsonSerializer.Deserialize(Of List(Of CreateJson))(jsonString)
        End If

        'daftarSkor.Add(New CreateJson With {
        '   .Nama = "Tes"})

        daftarSkor.Add(New CreateJson With {
        .Nama = nama,
        .Skor = skor,
        .TingkatKesulitan = tingkatKesulitan,
        .ModePermainan = modePermainan
    })

        Dim output = JsonSerializer.Serialize(daftarSkor, New JsonSerializerOptions With {.WriteIndented = True})
        File.WriteAllText(path, output)
    End Sub

End Class