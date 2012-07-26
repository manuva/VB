<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpAbout = New System.Windows.Forms.GroupBox()
        Me.lblAboutInfo = New System.Windows.Forms.Label()
        Me.grpAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(98, 219)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpAbout
        '
        Me.grpAbout.Controls.Add(Me.lblAboutInfo)
        Me.grpAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAbout.Location = New System.Drawing.Point(13, 31)
        Me.grpAbout.Name = "grpAbout"
        Me.grpAbout.Size = New System.Drawing.Size(259, 171)
        Me.grpAbout.TabIndex = 1
        Me.grpAbout.TabStop = False
        Me.grpAbout.Text = "About"
        '
        'lblAboutInfo
        '
        Me.lblAboutInfo.Location = New System.Drawing.Point(6, 35)
        Me.lblAboutInfo.Name = "lblAboutInfo"
        Me.lblAboutInfo.Size = New System.Drawing.Size(247, 88)
        Me.lblAboutInfo.TabIndex = 0
        Me.lblAboutInfo.Text = resources.GetString("lblAboutInfo.Text")
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.grpAbout)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmAbout"
        Me.Text = "About "
        Me.grpAbout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpAbout As System.Windows.Forms.GroupBox
    Friend WithEvents lblAboutInfo As System.Windows.Forms.Label
End Class
