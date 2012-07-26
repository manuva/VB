<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewMotor
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpNewRecord = New System.Windows.Forms.GroupBox()
        Me.radNA = New System.Windows.Forms.RadioButton()
        Me.radMNT = New System.Windows.Forms.RadioButton()
        Me.radOff = New System.Windows.Forms.RadioButton()
        Me.radOn = New System.Windows.Forms.RadioButton()
        Me.lblMotorStatus = New System.Windows.Forms.Label()
        Me.txtVoltage = New System.Windows.Forms.TextBox()
        Me.txtMotorRPM = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtMotorID = New System.Windows.Forms.TextBox()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.lblMotorRPM = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblMotorID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpNewRecord.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(66, 242)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(228, 242)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpNewRecord
        '
        Me.grpNewRecord.Controls.Add(Me.radNA)
        Me.grpNewRecord.Controls.Add(Me.radMNT)
        Me.grpNewRecord.Controls.Add(Me.radOff)
        Me.grpNewRecord.Controls.Add(Me.radOn)
        Me.grpNewRecord.Controls.Add(Me.lblMotorStatus)
        Me.grpNewRecord.Controls.Add(Me.txtVoltage)
        Me.grpNewRecord.Controls.Add(Me.txtMotorRPM)
        Me.grpNewRecord.Controls.Add(Me.txtDesc)
        Me.grpNewRecord.Controls.Add(Me.txtMotorID)
        Me.grpNewRecord.Controls.Add(Me.lblVoltage)
        Me.grpNewRecord.Controls.Add(Me.lblMotorRPM)
        Me.grpNewRecord.Controls.Add(Me.lblDesc)
        Me.grpNewRecord.Controls.Add(Me.lblMotorID)
        Me.grpNewRecord.Location = New System.Drawing.Point(13, 66)
        Me.grpNewRecord.Name = "grpNewRecord"
        Me.grpNewRecord.Size = New System.Drawing.Size(337, 166)
        Me.grpNewRecord.TabIndex = 0
        Me.grpNewRecord.TabStop = False
        Me.grpNewRecord.Text = "New Record"
        '
        'radNA
        '
        Me.radNA.AutoSize = True
        Me.radNA.Location = New System.Drawing.Point(250, 124)
        Me.radNA.Name = "radNA"
        Me.radNA.Size = New System.Drawing.Size(40, 17)
        Me.radNA.TabIndex = 8
        Me.radNA.TabStop = True
        Me.radNA.Text = "NA"
        Me.radNA.UseVisualStyleBackColor = True
        '
        'radMNT
        '
        Me.radMNT.AutoSize = True
        Me.radMNT.Location = New System.Drawing.Point(250, 97)
        Me.radMNT.Name = "radMNT"
        Me.radMNT.Size = New System.Drawing.Size(49, 17)
        Me.radMNT.TabIndex = 7
        Me.radMNT.TabStop = True
        Me.radMNT.Text = "MNT"
        Me.radMNT.UseVisualStyleBackColor = True
        '
        'radOff
        '
        Me.radOff.AutoSize = True
        Me.radOff.Location = New System.Drawing.Point(250, 69)
        Me.radOff.Name = "radOff"
        Me.radOff.Size = New System.Drawing.Size(45, 17)
        Me.radOff.TabIndex = 6
        Me.radOff.TabStop = True
        Me.radOff.Text = "OFF"
        Me.radOff.UseVisualStyleBackColor = True
        '
        'radOn
        '
        Me.radOn.AutoSize = True
        Me.radOn.Location = New System.Drawing.Point(250, 42)
        Me.radOn.Name = "radOn"
        Me.radOn.Size = New System.Drawing.Size(41, 17)
        Me.radOn.TabIndex = 5
        Me.radOn.TabStop = True
        Me.radOn.Text = "ON"
        Me.radOn.UseVisualStyleBackColor = True
        '
        'lblMotorStatus
        '
        Me.lblMotorStatus.AutoSize = True
        Me.lblMotorStatus.Location = New System.Drawing.Point(247, 20)
        Me.lblMotorStatus.Name = "lblMotorStatus"
        Me.lblMotorStatus.Size = New System.Drawing.Size(67, 13)
        Me.lblMotorStatus.TabIndex = 8
        Me.lblMotorStatus.Text = "Motor Status"
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(88, 121)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.Size = New System.Drawing.Size(81, 20)
        Me.txtVoltage.TabIndex = 3
        '
        'txtMotorRPM
        '
        Me.txtMotorRPM.Location = New System.Drawing.Point(88, 94)
        Me.txtMotorRPM.Name = "txtMotorRPM"
        Me.txtMotorRPM.Size = New System.Drawing.Size(80, 20)
        Me.txtMotorRPM.TabIndex = 2
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(88, 66)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(105, 20)
        Me.txtDesc.TabIndex = 1
        '
        'txtMotorID
        '
        Me.txtMotorID.Location = New System.Drawing.Point(88, 39)
        Me.txtMotorID.Name = "txtMotorID"
        Me.txtMotorID.Size = New System.Drawing.Size(81, 20)
        Me.txtMotorID.TabIndex = 0
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(17, 118)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(43, 13)
        Me.lblVoltage.TabIndex = 3
        Me.lblVoltage.Text = "Voltage"
        '
        'lblMotorRPM
        '
        Me.lblMotorRPM.AutoSize = True
        Me.lblMotorRPM.Location = New System.Drawing.Point(17, 94)
        Me.lblMotorRPM.Name = "lblMotorRPM"
        Me.lblMotorRPM.Size = New System.Drawing.Size(66, 13)
        Me.lblMotorRPM.TabIndex = 2
        Me.lblMotorRPM.Text = "Motor RPMs"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(17, 66)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(60, 13)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Description"
        '
        'lblMotorID
        '
        Me.lblMotorID.AutoSize = True
        Me.lblMotorID.Location = New System.Drawing.Point(17, 39)
        Me.lblMotorID.Name = "lblMotorID"
        Me.lblMotorID.Size = New System.Drawing.Size(48, 13)
        Me.lblMotorID.TabIndex = 7
        Me.lblMotorID.Text = "Motor ID"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 27)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Motor Collections - Add Motor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(363, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ClearToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "S&ave"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem1.Text = "C&lear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'frmAddNewMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 290)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpNewRecord)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAddNewMotor"
        Me.Text = "Motor Collections - Add Motor"
        Me.grpNewRecord.ResumeLayout(False)
        Me.grpNewRecord.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpNewRecord As System.Windows.Forms.GroupBox
    Friend WithEvents radNA As System.Windows.Forms.RadioButton
    Friend WithEvents radMNT As System.Windows.Forms.RadioButton
    Friend WithEvents radOff As System.Windows.Forms.RadioButton
    Friend WithEvents radOn As System.Windows.Forms.RadioButton
    Friend WithEvents lblMotorStatus As System.Windows.Forms.Label
    Friend WithEvents txtVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtMotorRPM As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtMotorID As System.Windows.Forms.TextBox
    Friend WithEvents lblVoltage As System.Windows.Forms.Label
    Friend WithEvents lblMotorRPM As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblMotorID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
