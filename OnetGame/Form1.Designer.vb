<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
        strBtn = New Button()
        scrBtn = New Button()
        setBtn = New Button()
        extBtn = New Button()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' strBtn
        ' 
        strBtn.BackColor = Color.Transparent
        strBtn.BackgroundImage = My.Resources.Resources.UI_Collection_TitleNamePlate
        strBtn.BackgroundImageLayout = ImageLayout.Stretch
        strBtn.Cursor = Cursors.Hand
        strBtn.FlatAppearance.BorderSize = 0
        strBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        strBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        strBtn.FlatStyle = FlatStyle.Flat
        strBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        strBtn.ForeColor = SystemColors.Window
        strBtn.Location = New Point(184, 123)
        strBtn.Name = "strBtn"
        strBtn.Size = New Size(300, 180)
        strBtn.TabIndex = 5
        strBtn.Text = "Main"
        strBtn.UseVisualStyleBackColor = False
        ' 
        ' scrBtn
        ' 
        scrBtn.BackColor = Color.Transparent
        scrBtn.BackgroundImage = My.Resources.Resources.UI_Collection_TitleNamePlate
        scrBtn.BackgroundImageLayout = ImageLayout.Stretch
        scrBtn.Cursor = Cursors.Hand
        scrBtn.FlatAppearance.BorderSize = 0
        scrBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        scrBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        scrBtn.FlatStyle = FlatStyle.Flat
        scrBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        scrBtn.ForeColor = Color.White
        scrBtn.Location = New Point(502, 123)
        scrBtn.Name = "scrBtn"
        scrBtn.Size = New Size(300, 180)
        scrBtn.TabIndex = 2
        scrBtn.Text = "Papan Peringkat"
        scrBtn.UseVisualStyleBackColor = False
        ' 
        ' setBtn
        ' 
        setBtn.BackColor = Color.Transparent
        setBtn.BackgroundImage = My.Resources.Resources.UI_Collection_TitleNamePlate
        setBtn.BackgroundImageLayout = ImageLayout.Stretch
        setBtn.Cursor = Cursors.Hand
        setBtn.FlatAppearance.BorderSize = 0
        setBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        setBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        setBtn.FlatStyle = FlatStyle.Flat
        setBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        setBtn.ForeColor = Color.White
        setBtn.Location = New Point(184, 274)
        setBtn.Name = "setBtn"
        setBtn.Size = New Size(300, 180)
        setBtn.TabIndex = 3
        setBtn.Text = "Pengaturan"
        setBtn.UseVisualStyleBackColor = False
        ' 
        ' extBtn
        ' 
        extBtn.BackColor = Color.Transparent
        extBtn.BackgroundImage = My.Resources.Resources.UI_Collection_TitleNamePlate
        extBtn.BackgroundImageLayout = ImageLayout.Stretch
        extBtn.Cursor = Cursors.Hand
        extBtn.FlatAppearance.BorderSize = 0
        extBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        extBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        extBtn.FlatStyle = FlatStyle.Flat
        extBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        extBtn.ForeColor = Color.White
        extBtn.Location = New Point(502, 274)
        extBtn.Name = "extBtn"
        extBtn.Size = New Size(300, 180)
        extBtn.TabIndex = 4
        extBtn.Text = "Keluar"
        extBtn.UseVisualStyleBackColor = False
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(841, 295)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(75, 23)
        AxWindowsMediaPlayer1.TabIndex = 5
        AxWindowsMediaPlayer1.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Play
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(227, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(541, 153)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.DeadpoolOuch
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(12, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(209, 167)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.dfvvca3_553dc247_632d_4918_a0ba_8053d5f91d86
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(774, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(209, 167)
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(253), CByte(246), CByte(236))
        BackgroundImage = My.Resources.Resources.StarsAtmosphere_Portrait3
        ClientSize = New Size(982, 553)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(AxWindowsMediaPlayer1)
        Controls.Add(extBtn)
        Controls.Add(setBtn)
        Controls.Add(scrBtn)
        Controls.Add(strBtn)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "MainMenuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POKEZZLE"
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents strBtn As Button
    Friend WithEvents scrBtn As Button
    Friend WithEvents setBtn As Button
    Friend WithEvents extBtn As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
