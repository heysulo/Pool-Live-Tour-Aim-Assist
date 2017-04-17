
Public Class Form1
    Public direct As Integer
    Dim RGB As Integer
    Dim RGBC As Boolean
    Dim maiden As Boolean
    Public rev As String
    Public ProfileNameList As ListBox = New ListBox
    Public ProfileValueList As ListBox = New ListBox
    Dim Down2check As String
    Dim count As Integer
    Public Logo As Boolean
    Dim worker2fail As Boolean
    Public Myver As String
    Public Sub LoadProfileValues()
        On Error GoTo Erorhandle
        Dim RegRead As TextBox = New TextBox
        Dim sndBox As TextBox = New TextBox
        ProfileNameList.Items.Clear()
        ProfileValueList.Items.Clear()
        RegRead.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Profiles", Nothing)
        RegRead.Text = RegRead.Text.Replace(",", vbCrLf)
        For Each NewLine As String In RegRead.Lines
            NewLine = NewLine.Replace(":", vbCrLf)
            sndBox.Text = NewLine
            ProfileNameList.Items.Add(sndBox.Lines(0))
            ProfileValueList.Items.Add(sndBox.Lines(1))
        Next
        Exit Sub
Erorhandle:
        MsgBox("An error occured while Loading profiles. The profiles might not have being loaded. Please use manual values." & vbCrLf & ErrorToString(), MsgBoxStyle.Critical, "Error occured")
        Exit Sub
    End Sub



    Private Sub lblAim_Assist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAim_Assist.Click
        Me.Hide()
        frmAssister.Show()
    End Sub

    Private Sub lblAim_Assist_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAim_Assist.MouseEnter
        lblAim_Assist.BackColor = Color.White
        lblAim_Assist.Text = "Use Aim Assist"
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub



    Private Sub lblAim_Assist_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAim_Assist.MouseLeave
        lblAim_Assist.BackColor = Color.Transparent
        lblAim_Assist.Text = ""
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub

    Private Sub lblHow_To_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHow_To.Click
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Youtube", Nothing) = Nothing Then
            MsgBox("The Youtube video is not Avaiable", vbInformation)
        Else
            Process.Start(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Youtube", Nothing))
        End If
    End Sub

    Private Sub lblHow_To_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblHow_To.MouseEnter
        lblHow_To.BackColor = Color.White
        lblHow_To.Text = "Watch a video showing how to use the PLT Aim Assist"
        Me.Cursor = Windows.Forms.Cursors.Hand
    End Sub

    Private Sub lblHow_To_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblHow_To.MouseLeave
        lblHow_To.BackColor = Color.Transparent
        Me.Cursor = Windows.Forms.Cursors.Default
        lblHow_To.Text = ""
    End Sub

    Private Sub lblSettings_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSettings.MouseEnter
        lblSettings.BackColor = Color.White
        lblSettings.Text = "Make Adjustment and change settings"
        Me.Cursor = Windows.Forms.Cursors.Hand
    End Sub

    Private Sub lblSettings_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSettings.MouseLeave
        lblSettings.BackColor = Color.Transparent
        lblSettings.Text = ""
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub

    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        If MsgBox("Are you sure that you wanna Exit PLT AIm Assist ?", vbYesNoCancel + vbQuestion, "Exit PLT Aim Assist") = vbYes Then
            End
        End If

    End Sub

    Private Sub lblExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseEnter
        lblExit.BackColor = Color.White
        lblExit.Text = "Exit PLT Aim Assist"
        Me.Cursor = Windows.Forms.Cursors.Hand
    End Sub

    Private Sub lblExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseLeave
        lblExit.BackColor = Color.Transparent
        lblExit.Text = ""
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.facebook.com/Infinity.Researches")
    End Sub

    Private Sub lblSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rev = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Maiden", 1)
        If rev = "0" Then
            maiden = False
        Else
            maiden = True
        End If
        count = 60
        worker1.RunWorkerAsync()
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start("https://docs.google.com/forms/d/1lYThabeynmX1UXEy7At_DeA82BdTCUBhzQnHYVz6N7U/viewform")
    End Sub

    Private Sub worker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles worker1.DoWork
        Myver = "01"
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Maiden", 1) <> "0" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Logo", "1")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Profiles", "LEVEL 1:21.9,LEVEL 2:21.9,LEVEL 3:21.9,LEVEL 5:18.3,LEVEL 7:19,LEVEL 9:16.3")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Version", "0")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Youtube", "0")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Direct", "0")
        End If
        LoadProfileValues()
        If Val(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Logo", "1")) = 1 Then
            Logo = True
        Else
            Logo = False
        End If
        If Val(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Direct", "0")) = 1 Then
            direct = 1
        Else
            direct = 0
        End If
    End Sub

    Private Sub worker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles worker2.DoWork
        Dim downdata As String
        Dim tempfile As String = System.IO.Path.GetRandomFileName
        Dim internet As System.Net.WebClient = New Net.WebClient
        Dim virtualtb As TextBox = New TextBox
        worker2fail = False

        If My.Computer.Network.IsAvailable = True Then
            On Error GoTo erhz
            internet.DownloadString("http://www.google.com")
            GoTo cont1
erhz:
            MsgBox("You are currently not connected to Internet. Application Exiting", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal)
            End
        Else
            MsgBox("This Computer is not connected to any network. Application Exiting", vbExclamation + MsgBoxStyle.SystemModal)
            End
        End If
cont1:
        On Error GoTo erh1
        My.Computer.Network.DownloadFile("http://pltaaserver.webs.com/data/prefs.txt", My.Computer.FileSystem.SpecialDirectories.Temp & "\" & tempfile)
cont2:
        On Error GoTo erh2
        downdata = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & tempfile)
cont3:
        On Error GoTo erh3
        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & tempfile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        virtualtb.Text = downdata
        If downdata.Length < 2 Then
            worker2fail = True
            Exit Sub
        End If
        On Error Resume Next
        Dim oldver As Integer = Val(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Version", 0))
        Dim oldvern As String = virtualtb.Lines(0).ToString
        Dim Newver As Integer = Val(oldvern)
        If Not oldver = Newver Then
            If virtualtb.Lines(3).Contains("01") Then
                Timer1.Enabled = False
                If MsgBox("I'm sorry but this version of the Pool Live Tour Aim Assist has being blocked being executed for some reason like an exterme error. Please contact the developer via Facebook or update into a never version. This application will now exit. Would you like to visit the official Facebook page of Infinity Researches now to reslove this problem ?", MsgBoxStyle.Critical + vbYesNo + MsgBoxStyle.SystemModal, "Version Blocked") = vbYes Then
                    Process.Start("https://www.facebook.com/Infinity.Researches")
                End If
                End
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Version", Val(virtualtb.Lines(0)))
            If virtualtb.Lines(1).Length > 0 Then
                Timer1.Enabled = False
                MsgBox(virtualtb.Lines(1).Replace("^n", vbCrLf), vbInformation + MsgBoxStyle.SystemModal, "Incoming Message - PLTAA Servers")
                Timer1.Enabled = True
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PLTAA", "Youtube", virtualtb.Lines(2))
            If virtualtb.Lines(4) <> "" Then
                Process.Start(virtualtb.Lines(4))
            End If
        End If

        worker2fail = False
        Down2check = downdata
        System.Threading.Thread.Sleep(3000)
        Exit Sub
erh1:
        Timer1.Enabled = False
        MsgBox("Unable to retrive data from servers." & vbCrLf & ErrorToString(), MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
        Timer1.Enabled = True
        End
erh2:
        Timer1.Enabled = False
        MsgBox("Unable to read new data." & vbCrLf & ErrorToString(), MsgBoxStyle.Critical + MsgBoxStyle.SystemModal)
        Timer1.Enabled = True
        GoTo cont3
erh3:
        Timer1.Enabled = False
        MsgBox("Unable to delete temporary file. Please try to delete the " & My.Computer.FileSystem.SpecialDirectories.Temp & "\" & tempfile & " or you can just ignore this. The file is less than 5Kb. " & vbCrLf & vbCrLf & ErrorToString(), MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal)
        Timer1.Enabled = True
        GoTo cont3

    End Sub

    Private Sub worker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles worker2.RunWorkerCompleted
        direct = Val(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PLTAA", "Direct", "0"))
        If worker2fail = True Then
            worker2.RunWorkerAsync()
        Else
            Label1.Text = "Aim Assister Armed and Ready ;)"
            Timer1.Enabled = False
            If maiden = True Then
                frmEULA.ShowDialog()
            End If
            Panel1.Visible = False
            If direct = 1 Then
                Me.Hide()
                frmAssister.Show()
            End If
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If My.Computer.Keyboard.CtrlKeyDown = True Then
            MsgBox(Down2check)
        Else
            frmDimmer.Show()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If MsgBox("Are you sure that you wanna Exit PLT AIm Assist ?", vbYesNoCancel + vbQuestion, "Exit PLT Aim Assist") = vbYes Then
            End
        End If
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.img_BCL
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.img_BSN
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If count <= 0 Then
            Application.Restart()
        Else
            count = count - 1
            lblCount.Text = "Automatic Restart in : " & count & " sec(s)"
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If Timer1.Enabled = True Then
            PictureBox5.Image = My.Resources.switch_off
            lblCount.Text = "Automatic Restart Deactivated"
            count = 60
            Timer1.Enabled = False
        Else
            PictureBox5.Image = My.Resources.switch_on
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub lblCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCount.Click
        If Timer1.Enabled = True Then
            PictureBox5.Image = My.Resources.switch_off
            Timer1.Enabled = False
            count = 60
        Else
            PictureBox5.Image = My.Resources.switch_on
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub worker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles worker1.RunWorkerCompleted
        worker2.RunWorkerAsync()
    End Sub

    Private Sub workertest_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles workertest.DoWork
        MsgBox("heeeeeeeeeeeeey")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim color As Color
        color = System.Drawing.Color.FromArgb(255, RGB, RGB, RGB)
        If RGBC = False Then
            If RGB < 255 Then
                RGB = RGB + 5
            ElseIf RGB = 255 Then
                RGBC = True
                RGB = RGB - 5
            End If
        Else
            If RGB > 0 Then
                RGB = RGB - 5
            ElseIf RGB = 0 Then
                RGBC = False
                RGB = RGB + 5
            End If
        End If
        Label2.ForeColor = color
    End Sub
End Class
