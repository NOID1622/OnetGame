Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Public Class TransparentDataGridView
    Inherits DataGridView

    Private _backgroundpic As Image
    <Browsable(True)>
    Public Overrides Property backgroundImage As Image
        Get
            Return _backgroundpic

        End Get
        Set(value As Image)
            _backgroundpic = value

        End Set
    End Property


    Public Sub setcellTransparent()
        Me.EnableHeadersVisualStyles = False
        Me.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed
        Me.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.RowHeadersDefaultCellStyle.BackColor = Color.Transparent
        Me.RowHeadersDefaultCellStyle.ForeColor = Color.White
        Me.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For Each col As DataGridViewColumn In Me.Columns
            col.DefaultCellStyle.BackColor = Color.Transparent
            col.DefaultCellStyle.ForeColor = Color.White
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        ' Nonaktifkan semua interaksi pengguna
        Me.ReadOnly = True
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.AllowUserToResizeRows = False
        Me.AllowUserToResizeColumns = False
        Me.AllowUserToOrderColumns = False
        Me.RowHeadersVisible = False
        Me.SelectionMode = DataGridViewSelectionMode.CellSelect
        Me.MultiSelect = False
        Me.Enabled = False
    End Sub


    Protected Overrides Sub PaintBackground(graphics As Graphics, clipBounds As Rectangle, gridBounds As Rectangle)
        MyBase.PaintBackground(graphics, clipBounds, gridBounds)

        If (Me.backgroundImage IsNot Nothing) Then
            graphics.FillRectangle(Brushes.Black, gridBounds)
            graphics.DrawImage(Me.backgroundImage, gridBounds)
        End If
    End Sub

End Class