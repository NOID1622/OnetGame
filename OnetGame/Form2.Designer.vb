<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label1 = New Label()
        btnMudah = New Button()
        btnSedang = New Button()
        btnSulit = New Button()
        Label2 = New Label()
        btnKlasik = New Button()
        btnWaktu = New Button()
        btnTantangan = New Button()
        btnStart = New Button()
        btnKembali = New Button()
        Panel1 = New Panel()
        txtNama = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(301, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 54)
        Label1.TabIndex = 0
        Label1.Text = "Tingkat Kesulitan"
        ' 
        ' btnMudah
        ' 
        btnMudah.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
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
        btnSedang.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
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
        btnSulit.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnSulit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSulit.ForeColor = Color.White
        btnSulit.Location = New Point(630, 110)
        btnSulit.Name = "btnSulit"
        btnSulit.Size = New Size(230, 80)
        btnSulit.TabIndex = 3
        btnSulit.Text = "Sulit"
        btnSulit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(289, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(345, 54)
        Label2.TabIndex = 4
        Label2.Text = "Mode Permainan"
        ' 
        ' btnKlasik
        ' 
        btnKlasik.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnKlasik.Location = New Point(89, 67)
        btnKlasik.Name = "btnKlasik"
        btnKlasik.Size = New Size(230, 80)
        btnKlasik.TabIndex = 5
        btnKlasik.Text = "Klasik"
        btnKlasik.UseVisualStyleBackColor = False
        ' 
        ' btnWaktu
        ' 
        btnWaktu.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        btnWaktu.Location = New Point(355, 67)
        btnWaktu.Name = "btnWaktu"
        btnWaktu.Size = New Size(230, 80)
        btnWaktu.TabIndex = 6
        btnWaktu.Text = "Waktu"
        btnWaktu.UseVisualStyleBackColor = False
        ' 
        ' btnTantangan
        ' 
        btnTantangan.BackColor = Color.FromArgb(CByte(142), CByte(68), CByte(173))
        btnTantangan.Location = New Point(618, 67)
        btnTantangan.Name = "btnTantangan"
        btnTantangan.Size = New Size(230, 80)
        btnTantangan.TabIndex = 7
        btnTantangan.Text = "Tantangan"
        btnTantangan.UseVisualStyleBackColor = False
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        btnStart.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(336, 448)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(293, 57)
        btnStart.TabIndex = 8
        btnStart.Text = "Mulai"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(850, 511)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(120, 30)
        btnKembali.TabIndex = 9
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnKlasik)
        Panel1.Controls.Add(btnWaktu)
        Panel1.Controls.Add(btnTantangan)
        Panel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(12, 220)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(958, 222)
        Panel1.TabIndex = 10
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(162, 459)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(152, 27)
        txtNama.TabIndex = 11
        txtNama.Text = "player1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(100, 462)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 12
        Label3.Text = "Nama :"
        ' 
        ' GameModeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(253), CByte(246), CByte(236))
        ClientSize = New Size(982, 553)
        Controls.Add(Label3)
        Controls.Add(txtNama)
        Controls.Add(Panel1)
        Controls.Add(btnKembali)
        Controls.Add(btnStart)
        Controls.Add(btnSulit)
        Controls.Add(btnSedang)
        Controls.Add(btnMudah)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "GameModeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ONET"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMudah As Button
    Friend WithEvents btnSedang As Button
    Friend WithEvents btnSulit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKlasik As Button
    Friend WithEvents btnWaktu As Button
    Friend WithEvents btnTantangan As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
End Class
