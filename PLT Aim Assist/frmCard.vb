Public Class frmCard

    Private Sub frmCard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub frmCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.sfx_PopupBlocked, AudioPlayMode.Background)
    End Sub
End Class