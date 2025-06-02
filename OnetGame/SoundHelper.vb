Imports AxWMPLib
Imports System.Windows.Forms

Module SoundHelper
    Private player As AxWindowsMediaPlayer         ' Untuk sound efek tombol
    Private musicPlayer As AxWindowsMediaPlayer    ' Untuk backsound
    Private currentMusicPath As String = ""        ' Path musik yang sedang diputar
    Private currentMusicName As String = ""        ' Nama musik: "main", "timer", dll

    ' Path default
    Private backsoundMain As String = IO.Path.Combine(Application.StartupPath, "sound\backsound.mp3")
    Private backsoundTimer As String = IO.Path.Combine(Application.StartupPath, "sound\timemode.mp3")

    ' === Inisialisasi player di form utama ===
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

    ' === Sound efek tombol ===
    Public Sub PlayButtonSound()
        PlaySoundEffect("sound\buttonclick.mp3")
    End Sub

    Public Sub PlayButtonSound2()
        PlaySoundEffect("sound\uibutton.mp3")
    End Sub

    Public Sub PlayButtonSoundtimer()
        PlaySoundEffect("sound\timemode.mp3")
    End Sub

    Public Sub PlayButtonSoundtantang()
        PlaySoundEffect("sound\tantangan.mp3")
    End Sub

    Private Sub PlaySoundEffect(relativePath As String)
        Dim fullPath As String = IO.Path.Combine(Application.StartupPath, relativePath)
        If IO.File.Exists(fullPath) AndAlso player IsNot Nothing Then
            player.URL = fullPath
            player.Ctlcontrols.play()
        End If
    End Sub

    ' === BACKSOUND ===
    Public Sub PlayBackgroundMusic()
        PlayMusic(backsoundMain, "main")
    End Sub

    Public Sub PlayTimerModeMusic()
        PlayMusic(backsoundTimer, "timer")
    End Sub

    Private Sub PlayMusic(musicPath As String, musicName As String)
        If IO.File.Exists(musicPath) AndAlso musicPlayer IsNot Nothing Then
            If currentMusicName <> musicName Then
                musicPlayer.Ctlcontrols.stop()
                musicPlayer.URL = musicPath
                musicPlayer.settings.setMode("loop", True)
                musicPlayer.settings.volume = 100
                musicPlayer.Ctlcontrols.play()
                currentMusicPath = musicPath
                currentMusicName = musicName
            End If
        Else
            MessageBox.Show("File musik tidak ditemukan: " & musicPath)
        End If
    End Sub

    Public Sub StopBackgroundMusic()
        If musicPlayer IsNot Nothing Then
            musicPlayer.Ctlcontrols.stop()
            currentMusicName = ""
            currentMusicPath = ""
        End If
    End Sub
    ' === Atur volume untuk semua audio: musik dan efek ===
    Public Sub SetGlobalVolume(volume As Integer)
        volume = Math.Max(0, Math.Min(100, volume)) ' Pastikan dalam rentang 0-100

        If musicPlayer IsNot Nothing Then
            musicPlayer.settings.volume = volume
        End If

        If player IsNot Nothing Then
            player.settings.volume = volume
        End If
    End Sub

    ' Hanya mengatur volume musik latar
    Public Sub SetBackgroundVolume(volume As Integer)
        volume = Math.Max(0, Math.Min(100, volume))
        If musicPlayer IsNot Nothing Then
            musicPlayer.settings.volume = volume
        End If
    End Sub

End Module
