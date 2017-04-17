Public Class frmLoadValues

    Private Sub frmLoadValues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim count As Integer = 0
        ListView1.Items.Clear()
        For Each itm As String In Form1.ProfileNameList.Items
            With ListView1.Items.Add(itm, 0)
                .SubItems.Add(Form1.ProfileValueList.Items(count))
            End With
            count = count + 1
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count > 0 Then
            frmToolPad.NumericUpDown1.Value = Val(Form1.ProfileValueList.Items.Item(ListView1.SelectedItems(0).Index))
            Me.Close()
        Else
            MsgBox("No Items Selected", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            frmToolPad.NumericUpDown1.Value = Val(Form1.ProfileValueList.Items.Item(ListView1.SelectedItems(0).Index))
            Me.Close()
        Else
            MsgBox("No Items Selected", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        End If
    End Sub

    Private Sub ListView1_ItemMouseHover(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemMouseHoverEventArgs) Handles ListView1.ItemMouseHover
       
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class