
Public Class GameModeForm

    Public selectedDifficulty As String = ""
    Public selectedMode As String = ""


    Private Sub AturAktif(btnAktif As Button, grup As List(Of Button))
        For Each btn In grup
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.ForeColor = Color.Gray
            btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular)
        Next

        btnAktif.FlatStyle = FlatStyle.Flat
        btnAktif.FlatAppearance.BorderSize = 0
        btnAktif.FlatAppearance.BorderColor = Color.White
        btnAktif.ForeColor = Color.White
        btnAktif.Font = New Font(btnAktif.Font.FontFamily, btnAktif.Font.Size, FontStyle.Bold)
    End Sub



    Private Sub btnMudah_Click(sender As Object, e As EventArgs) Handles btnMudah.Click
        selectedDifficulty = "Mudah"
        AturAktif(btnMudah, New List(Of Button) From {btnMudah, btnSedang, btnSulit})
    End Sub

    Private Sub btnSedang_Click(sender As Object, e As EventArgs) Handles btnSedang.Click
        selectedDifficulty = "Sedang"
        AturAktif(btnSedang, New List(Of Button) From {btnMudah, btnSedang, btnSulit})
    End Sub

    Private Sub btnSulit_Click(sender As Object, e As EventArgs) Handles btnSulit.Click
        selectedDifficulty = "Sulit"
        AturAktif(btnSulit, New List(Of Button) From {btnMudah, btnSedang, btnSulit})
    End Sub

    Private Sub btnKlasik_Click(sender As Object, e As EventArgs) Handles btnKlasik.Click
        selectedMode = "Klasik"
        AturAktif(btnKlasik, New List(Of Button) From {btnKlasik, btnWaktu, btnTantangan})
    End Sub

    Private Sub btnWaktu_Click(sender As Object, e As EventArgs) Handles btnWaktu.Click
        selectedMode = "Waktu"
        AturAktif(btnWaktu, New List(Of Button) From {btnKlasik, btnWaktu, btnTantangan})
    End Sub

    Private Sub btnTantangan_Click(sender As Object, e As EventArgs) Handles btnTantangan.Click
        selectedMode = "Petualang"
        AturAktif(btnTantangan, New List(Of Button) From {btnKlasik, btnWaktu, btnTantangan})
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim mainMenu As New MainMenuForm()
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub GameModeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyButtonHoverEffects(Me)
    End Sub
End Class