Imports System.Windows.Forms

Module ButtonEffects
    Private originalSizes As New Dictionary(Of Button, Size)

    Public Sub ApplyButtonHoverEffects(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)

                If Not originalSizes.ContainsKey(btn) Then
                    originalSizes(btn) = btn.Size
                End If

                AddHandler btn.MouseEnter, AddressOf Button_Hover
                AddHandler btn.MouseLeave, AddressOf Button_Leave
            ElseIf ctrl.HasChildren Then
                ' Rekursif jika kontrol punya anak (misalnya Panel/GroupBox/TabControl)
                ApplyButtonHoverEffects(ctrl)
            End If
        Next
    End Sub

    Private Sub Button_Hover(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If originalSizes.ContainsKey(btn) Then
            btn.Size = New Size(originalSizes(btn).Width + 10, originalSizes(btn).Height + 10)
            btn.Location = New Point(btn.Location.X - 5, btn.Location.Y - 5)
        End If
    End Sub

    Private Sub Button_Leave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If originalSizes.ContainsKey(btn) Then
            btn.Size = originalSizes(btn)
            btn.Location = New Point(btn.Location.X + 5, btn.Location.Y + 5)
        End If
    End Sub
End Module
