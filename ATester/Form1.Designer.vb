<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtRX = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtRX2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.chkLF = New System.Windows.Forms.CheckBox()
        Me.chkCR = New System.Windows.Forms.CheckBox()
        Me.txtAT = New System.Windows.Forms.TextBox()
        Me.btnAT = New System.Windows.Forms.Button()
        Me.txtTX = New System.Windows.Forms.TextBox()
        Me.btnSendCmd = New System.Windows.Forms.Button()
        Me.chkFirmware = New System.Windows.Forms.CheckBox()
        Me.chkHardware = New System.Windows.Forms.CheckBox()
        Me.chkInfo = New System.Windows.Forms.CheckBox()
        Me.txtVersion3 = New System.Windows.Forms.TextBox()
        Me.txtSave = New System.Windows.Forms.TextBox()
        Me.txtVersion2 = New System.Windows.Forms.TextBox()
        Me.txtReset = New System.Windows.Forms.TextBox()
        Me.txtOff = New System.Windows.Forms.TextBox()
        Me.txtVersion1 = New System.Windows.Forms.TextBox()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btnVersion = New System.Windows.Forms.Button()
        Me.txtNetwork = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNetwork = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSignal = New System.Windows.Forms.Button()
        Me.txtSignal = New System.Windows.Forms.TextBox()
        Me.txtSMS = New System.Windows.Forms.TextBox()
        Me.btnSendSMS = New System.Windows.Forms.Button()
        Me.txtHangUp = New System.Windows.Forms.TextBox()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.txtCallNo = New System.Windows.Forms.TextBox()
        Me.btnHangUp = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'txtRX
        '
        Me.txtRX.Location = New System.Drawing.Point(436, 79)
        Me.txtRX.Multiline = True
        Me.txtRX.Name = "txtRX"
        Me.txtRX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRX.Size = New System.Drawing.Size(540, 353)
        Me.txtRX.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'txtRX2
        '
        Me.txtRX2.Location = New System.Drawing.Point(436, 455)
        Me.txtRX2.Multiline = True
        Me.txtRX2.Name = "txtRX2"
        Me.txtRX2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRX2.Size = New System.Drawing.Size(540, 139)
        Me.txtRX2.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Received"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(436, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Received (HEX)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.atester_logo
        Me.PictureBox1.Location = New System.Drawing.Point(247, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1004, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(420, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 582)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modem Respond"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbBaud)
        Me.GroupBox2.Controls.Add(Me.cmbPort)
        Me.GroupBox2.Controls.Add(Me.btnDisconnect)
        Me.GroupBox2.Controls.Add(Me.btnConnect)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 85)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COM Port"
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(99, 54)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(111, 21)
        Me.cmbBaud.TabIndex = 8
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(99, 25)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(111, 21)
        Me.cmbPort.TabIndex = 7
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(18, 52)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 6
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(18, 24)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'chkLF
        '
        Me.chkLF.AutoSize = True
        Me.chkLF.Location = New System.Drawing.Point(367, 176)
        Me.chkLF.Name = "chkLF"
        Me.chkLF.Size = New System.Drawing.Size(38, 17)
        Me.chkLF.TabIndex = 50
        Me.chkLF.Text = "LF"
        Me.chkLF.UseVisualStyleBackColor = True
        '
        'chkCR
        '
        Me.chkCR.AutoSize = True
        Me.chkCR.Checked = True
        Me.chkCR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCR.Location = New System.Drawing.Point(367, 153)
        Me.chkCR.Name = "chkCR"
        Me.chkCR.Size = New System.Drawing.Size(41, 17)
        Me.chkCR.TabIndex = 49
        Me.chkCR.Text = "CR"
        Me.chkCR.UseVisualStyleBackColor = True
        '
        'txtAT
        '
        Me.txtAT.Location = New System.Drawing.Point(101, 194)
        Me.txtAT.Name = "txtAT"
        Me.txtAT.Size = New System.Drawing.Size(250, 20)
        Me.txtAT.TabIndex = 48
        Me.txtAT.Text = "AT"
        '
        'btnAT
        '
        Me.btnAT.Location = New System.Drawing.Point(21, 194)
        Me.btnAT.Name = "btnAT"
        Me.btnAT.Size = New System.Drawing.Size(75, 23)
        Me.btnAT.TabIndex = 47
        Me.btnAT.Text = "AT"
        Me.btnAT.UseVisualStyleBackColor = True
        '
        'txtTX
        '
        Me.txtTX.Location = New System.Drawing.Point(102, 149)
        Me.txtTX.Multiline = True
        Me.txtTX.Name = "txtTX"
        Me.txtTX.Size = New System.Drawing.Size(250, 39)
        Me.txtTX.TabIndex = 46
        '
        'btnSendCmd
        '
        Me.btnSendCmd.Location = New System.Drawing.Point(21, 146)
        Me.btnSendCmd.Name = "btnSendCmd"
        Me.btnSendCmd.Size = New System.Drawing.Size(75, 42)
        Me.btnSendCmd.TabIndex = 45
        Me.btnSendCmd.Text = "Send Command"
        Me.btnSendCmd.UseVisualStyleBackColor = True
        '
        'chkFirmware
        '
        Me.chkFirmware.AutoSize = True
        Me.chkFirmware.Location = New System.Drawing.Point(235, 337)
        Me.chkFirmware.Name = "chkFirmware"
        Me.chkFirmware.Size = New System.Drawing.Size(68, 17)
        Me.chkFirmware.TabIndex = 67
        Me.chkFirmware.Text = "Firmware"
        Me.chkFirmware.UseVisualStyleBackColor = True
        '
        'chkHardware
        '
        Me.chkHardware.AutoSize = True
        Me.chkHardware.Location = New System.Drawing.Point(235, 309)
        Me.chkHardware.Name = "chkHardware"
        Me.chkHardware.Size = New System.Drawing.Size(45, 17)
        Me.chkHardware.TabIndex = 66
        Me.chkHardware.Text = "HW"
        Me.chkHardware.UseVisualStyleBackColor = True
        '
        'chkInfo
        '
        Me.chkInfo.AutoSize = True
        Me.chkInfo.Location = New System.Drawing.Point(235, 283)
        Me.chkInfo.Name = "chkInfo"
        Me.chkInfo.Size = New System.Drawing.Size(44, 17)
        Me.chkInfo.TabIndex = 65
        Me.chkInfo.Text = "Info"
        Me.chkInfo.UseVisualStyleBackColor = True
        '
        'txtVersion3
        '
        Me.txtVersion3.Location = New System.Drawing.Point(102, 335)
        Me.txtVersion3.Name = "txtVersion3"
        Me.txtVersion3.Size = New System.Drawing.Size(121, 20)
        Me.txtVersion3.TabIndex = 64
        Me.txtVersion3.Text = "AT+GSV"
        '
        'txtSave
        '
        Me.txtSave.Location = New System.Drawing.Point(102, 392)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(121, 20)
        Me.txtSave.TabIndex = 54
        Me.txtSave.Text = "AT&W"
        '
        'txtVersion2
        '
        Me.txtVersion2.Location = New System.Drawing.Point(102, 309)
        Me.txtVersion2.Name = "txtVersion2"
        Me.txtVersion2.Size = New System.Drawing.Size(121, 20)
        Me.txtVersion2.TabIndex = 63
        Me.txtVersion2.Text = "AT+GMR"
        '
        'txtReset
        '
        Me.txtReset.Location = New System.Drawing.Point(102, 366)
        Me.txtReset.Name = "txtReset"
        Me.txtReset.Size = New System.Drawing.Size(121, 20)
        Me.txtReset.TabIndex = 51
        Me.txtReset.Text = "AT&F"
        '
        'txtOff
        '
        Me.txtOff.Location = New System.Drawing.Point(102, 427)
        Me.txtOff.Name = "txtOff"
        Me.txtOff.Size = New System.Drawing.Size(121, 20)
        Me.txtOff.TabIndex = 56
        Me.txtOff.Text = "AT+CPOWD=1"
        '
        'txtVersion1
        '
        Me.txtVersion1.Location = New System.Drawing.Point(102, 283)
        Me.txtVersion1.Name = "txtVersion1"
        Me.txtVersion1.Size = New System.Drawing.Size(121, 20)
        Me.txtVersion1.TabIndex = 62
        Me.txtVersion1.Text = "ATI"
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(21, 424)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOff.TabIndex = 55
        Me.btnOff.Text = "Power Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnVersion
        '
        Me.btnVersion.Location = New System.Drawing.Point(21, 281)
        Me.btnVersion.Name = "btnVersion"
        Me.btnVersion.Size = New System.Drawing.Size(75, 23)
        Me.btnVersion.TabIndex = 61
        Me.btnVersion.Text = "Versions"
        Me.btnVersion.UseVisualStyleBackColor = True
        '
        'txtNetwork
        '
        Me.txtNetwork.Location = New System.Drawing.Point(102, 254)
        Me.txtNetwork.Name = "txtNetwork"
        Me.txtNetwork.Size = New System.Drawing.Size(121, 20)
        Me.txtNetwork.TabIndex = 60
        Me.txtNetwork.Text = "AT+CREG?"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(21, 395)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNetwork
        '
        Me.btnNetwork.Location = New System.Drawing.Point(21, 252)
        Me.btnNetwork.Name = "btnNetwork"
        Me.btnNetwork.Size = New System.Drawing.Size(75, 23)
        Me.btnNetwork.TabIndex = 59
        Me.btnNetwork.Text = "Network"
        Me.btnNetwork.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(21, 366)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 52
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSignal
        '
        Me.btnSignal.Location = New System.Drawing.Point(21, 223)
        Me.btnSignal.Name = "btnSignal"
        Me.btnSignal.Size = New System.Drawing.Size(75, 23)
        Me.btnSignal.TabIndex = 58
        Me.btnSignal.Text = "Signal"
        Me.btnSignal.UseVisualStyleBackColor = True
        '
        'txtSignal
        '
        Me.txtSignal.Location = New System.Drawing.Point(102, 225)
        Me.txtSignal.Name = "txtSignal"
        Me.txtSignal.Size = New System.Drawing.Size(121, 20)
        Me.txtSignal.TabIndex = 57
        Me.txtSignal.Text = "AT+CSQ"
        '
        'txtSMS
        '
        Me.txtSMS.Location = New System.Drawing.Point(102, 554)
        Me.txtSMS.Multiline = True
        Me.txtSMS.Name = "txtSMS"
        Me.txtSMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSMS.Size = New System.Drawing.Size(121, 42)
        Me.txtSMS.TabIndex = 73
        Me.txtSMS.Text = "Hello! SMS Test"
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Location = New System.Drawing.Point(21, 564)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(75, 23)
        Me.btnSendSMS.TabIndex = 72
        Me.btnSendSMS.Text = "Send SMS"
        Me.btnSendSMS.UseVisualStyleBackColor = True
        '
        'txtHangUp
        '
        Me.txtHangUp.Location = New System.Drawing.Point(102, 528)
        Me.txtHangUp.Name = "txtHangUp"
        Me.txtHangUp.Size = New System.Drawing.Size(121, 20)
        Me.txtHangUp.TabIndex = 70
        Me.txtHangUp.Text = "ATH"
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(21, 496)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(75, 23)
        Me.btnCall.TabIndex = 68
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'txtCallNo
        '
        Me.txtCallNo.Location = New System.Drawing.Point(102, 499)
        Me.txtCallNo.Name = "txtCallNo"
        Me.txtCallNo.Size = New System.Drawing.Size(121, 20)
        Me.txtCallNo.TabIndex = 69
        Me.txtCallNo.Text = "+959"
        '
        'btnHangUp
        '
        Me.btnHangUp.Location = New System.Drawing.Point(21, 526)
        Me.btnHangUp.Name = "btnHangUp"
        Me.btnHangUp.Size = New System.Drawing.Size(75, 23)
        Me.btnHangUp.TabIndex = 71
        Me.btnHangUp.Text = "HangUp"
        Me.btnHangUp.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 623)
        Me.Controls.Add(Me.txtSMS)
        Me.Controls.Add(Me.btnSendSMS)
        Me.Controls.Add(Me.txtHangUp)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.txtCallNo)
        Me.Controls.Add(Me.btnHangUp)
        Me.Controls.Add(Me.chkFirmware)
        Me.Controls.Add(Me.chkHardware)
        Me.Controls.Add(Me.chkInfo)
        Me.Controls.Add(Me.txtVersion3)
        Me.Controls.Add(Me.txtSave)
        Me.Controls.Add(Me.txtVersion2)
        Me.Controls.Add(Me.txtReset)
        Me.Controls.Add(Me.txtOff)
        Me.Controls.Add(Me.txtVersion1)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnVersion)
        Me.Controls.Add(Me.txtNetwork)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNetwork)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSignal)
        Me.Controls.Add(Me.txtSignal)
        Me.Controls.Add(Me.chkLF)
        Me.Controls.Add(Me.chkCR)
        Me.Controls.Add(Me.txtAT)
        Me.Controls.Add(Me.btnAT)
        Me.Controls.Add(Me.txtTX)
        Me.Controls.Add(Me.btnSendCmd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRX)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtRX2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "AT Command Tester"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txtRX As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtRX2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents chkLF As System.Windows.Forms.CheckBox
    Friend WithEvents chkCR As System.Windows.Forms.CheckBox
    Friend WithEvents txtAT As System.Windows.Forms.TextBox
    Friend WithEvents btnAT As System.Windows.Forms.Button
    Friend WithEvents txtTX As System.Windows.Forms.TextBox
    Friend WithEvents btnSendCmd As System.Windows.Forms.Button
    Friend WithEvents chkFirmware As System.Windows.Forms.CheckBox
    Friend WithEvents chkHardware As System.Windows.Forms.CheckBox
    Friend WithEvents chkInfo As System.Windows.Forms.CheckBox
    Friend WithEvents txtVersion3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSave As System.Windows.Forms.TextBox
    Friend WithEvents txtVersion2 As System.Windows.Forms.TextBox
    Friend WithEvents txtReset As System.Windows.Forms.TextBox
    Friend WithEvents txtOff As System.Windows.Forms.TextBox
    Friend WithEvents txtVersion1 As System.Windows.Forms.TextBox
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btnVersion As System.Windows.Forms.Button
    Friend WithEvents txtNetwork As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNetwork As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSignal As System.Windows.Forms.Button
    Friend WithEvents txtSignal As System.Windows.Forms.TextBox
    Friend WithEvents txtSMS As System.Windows.Forms.TextBox
    Friend WithEvents btnSendSMS As System.Windows.Forms.Button
    Friend WithEvents txtHangUp As System.Windows.Forms.TextBox
    Friend WithEvents btnCall As System.Windows.Forms.Button
    Friend WithEvents txtCallNo As System.Windows.Forms.TextBox
    Friend WithEvents btnHangUp As System.Windows.Forms.Button

End Class
