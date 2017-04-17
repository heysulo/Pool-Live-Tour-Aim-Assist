Public Class frmToolPad

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Dim tx As Integer = (frmAssister.LineShape1.X2 - frmAssister.LineShape1.X1)
        Dim ty As Integer = (frmAssister.LineShape1.Y2 - frmAssister.LineShape1.Y1)
        Dim Angle As String
        Dim Tangon As String
        Tangon = ty / tx
        Angle = Math.Atan(Tangon)
        frmAssister.LineShape2.X2 = frmAssister.LineShape1.X2 - NumericUpDown1.Value * Math.Sin(Angle)
        frmAssister.LineShape2.Y2 = frmAssister.LineShape1.Y2 + NumericUpDown1.Value * Math.Cos(Angle)
        frmAssister.LineShape2.X1 = frmAssister.LineShape1.X1 - NumericUpDown1.Value * Math.Sin(Angle)
        frmAssister.LineShape2.Y1 = frmAssister.LineShape1.Y1 + NumericUpDown1.Value * Math.Cos(Angle)
        Me.Text = Angle
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim ColorPicker As ColorDialog = New ColorDialog
        If ColorPicker.ShowDialog = vbOK Then
            PictureBox1.BackColor = ColorPicker.Color
            frmAssister.LineShape1.BorderColor = ColorPicker.Color
            frmAssister.LineShape2.BorderColor = ColorPicker.Color
        End If
    End Sub

  

    Private Sub frmToolPad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim X As Integer
        Dim Y As Integer
        X = My.Computer.Screen.WorkingArea.Width / 2
        Y = Me.Width / 2
        Me.Left = X - Y
        Me.Top = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        frmAssister.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim diag As Form = New frmLoadValues
        diag.ShowDialog()
        diag.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Are you sure that you wanna Exit PLT AIm Assist ?", vbYesNoCancel + vbQuestion, "Exit PLT Aim Assist") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Show()
        frmAssister.Close()
        Me.Close()
    End Sub
End Class