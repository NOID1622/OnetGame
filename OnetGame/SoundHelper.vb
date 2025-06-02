Imports AxWMPLib
Imports System.Windows.Forms

Module SoundHelper
    Private player As AxWindowsMediaPlayer       ' Untuk sound efek tombol
    Private musicPlayer As AxWindowsMediaPlayer  ' Untuk backsound
    Private backsoundPath As String = IO.Path.Combine(Application.StartupPath, "backsound.mp3")

    ' Inisialisasi kedua player saat form dibuka (cukup sekali per form utama)
    Public Sub InitPlayer(form As Form)
        If player Is Nothing Then
            player = New AxWindowsMediaPlayer()
            player.CreateControl()
            player.Visible = False
            form.Controls.Add(player)
        End If

        If musicPlayer Is Nothing Then
            musicPlayer = New AxWindowsMediaPlayer()
            musicPlayer.CreateControl()
            musicPlayer.Visible = False
            form.Controls.Add(musicPlayer)
        End If
    End Sub

    ' Fungsi mainkan suara klik tombol
    Public Sub PlayButtonSound()
        Dim soundPath As String = IO.Path.Combine(Application.StartupPath, "sound\buttonclick.mp3")
        If IO.File.Exists(soundPath) AndAlso player IsNot Nothing Then
            player.URL = soundPath
            player.Ctlcontrols.play()
        End If
    End Sub

    Public Sub PlayButtonSound2()
        Dim soundPath As String = IO.Path.Combine(Application.StartupPath, "sound\uibutton.mp3")
        If IO.File.Exists(soundPath) AndAlso player IsNot Nothing Then
            player.URL = soundPath
            player.Ctlcontrols.play()
        End If
    End Sub

    ' Fungsi memutar musik latar (backsound)
    Public Sub PlayBackgroundMusic()
        If IO.File.Exists(backsoundPath) AndAlso musicPlayer IsNot Nothing Then
            musicPlayer.URL = backsoundPath
            musicPlayer.settings.setMode("loop", True)
            musicPlayer.settings.volume = 100
            musicPlayer.Ctlcontrols.play()
        Else
            MessageBox.Show("File backsound tidak ditemukan di: " & backsoundPath)
        End If
    End Sub

    Public Sub StopBackgroundMusic()
        If musicPlayer IsNot Nothing Then
            musicPlayer.Ctlcontrols.stop()
        End If
    End Sub

    Public Sub SetBackgroundVolume(volume As Integer)
        If musicPlayer IsNot Nothing Then
            musicPlayer.settings.volume = Math.Max(0, Math.Min(100, volume))
        End If
    End Sub
End Module
