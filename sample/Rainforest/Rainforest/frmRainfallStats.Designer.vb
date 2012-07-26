<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfallStats
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstRainfall = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.lblMaximum = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileAbout, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileAbout
        '
        Me.mnuFileAbout.Name = "mnuFileAbout"
        Me.mnuFileAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuFileAbout.Text = "About"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(107, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(398, 34)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Rainfall Statistics for Year"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstRainfall
        '
        Me.lstRainfall.FormattingEnabled = True
        Me.lstRainfall.Location = New System.Drawing.Point(12, 73)
        Me.lstRainfall.Name = "lstRainfall"
        Me.lstRainfall.Size = New System.Drawing.Size(120, 160)
        Me.lstRainfall.TabIndex = 2
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 243)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(119, 23)
        Me.btnInput.TabIndex = 3
        Me.btnInput.Text = "Input Monthly Rainfall"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(137, 243)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(95, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Stats"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(245, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(335, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Monthly Rainfall Statistics"
        '
        'lblAnnual
        '
        Me.lblAnnual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnual.Location = New System.Drawing.Point(151, 101)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(259, 23)
        Me.lblAnnual.TabIndex = 8
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(151, 137)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(259, 23)
        Me.lblAverage.TabIndex = 9
        '
        'lblMinimum
        '
        Me.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinimum.Location = New System.Drawing.Point(151, 173)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(259, 23)
        Me.lblMinimum.TabIndex = 10
        '
        'lblMaximum
        '
        Me.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaximum.Location = New System.Drawing.Point(151, 210)
        Me.lblMaximum.Name = "lblMaximum"
        Me.lblMaximum.Size = New System.Drawing.Size(259, 23)
        Me.lblMaximum.TabIndex = 11
        '
        'frmRainfallStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 284)
        Me.Controls.Add(Me.lblMaximum)
        Me.Controls.Add(Me.lblMinimum)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblAnnual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lstRainfall)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRainfallStats"
        Me.Text = "Rainfall Statistics"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lstRainfall As System.Windows.Forms.ListBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAnnual As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblMinimum As System.Windows.Forms.Label
    Friend WithEvents lblMaximum As System.Windows.Forms.Label

End Class
