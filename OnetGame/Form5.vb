Public Class SettingForm

    Private selectedSkin As String = ""
    Public Property SelectedSkinFolder As String = "images"
    Public Property mainMenuRef As Form

    Private kembaliKeMenu As Boolean = False

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyButtonHoverEffects(Me)
        SoundHelper.InitPlayer(Me)

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        ButtonEffects.AturAktif(Nothing, New List(Of Button) From {btnMarvel, btnPokemon})
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        SoundHelper.PlayButtonSound()

        kembaliKeMenu = True

        If mainMenuRef IsNot Nothing Then
            mainMenuRef.Show()
        End If

        Me.Close()
    End Sub

    Private Sub SettingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If kembaliKeMenu Then
            mainMenuRef?.Show()
        Else
            Application.Exit()
        End If
    End Sub


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


    Private Sub volumetrackbar_Scroll(sender As Object, e As ScrollEventArgs) Handles volumetrackbar.Scroll
        SoundHelper.SetGlobalVolume(volumetrackbar.Value)
    End Sub
End Class
