Imports System.IO
Imports System.Text.Json

Public Class GameModeForm

    ' === Properti untuk komunikasi antar-form ===
    Public Property SelectedSkinFolder As String = "images"
    Public mainMenuRef As Form

    ' === Variabel untuk menyimpan pilihan user ===
    Public selectedDifficulty As String = ""
    Public selectedMode As String = ""


    'Private bantuanTersisa As Integer = 0


    Private Sub GameModeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyButtonHoverEffects(Me)
        SoundHelper.InitPlayer(Me)

    End Sub

    ' === Klik tombol Start ===
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        SoundHelper.PlayButtonSound2()

        ' Validasi input user
        If selectedDifficulty = "" OrElse selectedMode = "" OrElse String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Pilih tingkat kesulitan, mode permainan, dan isi nama.")
            Return
        End If

        ' Buat dan konfigurasi GameForm
        Dim gameForm As New GameForm()
        gameForm.mainMenuRef = mainMenuRef
        gameForm.TingkatKesulitan = selectedDifficulty
        gameForm.ModePermainan = selectedMode
        gameForm.NamaPemain = txtNama.Text
        gameForm.SetSkinFolder(SelectedSkinFolder) ' Teruskan skin folder yang dipilih

        gameForm.Show()
        Me.Hide()
    End Sub

    ' === Tingkat Kesulitan ===
    Private Sub btnMudah_Click(sender As Object, e As EventArgs) Handles btnMudah.Click
        selectedDifficulty = "Mudah"
        ButtonEffects.AturAktif(btnMudah, New List(Of Button) From {btnMudah, btnSedang, btnSulit})
    End Sub

    Private Sub btnSedang_Click(sender As Object, e As EventArgs) Handles btnSedang.Click
        selectedDifficulty = "Sedang"
        ButtonEffects.AturAktif(btnSedang, New List(Of Button) From {btnMudah, btnSedang, btnSulit})
    End Sub

    Private Sub btnSulit_Click(sender As Object, e As EventArgs) Handles btnSulit.Click
        selectedDifficulty = "Sulit"
        ButtonEffects.AturAktif(btnSulit, New List(Of Button) From {btnMudah, btnSedang, btnSulit})
    End Sub

    ' === Mode Permainan ===
    Private Sub btnKlasik_Click(sender As Object, e As EventArgs) Handles btnKlasik.Click
        SoundHelper.PlayBackgroundMusic()
        selectedMode = "Klasik"
        ButtonEffects.AturAktif(btnKlasik, New List(Of Button) From {btnKlasik, btnWaktu, btnTantangan})
    End Sub

    Private Sub btnWaktu_Click(sender As Object, e As EventArgs) Handles btnWaktu.Click
        selectedMode = "Waktu"
        ButtonEffects.AturAktif(btnWaktu, New List(Of Button) From {btnKlasik, btnWaktu, btnTantangan})

        ' Ganti musik ke timer mode
        SoundHelper.PlayTimerModeMusic()
    End Sub


    Private Sub btnTantangan_Click(sender As Object, e As EventArgs) Handles btnTantangan.Click

        selectedMode = "Tantangan"
        ButtonEffects.AturAktif(btnTantangan, New List(Of Button) From {btnKlasik, btnWaktu, btnTantangan})
        SoundHelper.PlayButtonSoundtantang()
    End Sub

    ' === Kembali ke Main Menu ===
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        SoundHelper.PlayButtonSound2()
        If mainMenuRef IsNot Nothing Then
            mainMenuRef.Show()
        End If
        Me.Hide()
    End Sub

    ' === Tangani saat form ditutup (X ditekan) ===
    Private Sub GameModeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If mainMenuRef IsNot Nothing AndAlso Not Me.Visible Then
            e.Cancel = True ' Hanya disembunyikan, bukan keluar
        Else
            Application.Exit() ' Benar-benar keluar aplikasi
        End If
    End Sub

End Class
