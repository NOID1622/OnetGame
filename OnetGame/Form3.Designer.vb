<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        btnJeda = New Button()
        btnBantuan = New Button()
        btnMenyerah = New Button()
        lblTimer = New Label()
        pnlGame = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        lblLangkah = New Label()
        pnlGame.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnJeda
        ' 
        btnJeda.BackColor = Color.Transparent
        btnJeda.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnJeda.BackgroundImageLayout = ImageLayout.Stretch
        btnJeda.FlatAppearance.BorderSize = 0
        btnJeda.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnJeda.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnJeda.FlatStyle = FlatStyle.Flat
        btnJeda.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnJeda.ForeColor = Color.White
        btnJeda.Location = New Point(14, 140)
        btnJeda.Name = "btnJeda"
        btnJeda.Size = New Size(136, 43)
        btnJeda.TabIndex = 0
        btnJeda.Text = "Jeda"
        btnJeda.UseVisualStyleBackColor = False
        ' 
        ' btnBantuan
        ' 
        btnBantuan.BackColor = Color.Transparent
        btnBantuan.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnBantuan.BackgroundImageLayout = ImageLayout.Stretch
        btnBantuan.FlatAppearance.BorderSize = 0
        btnBantuan.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBantuan.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBantuan.FlatStyle = FlatStyle.Flat
        btnBantuan.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBantuan.ForeColor = Color.White
        btnBantuan.Location = New Point(14, 189)
        btnBantuan.Name = "btnBantuan"
        btnBantuan.Size = New Size(136, 43)
        btnBantuan.TabIndex = 1
        btnBantuan.Text = "Bantuan"
        btnBantuan.UseVisualStyleBackColor = False
        ' 
        ' btnMenyerah
        ' 
        btnMenyerah.BackColor = Color.Transparent
        btnMenyerah.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnMenyerah.BackgroundImageLayout = ImageLayout.Stretch
        btnMenyerah.FlatAppearance.BorderSize = 0
        btnMenyerah.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnMenyerah.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnMenyerah.FlatStyle = FlatStyle.Flat
        btnMenyerah.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMenyerah.ForeColor = Color.White
        btnMenyerah.Location = New Point(14, 238)
        btnMenyerah.Name = "btnMenyerah"
        btnMenyerah.Size = New Size(136, 43)
        btnMenyerah.TabIndex = 2
        btnMenyerah.Text = "Menyerah"
        btnMenyerah.UseVisualStyleBackColor = False
        ' 
        ' lblTimer
        ' 
        lblTimer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTimer.AutoSize = True
        lblTimer.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimer.Location = New Point(14, 28)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(158, 46)
        lblTimer.TabIndex = 4
        lblTimer.Text = "valTimer"
        lblTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlGame
        ' 
        pnlGame.BackColor = Color.Transparent
        pnlGame.BorderStyle = BorderStyle.FixedSingle
        pnlGame.Controls.Add(TableLayoutPanel1)
        pnlGame.Location = New Point(12, 12)
        pnlGame.Name = "pnlGame"
        pnlGame.Size = New Size(776, 529)
        pnlGame.TabIndex = 3
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 61.1650467F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.8349571F))
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.ForeColor = Color.Transparent
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(774, 527)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblLangkah)
        Panel1.Controls.Add(lblTimer)
        Panel1.Controls.Add(btnJeda)
        Panel1.Controls.Add(btnMenyerah)
        Panel1.Controls.Add(btnBantuan)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(794, 13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(176, 527)
        Panel1.TabIndex = 5
        ' 
        ' lblLangkah
        ' 
        lblLangkah.AutoSize = True
        lblLangkah.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLangkah.ForeColor = Color.Yellow
        lblLangkah.Location = New Point(32, 94)
        lblLangkah.Name = "lblLangkah"
        lblLangkah.Size = New Size(88, 23)
        lblLangkah.TabIndex = 5
        lblLangkah.Text = "Langkah :"
        ' 
        ' GameForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(253), CByte(246), CByte(236))
        BackgroundImage = My.Resources.Resources.StarsAtmosphere_Portrait3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(982, 553)
        Controls.Add(Panel1)
        Controls.Add(pnlGame)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "GameForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POKEZZLE"
        pnlGame.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnJeda As Button
    Friend WithEvents btnBantuan As Button
    Friend WithEvents btnMenyerah As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents pnlGame As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLangkah As Label
End Class
