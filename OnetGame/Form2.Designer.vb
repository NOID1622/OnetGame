﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameModeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameModeForm))
        Label1 = New Label()
        btnMudah = New Button()
        btnSedang = New Button()
        btnSulit = New Button()
        btnStart = New Button()
        btnKembali = New Button()
        btnTantangan = New Button()
        btnWaktu = New Button()
        btnKlasik = New Button()
        Label2 = New Label()
        txtNama = New TextBox()
        peringatanNama = New Label()
        peringatanmode = New Label()
        peringatantingkat = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(394, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 28)
        Label1.TabIndex = 0
        Label1.Text = "Tingkat Kesulitan"
        ' 
        ' btnMudah
        ' 
        btnMudah.BackColor = Color.Transparent
        btnMudah.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnMudah.BackgroundImageLayout = ImageLayout.Stretch
        btnMudah.Cursor = Cursors.Hand
        btnMudah.FlatAppearance.BorderSize = 0
        btnMudah.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnMudah.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnMudah.FlatStyle = FlatStyle.Flat
        btnMudah.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMudah.ForeColor = Color.White
        btnMudah.Location = New Point(101, 110)
        btnMudah.Name = "btnMudah"
        btnMudah.Size = New Size(230, 80)
        btnMudah.TabIndex = 1
        btnMudah.Text = "Mudah"
        btnMudah.UseVisualStyleBackColor = False
        ' 
        ' btnSedang
        ' 
        btnSedang.BackColor = Color.Transparent
        btnSedang.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnSedang.BackgroundImageLayout = ImageLayout.Stretch
        btnSedang.Cursor = Cursors.Hand
        btnSedang.FlatAppearance.BorderSize = 0
        btnSedang.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSedang.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSedang.FlatStyle = FlatStyle.Flat
        btnSedang.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSedang.ForeColor = Color.White
        btnSedang.Location = New Point(367, 110)
        btnSedang.Name = "btnSedang"
        btnSedang.Size = New Size(230, 80)
        btnSedang.TabIndex = 2
        btnSedang.Text = "Sedang"
        btnSedang.UseVisualStyleBackColor = False
        ' 
        ' btnSulit
        ' 
        btnSulit.BackColor = Color.Transparent
        btnSulit.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnSulit.BackgroundImageLayout = ImageLayout.Stretch
        btnSulit.Cursor = Cursors.Hand
        btnSulit.FlatAppearance.BorderSize = 0
        btnSulit.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSulit.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSulit.FlatStyle = FlatStyle.Flat
        btnSulit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSulit.ForeColor = Color.White
        btnSulit.Location = New Point(630, 110)
        btnSulit.Name = "btnSulit"
        btnSulit.Size = New Size(230, 80)
        btnSulit.TabIndex = 3
        btnSulit.Text = "Sulit"
        btnSulit.UseVisualStyleBackColor = False
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.Transparent
        btnStart.BackgroundImage = My.Resources.Resources.ConquestTower_Banner_Purple
        btnStart.BackgroundImageLayout = ImageLayout.Stretch
        btnStart.Cursor = Cursors.Hand
        btnStart.FlatAppearance.BorderSize = 0
        btnStart.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnStart.FlatStyle = FlatStyle.Flat
        btnStart.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(603, 387)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(347, 83)
        btnStart.TabIndex = 8
        btnStart.Text = "Mulai"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.Transparent
        btnKembali.BackgroundImage = My.Resources.Resources.Conquest_Nameplate_Red
        btnKembali.BackgroundImageLayout = ImageLayout.Stretch
        btnKembali.Cursor = Cursors.Hand
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnKembali.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(778, 476)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(192, 65)
        btnKembali.TabIndex = 9
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnTantangan
        ' 
        btnTantangan.BackColor = Color.Transparent
        btnTantangan.BackgroundImage = My.Resources.Resources.UI_Collection_TitleNamePlate
        btnTantangan.BackgroundImageLayout = ImageLayout.Stretch
        btnTantangan.Cursor = Cursors.Hand
        btnTantangan.FlatAppearance.BorderSize = 0
        btnTantangan.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnTantangan.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnTantangan.FlatStyle = FlatStyle.Flat
        btnTantangan.Location = New Point(367, 275)
        btnTantangan.Name = "btnTantangan"
        btnTantangan.Size = New Size(230, 80)
        btnTantangan.TabIndex = 7
        btnTantangan.Text = "Tantangan"
        btnTantangan.UseVisualStyleBackColor = False
        ' 
        ' btnWaktu
        ' 
        btnWaktu.BackColor = Color.Transparent
        btnWaktu.BackgroundImage = My.Resources.Resources.UI_Collection_TitleNamePlate
        btnWaktu.BackgroundImageLayout = ImageLayout.Stretch
        btnWaktu.Cursor = Cursors.Hand
        btnWaktu.FlatAppearance.BorderSize = 0
        btnWaktu.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnWaktu.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnWaktu.FlatStyle = FlatStyle.Flat
        btnWaktu.ForeColor = Color.WhiteSmoke
        btnWaktu.Location = New Point(101, 275)
        btnWaktu.Name = "btnWaktu"
        btnWaktu.Size = New Size(230, 80)
        btnWaktu.TabIndex = 6
        btnWaktu.Text = "Waktu"
        btnWaktu.UseVisualStyleBackColor = False
        ' 
        ' btnKlasik
        ' 
        btnKlasik.BackColor = Color.Transparent
        btnKlasik.BackgroundImage = My.Resources.Resources.UI_Collection_TitleNamePlate
        btnKlasik.BackgroundImageLayout = ImageLayout.Stretch
        btnKlasik.Cursor = Cursors.Hand
        btnKlasik.FlatAppearance.BorderSize = 0
        btnKlasik.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnKlasik.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnKlasik.FlatStyle = FlatStyle.Flat
        btnKlasik.Location = New Point(630, 275)
        btnKlasik.Name = "btnKlasik"
        btnKlasik.Size = New Size(230, 80)
        btnKlasik.TabIndex = 5
        btnKlasik.Text = "Klasik"
        btnKlasik.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(314, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(338, 46)
        Label2.TabIndex = 10
        Label2.Text = "MODE PERMAINAN"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.DarkSlateBlue
        txtNama.BorderStyle = BorderStyle.None
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(131, 408)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Tolong masukkan nama anda"
        txtNama.Size = New Size(466, 20)
        txtNama.TabIndex = 11
        ' 
        ' peringatanNama
        ' 
        peringatanNama.AutoSize = True
        peringatanNama.BackColor = Color.Transparent
        peringatanNama.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        peringatanNama.ForeColor = Color.Yellow
        peringatanNama.Location = New Point(131, 431)
        peringatanNama.Name = "peringatanNama"
        peringatanNama.Size = New Size(187, 20)
        peringatanNama.TabIndex = 12
        peringatanNama.Text = "MASUKKAN NAMA ANDA"
        peringatanNama.Visible = False
        ' 
        ' peringatanmode
        ' 
        peringatanmode.AutoSize = True
        peringatanmode.BackColor = Color.Transparent
        peringatanmode.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        peringatanmode.ForeColor = Color.Yellow
        peringatanmode.Location = New Point(394, 272)
        peringatanmode.Name = "peringatanmode"
        peringatanmode.Size = New Size(163, 17)
        peringatanmode.TabIndex = 13
        peringatanmode.Text = "PILIH MODE PERMAINAN"
        peringatanmode.Visible = False
        ' 
        ' peringatantingkat
        ' 
        peringatantingkat.AutoSize = True
        peringatantingkat.BackColor = Color.Transparent
        peringatantingkat.Font = New Font("Segoe UI", 8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        peringatantingkat.ForeColor = Color.Yellow
        peringatantingkat.Location = New Point(386, 83)
        peringatantingkat.Name = "peringatantingkat"
        peringatantingkat.Size = New Size(186, 19)
        peringatantingkat.TabIndex = 14
        peringatantingkat.Text = "PILIH TINGKAT KESULITAN"
        peringatantingkat.Visible = False
        ' 
        ' GameModeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(253), CByte(246), CByte(236))
        BackgroundImage = My.Resources.Resources.StarsAtmosphere_Portrait3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(982, 553)
        Controls.Add(peringatantingkat)
        Controls.Add(peringatanmode)
        Controls.Add(peringatanNama)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(btnKlasik)
        Controls.Add(btnKembali)
        Controls.Add(btnWaktu)
        Controls.Add(btnStart)
        Controls.Add(btnTantangan)
        Controls.Add(btnSulit)
        Controls.Add(btnSedang)
        Controls.Add(btnMudah)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "GameModeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POKEZZLE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMudah As Button
    Friend WithEvents btnSedang As Button
    Friend WithEvents btnSulit As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnTantangan As Button
    Friend WithEvents btnWaktu As Button
    Friend WithEvents btnKlasik As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents peringatanNama As Label
    Friend WithEvents peringatanmode As Label
    Friend WithEvents peringatantingkat As Label
End Class
