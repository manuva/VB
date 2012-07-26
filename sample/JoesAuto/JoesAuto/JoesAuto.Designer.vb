<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoesAuto
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpOil = New System.Windows.Forms.GroupBox()
        Me.chkLube = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.grpFlush = New System.Windows.Forms.GroupBox()
        Me.chkTrans = New System.Windows.Forms.CheckBox()
        Me.chkRadiator = New System.Windows.Forms.CheckBox()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.chkTire = New System.Windows.Forms.CheckBox()
        Me.chkMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspect = New System.Windows.Forms.CheckBox()
        Me.grpService = New System.Windows.Forms.GroupBox()
        Me.lblPart = New System.Windows.Forms.Label()
        Me.lblLabor = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtPart = New System.Windows.Forms.TextBox()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblPartsFees = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTaxCost = New System.Windows.Forms.Label()
        Me.lblPartCost = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblLaborCost = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpOil.SuspendLayout()
        Me.grpFlush.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.grpService.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Sneakerhead BTN Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(36, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(297, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Joe's Automotive - C6"
        '
        'grpOil
        '
        Me.grpOil.Controls.Add(Me.chkLube)
        Me.grpOil.Controls.Add(Me.chkOil)
        Me.grpOil.Location = New System.Drawing.Point(13, 60)
        Me.grpOil.Name = "grpOil"
        Me.grpOil.Size = New System.Drawing.Size(168, 100)
        Me.grpOil.TabIndex = 1
        Me.grpOil.TabStop = False
        Me.grpOil.Text = "Oil && Lube"
        '
        'chkLube
        '
        Me.chkLube.AutoSize = True
        Me.chkLube.Location = New System.Drawing.Point(7, 57)
        Me.chkLube.Name = "chkLube"
        Me.chkLube.Size = New System.Drawing.Size(112, 17)
        Me.chkLube.TabIndex = 1
        Me.chkLube.Text = "Lube Job ($18.00)"
        Me.chkLube.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Location = New System.Drawing.Point(7, 26)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(120, 17)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Oil Change ($26.00)"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'grpFlush
        '
        Me.grpFlush.Controls.Add(Me.chkTrans)
        Me.grpFlush.Controls.Add(Me.chkRadiator)
        Me.grpFlush.Location = New System.Drawing.Point(187, 60)
        Me.grpFlush.Name = "grpFlush"
        Me.grpFlush.Size = New System.Drawing.Size(185, 100)
        Me.grpFlush.TabIndex = 2
        Me.grpFlush.TabStop = False
        Me.grpFlush.Text = "Flushes"
        '
        'chkTrans
        '
        Me.chkTrans.AutoSize = True
        Me.chkTrans.Location = New System.Drawing.Point(7, 57)
        Me.chkTrans.Name = "chkTrans"
        Me.chkTrans.Size = New System.Drawing.Size(157, 17)
        Me.chkTrans.TabIndex = 1
        Me.chkTrans.Text = "Transmission Flush ($80.00)"
        Me.chkTrans.UseVisualStyleBackColor = True
        '
        'chkRadiator
        '
        Me.chkRadiator.AutoSize = True
        Me.chkRadiator.Location = New System.Drawing.Point(7, 26)
        Me.chkRadiator.Name = "chkRadiator"
        Me.chkRadiator.Size = New System.Drawing.Size(136, 17)
        Me.chkRadiator.TabIndex = 0
        Me.chkRadiator.Text = "Radiator Flush ($30.00)"
        Me.chkRadiator.UseVisualStyleBackColor = True
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.chkTire)
        Me.grpMisc.Controls.Add(Me.chkMuffler)
        Me.grpMisc.Controls.Add(Me.chkInspect)
        Me.grpMisc.Location = New System.Drawing.Point(13, 183)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(168, 141)
        Me.grpMisc.TabIndex = 3
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Misc."
        '
        'chkTire
        '
        Me.chkTire.AutoSize = True
        Me.chkTire.Location = New System.Drawing.Point(7, 96)
        Me.chkTire.Name = "chkTire"
        Me.chkTire.Size = New System.Drawing.Size(129, 17)
        Me.chkTire.TabIndex = 2
        Me.chkTire.Text = "Tire Rotation ($20.00)"
        Me.chkTire.UseVisualStyleBackColor = True
        '
        'chkMuffler
        '
        Me.chkMuffler.AutoSize = True
        Me.chkMuffler.Location = New System.Drawing.Point(7, 62)
        Me.chkMuffler.Name = "chkMuffler"
        Me.chkMuffler.Size = New System.Drawing.Size(149, 17)
        Me.chkMuffler.TabIndex = 1
        Me.chkMuffler.Text = "Replace Muffler ($100.00)"
        Me.chkMuffler.UseVisualStyleBackColor = True
        '
        'chkInspect
        '
        Me.chkInspect.AutoSize = True
        Me.chkInspect.Location = New System.Drawing.Point(7, 30)
        Me.chkInspect.Name = "chkInspect"
        Me.chkInspect.Size = New System.Drawing.Size(117, 17)
        Me.chkInspect.TabIndex = 0
        Me.chkInspect.Text = "Inspection ($15.00)"
        Me.chkInspect.UseVisualStyleBackColor = True
        '
        'grpService
        '
        Me.grpService.Controls.Add(Me.lblPart)
        Me.grpService.Controls.Add(Me.lblLabor)
        Me.grpService.Controls.Add(Me.txtLabor)
        Me.grpService.Controls.Add(Me.txtPart)
        Me.grpService.Location = New System.Drawing.Point(188, 183)
        Me.grpService.Name = "grpService"
        Me.grpService.Size = New System.Drawing.Size(184, 141)
        Me.grpService.TabIndex = 4
        Me.grpService.TabStop = False
        Me.grpService.Text = "Other Services"
        '
        'lblPart
        '
        Me.lblPart.AutoSize = True
        Me.lblPart.Location = New System.Drawing.Point(12, 34)
        Me.lblPart.Name = "lblPart"
        Me.lblPart.Size = New System.Drawing.Size(26, 13)
        Me.lblPart.TabIndex = 3
        Me.lblPart.Text = "Part"
        '
        'lblLabor
        '
        Me.lblLabor.AutoSize = True
        Me.lblLabor.Location = New System.Drawing.Point(10, 74)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(34, 13)
        Me.lblLabor.TabIndex = 2
        Me.lblLabor.Text = "Labor"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(50, 71)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 20)
        Me.txtLabor.TabIndex = 1
        '
        'txtPart
        '
        Me.txtPart.Location = New System.Drawing.Point(50, 30)
        Me.txtPart.Name = "txtPart"
        Me.txtPart.Size = New System.Drawing.Size(100, 20)
        Me.txtPart.TabIndex = 0
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.lblTotalFees)
        Me.grpTotal.Controls.Add(Me.lblTax)
        Me.grpTotal.Controls.Add(Me.lblPartsFees)
        Me.grpTotal.Controls.Add(Me.lblTotalCost)
        Me.grpTotal.Controls.Add(Me.lblTaxCost)
        Me.grpTotal.Controls.Add(Me.lblPartCost)
        Me.grpTotal.Controls.Add(Me.lblServices)
        Me.grpTotal.Controls.Add(Me.lblLaborCost)
        Me.grpTotal.Location = New System.Drawing.Point(13, 339)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(338, 164)
        Me.grpTotal.TabIndex = 5
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Total Fees"
        '
        'lblTotalFees
        '
        Me.lblTotalFees.AutoSize = True
        Me.lblTotalFees.Location = New System.Drawing.Point(53, 123)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalFees.TabIndex = 7
        Me.lblTotalFees.Text = "Total Fees"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(52, 90)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(72, 13)
        Me.lblTax.TabIndex = 6
        Me.lblTax.Text = "Tax (on parts)"
        '
        'lblPartsFees
        '
        Me.lblPartsFees.AutoSize = True
        Me.lblPartsFees.Location = New System.Drawing.Point(53, 59)
        Me.lblPartsFees.Name = "lblPartsFees"
        Me.lblPartsFees.Size = New System.Drawing.Size(31, 13)
        Me.lblPartsFees.TabIndex = 5
        Me.lblPartsFees.Text = "Parts"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(159, 120)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(88, 23)
        Me.lblTotalCost.TabIndex = 4
        '
        'lblTaxCost
        '
        Me.lblTaxCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxCost.Location = New System.Drawing.Point(159, 86)
        Me.lblTaxCost.Name = "lblTaxCost"
        Me.lblTaxCost.Size = New System.Drawing.Size(88, 23)
        Me.lblTaxCost.TabIndex = 3
        '
        'lblPartCost
        '
        Me.lblPartCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartCost.Location = New System.Drawing.Point(159, 55)
        Me.lblPartCost.Name = "lblPartCost"
        Me.lblPartCost.Size = New System.Drawing.Size(88, 23)
        Me.lblPartCost.TabIndex = 2
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Location = New System.Drawing.Point(53, 29)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(87, 13)
        Me.lblServices.TabIndex = 1
        Me.lblServices.Text = "Services && Labor"
        '
        'lblLaborCost
        '
        Me.lblLaborCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLaborCost.Location = New System.Drawing.Point(159, 24)
        Me.lblLaborCost.Name = "lblLaborCost"
        Me.lblLaborCost.Size = New System.Drawing.Size(88, 23)
        Me.lblLaborCost.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(57, 515)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 35)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate Total"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(157, 515)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(255, 515)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 560)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpTotal)
        Me.Controls.Add(Me.grpService)
        Me.Controls.Add(Me.grpMisc)
        Me.Controls.Add(Me.grpFlush)
        Me.Controls.Add(Me.grpOil)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Joes Automotive - Ch 6"
        Me.grpOil.ResumeLayout(False)
        Me.grpOil.PerformLayout()
        Me.grpFlush.ResumeLayout(False)
        Me.grpFlush.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.grpService.ResumeLayout(False)
        Me.grpService.PerformLayout()
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpOil As System.Windows.Forms.GroupBox
    Friend WithEvents chkLube As System.Windows.Forms.CheckBox
    Friend WithEvents chkOil As System.Windows.Forms.CheckBox
    Friend WithEvents grpFlush As System.Windows.Forms.GroupBox
    Friend WithEvents chkTrans As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadiator As System.Windows.Forms.CheckBox
    Friend WithEvents grpMisc As System.Windows.Forms.GroupBox
    Friend WithEvents chkTire As System.Windows.Forms.CheckBox
    Friend WithEvents chkMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkInspect As System.Windows.Forms.CheckBox
    Friend WithEvents grpService As System.Windows.Forms.GroupBox
    Friend WithEvents lblPart As System.Windows.Forms.Label
    Friend WithEvents lblLabor As System.Windows.Forms.Label
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtPart As System.Windows.Forms.TextBox
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblPartsFees As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTaxCost As System.Windows.Forms.Label
    Friend WithEvents lblPartCost As System.Windows.Forms.Label
    Friend WithEvents lblServices As System.Windows.Forms.Label
    Friend WithEvents lblLaborCost As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
