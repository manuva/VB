<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarpet
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
        Me.grpCarpetData = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtStyle = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStyle = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.grpRoomSize = New System.Windows.Forms.GroupBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblAreaBox = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpCarpetData.SuspendLayout()
        Me.grpRoomSize.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCarpetData
        '
        Me.grpCarpetData.Controls.Add(Me.txtPrice)
        Me.grpCarpetData.Controls.Add(Me.txtStyle)
        Me.grpCarpetData.Controls.Add(Me.txtColor)
        Me.grpCarpetData.Controls.Add(Me.Label1)
        Me.grpCarpetData.Controls.Add(Me.lblPrice)
        Me.grpCarpetData.Controls.Add(Me.lblStyle)
        Me.grpCarpetData.Controls.Add(Me.lblColor)
        Me.grpCarpetData.Location = New System.Drawing.Point(13, 61)
        Me.grpCarpetData.Name = "grpCarpetData"
        Me.grpCarpetData.Size = New System.Drawing.Size(214, 151)
        Me.grpCarpetData.TabIndex = 2
        Me.grpCarpetData.TabStop = False
        Me.grpCarpetData.Text = "Carpet Data"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(74, 98)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 4
        '
        'txtStyle
        '
        Me.txtStyle.Location = New System.Drawing.Point(74, 62)
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.Size = New System.Drawing.Size(100, 20)
        Me.txtStyle.TabIndex = 3
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(74, 27)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "( per Square Foot )"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(33, 98)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price:"
        '
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Location = New System.Drawing.Point(33, 62)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblStyle.TabIndex = 1
        Me.lblStyle.Text = "Style:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(33, 27)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 1
        Me.lblColor.Text = "Color:"
        '
        'grpRoomSize
        '
        Me.grpRoomSize.Controls.Add(Me.txtLength)
        Me.grpRoomSize.Controls.Add(Me.txtWidth)
        Me.grpRoomSize.Controls.Add(Me.lblAreaBox)
        Me.grpRoomSize.Controls.Add(Me.lblArea)
        Me.grpRoomSize.Controls.Add(Me.lblLength)
        Me.grpRoomSize.Controls.Add(Me.lblWidth)
        Me.grpRoomSize.Location = New System.Drawing.Point(256, 61)
        Me.grpRoomSize.Name = "grpRoomSize"
        Me.grpRoomSize.Size = New System.Drawing.Size(217, 151)
        Me.grpRoomSize.TabIndex = 3
        Me.grpRoomSize.TabStop = False
        Me.grpRoomSize.Text = "Room Size"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(84, 59)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 6
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(84, 27)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 5
        '
        'lblAreaBox
        '
        Me.lblAreaBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAreaBox.Location = New System.Drawing.Point(84, 95)
        Me.lblAreaBox.Name = "lblAreaBox"
        Me.lblAreaBox.Size = New System.Drawing.Size(100, 20)
        Me.lblAreaBox.TabIndex = 6
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(18, 98)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 13)
        Me.lblArea.TabIndex = 5
        Me.lblArea.Text = "Area:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(18, 59)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 4
        Me.lblLength.Text = "Length:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(18, 27)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 3
        Me.lblWidth.Text = "Width:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(83, 279)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 35)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(182, 279)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(277, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(118, 235)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(182, 234)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 18)
        Me.lblTotal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Carpet Area With Classes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(487, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "A&bout"
        '
        'frmCarpet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 336)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpRoomSize)
        Me.Controls.Add(Me.grpCarpetData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCarpet"
        Me.Text = "Carpet Price Calculator"
        Me.grpCarpetData.ResumeLayout(False)
        Me.grpCarpetData.PerformLayout()
        Me.grpRoomSize.ResumeLayout(False)
        Me.grpRoomSize.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCarpetData As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblStyle As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents grpRoomSize As System.Windows.Forms.GroupBox
    Friend WithEvents lblAreaBox As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtStyle As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox

End Class
