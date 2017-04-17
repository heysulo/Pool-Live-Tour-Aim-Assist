Public Class frmDimmer

    Private Sub frmDimmer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmCard.ShowDialog()
        Me.Close()
    End Sub
End Class