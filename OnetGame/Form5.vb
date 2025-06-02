Public Class SettingForm
    ' Menyimpan skin yang dipilih oleh pengguna
    Private selectedSkin As String = ""

    ' Properti publik untuk digunakan di form lain
    Public Property SelectedSkinFolder As String = "images"

    ' Referensi ke MainMenuForm untuk kembali setelah selesai
    Public Property mainMenuRef As Form

    ' Menandai apakah akan kembali ke menu saat Form ditutup
    Private kembaliKeMenu As Boolean = False

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyButtonHoverEffects(Me)
        SoundHelper.InitPlayer(Me)

        ' Mengaktifkan transparansi latar belakang jika diperlukan
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        ' Inisialisasi tampilan tombol skin
        ButtonEffects.AturAktif(Nothing, New List(Of Button) From {btnMarvel, btnPokemon})
    End Sub

    ' Tombol kembali ke menu utama
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        SoundHelper.PlayButtonSound()

        kembaliKeMenu = True

        If mainMenuRef IsNot Nothing Then
            mainMenuRef.Show()
        End If

        Me.Close() ' Tutup form ini (FormClosing akan menangani kembali ke menu)
    End Sub

    ' Menangani event saat form ditutup
    Private Sub SettingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If kembaliKeMenu Then
            mainMenuRef?.Show()
        Else
            Application.Exit() ' Tutup aplikasi sepenuhnya jika bukan dari tombol kembali
        End If
    End Sub

    ' Tombol memilih skin Marvel
    Private Sub btnMarvel_Click(sender As Object, e As EventArgs) Handles btnMarvel.Click
        SoundHelper.PlayButtonSound()
        selectedSkin = "Marvel"
        SelectedSkinFolder = "images2"
        Settings.SelectedSkinFolder = "images2"
        ButtonEffects.AturAktif(btnMarvel, New List(Of Button) From {btnMarvel, btnPokemon})
    End Sub

    Private Sub btnPokemon_Click(sender As Object, e As EventArgs) Handles btnPokemon.Click
        SoundHelper.PlayButtonSound()
        selectedSkin = "Pokemon"
        SelectedSkinFolder = "images"
        Settings.SelectedSkinFolder = "images"
        ButtonEffects.AturAktif(btnPokemon, New List(Of Button) From {btnMarvel, btnPokemon})
    End Sub


    ' Volume background music dikontrol lewat trackbar
    Private Sub volumetrackbar_Scroll(sender As Object, e As ScrollEventArgs) Handles volumetrackbar.Scroll
        SoundHelper.SetBackgroundVolume(volumetrackbar.Value)
    End Sub
End Class
