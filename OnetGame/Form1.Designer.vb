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
        Label1 = New Label()
        strBtn = New Button()
        scrBtn = New Button()
        setBtn = New Button()
        extBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(226, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(515, 81)
        Label1.TabIndex = 0
        Label1.Text = "MEMORY PUZZLE"
        ' 
        ' strBtn
        ' 
        strBtn.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        strBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        strBtn.ForeColor = Color.WhiteSmoke
        strBtn.Location = New Point(214, 160)
        strBtn.Name = "strBtn"
        strBtn.Size = New Size(234, 88)
        strBtn.TabIndex = 1
        strBtn.Text = "Main"
        strBtn.UseVisualStyleBackColor = False
        ' 
        ' scrBtn
        ' 
        scrBtn.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        scrBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        scrBtn.ForeColor = Color.White
        scrBtn.Location = New Point(520, 160)
        scrBtn.Name = "scrBtn"
        scrBtn.Size = New Size(234, 88)
        scrBtn.TabIndex = 2
        scrBtn.Text = "Papan Peringkat"
        scrBtn.UseVisualStyleBackColor = False
        ' 
        ' setBtn
        ' 
        setBtn.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        setBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        setBtn.ForeColor = Color.White
        setBtn.Location = New Point(214, 274)
        setBtn.Name = "setBtn"
        setBtn.Size = New Size(234, 88)
        setBtn.TabIndex = 3
        setBtn.Text = "Pengaturan"
        setBtn.UseVisualStyleBackColor = False
        ' 
        ' extBtn
        ' 
        extBtn.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        extBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        extBtn.ForeColor = Color.White
        extBtn.Location = New Point(520, 274)
        extBtn.Name = "extBtn"
        extBtn.Size = New Size(234, 88)
        extBtn.TabIndex = 4
        extBtn.Text = "Keluar"
        extBtn.UseVisualStyleBackColor = False
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(253), CByte(246), CByte(236))
        ClientSize = New Size(982, 553)
        Controls.Add(extBtn)
        Controls.Add(setBtn)
        Controls.Add(scrBtn)
        Controls.Add(strBtn)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MainMenuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ONET"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents strBtn As Button
    Friend WithEvents scrBtn As Button
    Friend WithEvents setBtn As Button
    Friend WithEvents extBtn As Button

End Class
