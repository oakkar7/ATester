Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Public Class frmMain

    Dim rxd As Char

    Dim myPort As Array                                     'var to store all COM ports
    Delegate Sub SetTextCallback(ByVal [text] As String)    'Added to prevent threading errors during receiveing of data

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Show all available COM ports. 
        'For Each sp As String In My.Computer.Ports.SerialPortNames
        'cmbPort.Items.Add(sp)
        'Next

        ' lists all serial ports 
        myPort = IO.Ports.SerialPort.GetPortNames()     ' ports list
        cmbBaud.Items.Add(9600)                         ' baud rates
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)

        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)    'COM no 1
        cmbBaud.Text = cmbBaud.Items.Item(0)

        btnDisconnect.Enabled = False

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text         'Set COM port
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate 

        'Other Serial Port Property
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8                    'Open serial port
        SerialPort1.ReadTimeout = 2000
        SerialPort1.WriteTimeout = 2000

        SerialPort1.Open()

        btnConnect.Enabled = False
        btnDisconnect.Enabled = True

    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()                         'Close Serial Port

        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
    End Sub

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCall.Click, btnHangUp.Click, btnSendSMS.Click, btnReset.Click, btnSave.Click, btnOff.Click, btnSendCmd.Click, btnVersion.Click, btnSignal.Click, btnNetwork.Click, btnAT.Click

        Dim Clicks As String
        Clicks = DirectCast(sender, Button).Name

        'txtRX.AppendText(Clicks & vbCrLf)

        If Clicks = "btnSendCmd" Then
            SerialPort1.Write(txtTX.Text)
            If chkCR.Checked = True Then
                SerialPort1.Write(vbCr)
            End If
            If chkLF.Checked = True Then
                SerialPort1.Write(vbCr)
            End If
        ElseIf Clicks = "btnAT" Then
            SerialPort1.Write(txtAT.Text & vbCr)
        ElseIf Clicks = "btnSignal" Then
            SerialPort1.Write(txtSignal.Text & vbCr)
        ElseIf Clicks = "btnNetwork" Then
            SerialPort1.Write(txtNetwork.Text & vbCr)
        ElseIf Clicks = "btnVersion" Then
            If chkInfo.Checked = True Then
                SerialPort1.Write(txtVersion1.Text & vbCr)
            End If
            'Thread.Sleep(1000)
            If chkHardware.Checked = True Then
                Delay(2)
                SerialPort1.Write(txtVersion2.Text & vbCr)
            End If
            'Thread.Sleep(1000)
            If chkFirmware.Checked = True Then
                Delay(2)
                SerialPort1.Write(txtVersion3.Text & vbCr)
            End If
        ElseIf Clicks = "btnCall" Then
            SerialPort1.Write("ATD" & txtCallNo.Text & ";" & vbCr)
        ElseIf Clicks = "btnHangUp" Then
            SerialPort1.Write(txtHangUp.Text & vbCr)
        ElseIf Clicks = "btnSendSMS" Then
            SerialPort1.Write("AT+CMGS=" & Chr(34) & txtCallNo.Text & Chr(34) & vbCr)
            'Timer1.Enabled = True
            'Timer1.Interval = 1000
            'Timer1.Start()
            'Thread.Sleep(1000)
            Delay(5)
            SerialPort1.Write(txtSMS.Text & Chr(26) & vbCr)
        ElseIf Clicks = "btnReset" Then
            SerialPort1.Write(txtReset.Text & vbCr)
        ElseIf Clicks = "btnSave" Then
            SerialPort1.Write(txtSave.Text & vbCr)
        ElseIf Clicks = "btnOff" Then
            SerialPort1.Write(txtOff.Text & vbCr)
        End If

    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())            'event call for data receving, read until data is completed
        'ReceivedText(SerialPort1.ReadLine())               ' read until line end

    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.txtRX.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            'Me.txtRX.Text &= [text]
            txtRX.AppendText(text & vbCrLf)
            'txtRX2.AppendText(Convert.ToInt32(text, 16) & vbCrLf)
            'txtRX2.AppendText(Hex(text) & vbCrLf)
            txtRX2.AppendText(StrToHex(text) & vbCrLf)
            rxd = text
            If rxd = "#" Then
                MsgBox("This is a test")
            End If

        End If
    End Sub

    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text
        Else
            MsgBox("Port is in use", vbCritical)
        End If
    End Sub

    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text
        Else
            MsgBox("Port is in use", vbCritical)
        End If
    End Sub

    ' # debug test
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Timer1.Stop()
        'add delayed code here
        'SerialPort1.Write(txtSMS.Text & Chr(26) & vbCr)

    End Sub
    ' # debug test for breaking events
    Sub Delay(ByVal dblSecs As Double)
        'From http://pastebin.com/2bSWZ16p

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()                      'Allow windows messages to be processed
        Loop

    End Sub

    Private Function ByteArrayToHexString(ByVal data() As Byte) As String

        Dim sb As New System.Text.StringBuilder(data.Length * 3)
        For Each b As Byte In data
            sb.Append(Convert.ToString(b, 16).PadLeft(2, "0"c).PadRight(3, " "c))
        Next
        Return sb.ToString.ToUpper

    End Function

    'From http://stackoverflow.com/questions/10504034/how-do-you-convert-a-string-into-hexadecimal-in-vb-net

    Public Function StrToHex(ByRef Data As String) As String
        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1, Data.Length - 1)
            sHex = sHex & " " & sVal
        End While
        Return sHex
    End Function


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If

        Me.Close()

    End Sub


    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("          AT Command Tester        " & vbNewLine &
               "             Alpha version         " & vbNewLine &
               "          For SIMCOM Modules       " & vbNewLine &
               "               By                  " & vbNewLine &
               "            oakkar7                " & vbNewLine &
               " http://okelectronic.wordpress.com " & vbNewLine &
               "     https://github.com/oakkar7    "
               )
    End Sub

    Private Sub txtSMS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCallNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtHangUp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
