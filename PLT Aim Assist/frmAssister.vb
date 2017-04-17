Public Class frmAssister
    Dim ml As PointF

    Private Sub frmAssister_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmInfinity.Close()
    End Sub
    Private Sub frmAssister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'label movement
        If My.Computer.Keyboard.CapsLock = False Then
            Dim lx As Integer
            Dim ly As Integer
            Dim lp As Point
            lx = ((My.Computer.Screen.WorkingArea.Width - Label1.Width) / 2)
            ly = ((My.Computer.Screen.WorkingArea.Height - Label1.Height) / 2)
            lp.X = lx
            lp.Y = ly
            Label1.Location = lp
        End If
        Dim pin As Point
        pin.X = My.Computer.Screen.WorkingArea.Width - PictureBox1.Width
        pin.Y = My.Computer.Screen.WorkingArea.Height - PictureBox1.Height
        PictureBox1.Location = pin
        If Form1.Logo = True Then
            frmInfinity.Show()
            frmInfinity.Location = pin
        End If
        
    End Sub

    Private Sub frmAssister_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        
        ml = e.Location
        If My.Computer.Keyboard.CtrlKeyDown = True Then
            LineShape1.X1 = ml.X
            LineShape1.Y1 = ml.Y
            lblCTRL.Left = ml.X
        ElseIf My.Computer.Keyboard.AltKeyDown = True Then
            LineShape1.X2 = ml.X
            LineShape1.Y2 = ml.Y
            lblALT.Left = ml.X
        Else
        End If
        Dim tx As Integer = (LineShape1.X2 - LineShape1.X1)
        Dim ty As Integer = (LineShape1.Y2 - LineShape1.Y1)
        Dim Angle As String
        Dim Tangon As String
        Tangon = ty / tx
        Angle = Math.Atan(Tangon)
        LineShape2.X2 = LineShape1.X2 - frmToolPad.NumericUpDown1.Value * Math.Sin(Angle)
        LineShape2.Y2 = LineShape1.Y2 + frmToolPad.NumericUpDown1.Value * Math.Cos(Angle)
        LineShape2.X1 = LineShape1.X1 - frmToolPad.NumericUpDown1.Value * Math.Sin(Angle)
        LineShape2.Y1 = LineShape1.Y1 + frmToolPad.NumericUpDown1.Value * Math.Cos(Angle)
    End Sub

    Private Sub tmrModeSwitcher_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrModeSwitcher.Tick
        If My.Computer.Keyboard.CapsLock = False Then
            If CheckBox1.Checked = True Then
                CheckBox1.Checked = False
            End If
        Else
            If CheckBox1.Checked = False Then
                CheckBox1.Checked = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            frmToolPad.Hide()
            lblALT.Hide()
            lblCTRL.Hide()
            Me.TransparencyKey = Color.White
            Me.TopMost = True
        Else
            Me.TransparencyKey = Nothing
            frmToolPad.Show()
            Label1.Visible = False
            lblALT.Show()
            Me.TopMost = False
            lblCTRL.Show()
        End If
    End Sub
End Class