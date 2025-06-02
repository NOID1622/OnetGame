<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Label1 = New Label()
        btnMarvel = New Button()
        btnPokemon = New Button()
        Label2 = New Label()
        btnKembali = New Button()
        volumetrackbar = New Guna.UI2.WinForms.Guna2TrackBar()
        btnJoker = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(371, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 46)
        Label1.TabIndex = 2
        Label1.Text = "Tema Kartu"
        ' 
        ' btnMarvel
        ' 
        btnMarvel.BackColor = Color.Transparent
        btnMarvel.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnMarvel.BackgroundImageLayout = ImageLayout.Stretch
        btnMarvel.FlatAppearance.BorderSize = 0
        btnMarvel.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnMarvel.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnMarvel.FlatStyle = FlatStyle.Flat
        btnMarvel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMarvel.ForeColor = Color.White
        btnMarvel.Location = New Point(66, 172)
        btnMarvel.Name = "btnMarvel"
        btnMarvel.Size = New Size(230, 80)
        btnMarvel.TabIndex = 3
        btnMarvel.Text = "MARVEL"
        btnMarvel.UseVisualStyleBackColor = False
        ' 
        ' btnPokemon
        ' 
        btnPokemon.BackColor = Color.Transparent
        btnPokemon.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnPokemon.BackgroundImageLayout = ImageLayout.Stretch
        btnPokemon.FlatAppearance.BorderSize = 0
        btnPokemon.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnPokemon.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnPokemon.FlatStyle = FlatStyle.Flat
        btnPokemon.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPokemon.ForeColor = Color.White
        btnPokemon.Location = New Point(371, 172)
        btnPokemon.Name = "btnPokemon"
        btnPokemon.Size = New Size(230, 80)
        btnPokemon.TabIndex = 4
        btnPokemon.Text = "POKEMON"
        btnPokemon.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(396, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 46)
        Label2.TabIndex = 5
        Label2.Text = "Volume"
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.Transparent
        btnKembali.BackgroundImage = My.Resources.Resources.Conquest_Nameplate_Red
        btnKembali.BackgroundImageLayout = ImageLayout.Stretch
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnKembali.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.Snow
        btnKembali.Location = New Point(753, 476)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(192, 65)
        btnKembali.TabIndex = 8
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' volumetrackbar
        ' 
        volumetrackbar.BackColor = Color.Transparent
        volumetrackbar.Location = New Point(288, 380)
        volumetrackbar.Name = "volumetrackbar"
        volumetrackbar.Size = New Size(375, 29)
        volumetrackbar.TabIndex = 9
        volumetrackbar.ThumbColor = Color.SlateBlue
        ' 
        ' btnJoker
        ' 
        btnJoker.BackColor = Color.Transparent
        btnJoker.BackgroundImage = My.Resources.Resources.glasspanel_orange_PMV
        btnJoker.BackgroundImageLayout = ImageLayout.Stretch
        btnJoker.FlatAppearance.BorderSize = 0
        btnJoker.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnJoker.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnJoker.FlatStyle = FlatStyle.Flat
        btnJoker.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnJoker.ForeColor = Color.White
        btnJoker.Location = New Point(690, 172)
        btnJoker.Name = "btnJoker"
        btnJoker.Size = New Size(230, 80)
        btnJoker.TabIndex = 10
        btnJoker.Text = "JOKER"
        btnJoker.UseVisualStyleBackColor = False
        ' 
        ' SettingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(253), CByte(246), CByte(236))
        BackgroundImage = My.Resources.Resources.StarsAtmosphere_Portrait3
        ClientSize = New Size(982, 553)
        Controls.Add(btnJoker)
        Controls.Add(volumetrackbar)
        Controls.Add(btnKembali)
        Controls.Add(Label2)
        Controls.Add(btnPokemon)
        Controls.Add(btnMarvel)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SettingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pengaturan"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMarvel As Button
    Friend WithEvents btnPokemon As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents volumetrackbar As Guna.UI2.WinForms.Guna2TrackBar
    Friend WithEvents btnJoker As Button
End Class
