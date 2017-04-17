Public Class frmNewValue
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("The Profile Name cannot be blank.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextBox1.Text.Contains(",") = True Or TextBox1.Text.Contains(":") = True Then
            MsgBox("The Characters ',' and ':' must not include in the Profile Name", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        frmSettings.Namez = TextBox1.Text
        frmSettings.Amonut = Val(TextBox2.Text)
        frmSettings.Valcan = False
        Me.Close()
    End Sub
End Class