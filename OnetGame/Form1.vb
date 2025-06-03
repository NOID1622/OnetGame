Imports System.Media

Public Class MainMenuForm

    Public Property SelectedSkinFolder As String = "images" ' Default folder skin

    Private isExiting As Boolean = False
    Dim dbManager As New dbManager()

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mainMenuRef = Me
        SoundHelper.InitPlayer(Me)
        ApplyButtonHoverEffects(Me)
        SoundHelper.PlayBackgroundMusic()
        dbManager.InitDatabase()
        'dbManager.TesInsert()

        Me.MaximizeBox = False

    End Sub

    ' === Buka GameModeForm ===
    Private Sub strBtn_Click(sender As Object, e As EventArgs) Handles strBtn.Click
        SoundHelper.PlayButtonSound2()

        Dim gmForm As New GameModeForm()
        gmForm.mainMenuRef = Me
        gmForm.SelectedSkinFolder = Me.SelectedSkinFolder
        gmForm.Show()
        Me.Hide()
    End Sub

    ' === Buka ScoreForm ===
    Private Sub scrBtn_Click(sender As Object, e As EventArgs) Handles scrBtn.Click
        SoundHelper.PlayButtonSound2()
        Me.Hide()
        Dim scoreForm As New ScoreForm()
        scoreForm.ShowDialog()
        Me.Show()
    End Sub

    ' === Buka SettingForm ===
    Private Sub setBtn_Click(sender As Object, e As EventArgs) Handles setBtn.Click
        SoundHelper.PlayButtonSound2()
        Me.Hide()

        Dim settForm As New SettingForm()
        settForm.SelectedSkinFolder = Me.SelectedSkinFolder

        settForm.ShowDialog()

        ' Ambil kembali folder skin dari SettingForm setelah dialog ditutup
        Me.SelectedSkinFolder = settForm.SelectedSkinFolder

        Me.Show()
    End Sub

    ' === Tutup aplikasi saat klik tombol keluar ===
    Private Sub extBtn_Click(sender As Object, e As EventArgs) Handles extBtn.Click
        Application.Exit()
    End Sub


End Class
