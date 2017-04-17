Public Class frmSettings
    Public Namez As String
    Public Amonut As Double
    Public Valcan As Boolean
    Private Sub reload()
        Dim count As Integer = 0
        ListView1.Items.Clear()
        For Each itm As String In Form1.ProfileNameList.Items
            With ListView1.Items.Add(itm, 0)
                .SubItems.Add(Form1.ProfileValueList.Items(count))
            End With
            count = count + 1
        Next
        If Val(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Logo", "1")) = 0 Then
            CheckBox1.Checked = False
            Form1.Logo = False
        Else
            CheckBox1.Checked = True
            Form1.Logo = True
        End If
        If Val(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Direct", "0")) = 0 Then
            CheckBox2.Checked = False
            Form1.direct = 0
        Else
            CheckBox2.Checked = True
            Form1.direct = 1
        End If
    End Sub
    Private Sub SaveProfiles()
        Dim count As Integer = 0
        Dim valuz As String = Nothing
        For Each element As String In Form1.ProfileNameList.Items
            If valuz = "" Then
                valuz = valuz & element & ":" & Form1.ProfileValueList.Items.Item(count)
            Else
                valuz = valuz & "," & element & ":" & Form1.ProfileValueList.Items.Item(count)
            End If
            count = count + 1
        Next
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Profiles", valuz)
    End Sub

    Private Sub frmSettings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.LoadProfileValues()
    End Sub
    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Indi As Integer
        If ListView1.SelectedItems.Count > 0 Then
            Indi = ListView1.SelectedItems(0).Index
            ListView1.Items.RemoveAt(Indi)
            Form1.ProfileNameList.Items.RemoveAt(Indi)
            Form1.ProfileValueList.Items.RemoveAt(Indi)
            SaveProfiles()
            reload()
        Else
            MsgBox("No Items Selected", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim newwa As Form = New frmNewValue
        Valcan = True
        newwa.ShowDialog()
        If Valcan = False Then
            With ListView1.Items.Add(Namez, 0)
                .SubItems.Add(Amonut)
            End With
            Form1.ProfileNameList.Items.Add(Namez)
            Form1.ProfileValueList.Items.Add(Amonut)
        End If
        SaveProfiles()
        reload()
    End Sub

   
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Logo", "1")
            Form1.Logo = True
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Logo", "0")
            Form1.Logo = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Direct", "1")
            Form1.direct = 1
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Direct", "0")
            Form1.direct = 0
        End If
    End Sub
End Class