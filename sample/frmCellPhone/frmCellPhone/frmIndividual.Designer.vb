<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividual
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
        Me.lblIndividual = New System.Windows.Forms.Label()
        Me.grpIndSelectPhone = New System.Windows.Forms.GroupBox()
        Me.radIndModel200 = New System.Windows.Forms.RadioButton()
        Me.radIndModel110 = New System.Windows.Forms.RadioButton()
        Me.radIndModel100 = New System.Windows.Forms.RadioButton()
        Me.grpIndSelectPackage = New System.Windows.Forms.GroupBox()
        Me.radIndMin1500 = New System.Windows.Forms.RadioButton()
        Me.radIndMin800 = New System.Windows.Forms.RadioButton()
        Me.radIndMin300 = New System.Windows.Forms.RadioButton()
        Me.grpIndSelectOptions = New System.Windows.Forms.GroupBox()
        Me.chkIndText = New System.Windows.Forms.CheckBox()
        Me.chkIndVoiceMail = New System.Windows.Forms.CheckBox()
        Me.grpIndTotals = New System.Windows.Forms.GroupBox()
        Me.lblIndMonthCharge = New System.Windows.Forms.Label()
        Me.lblIndPackCharge = New System.Windows.Forms.Label()
        Me.lblIndOptions = New System.Windows.Forms.Label()
        Me.lblIndPhoneTotal = New System.Windows.Forms.Label()
        Me.lblIndTax = New System.Windows.Forms.Label()
        Me.lblIndSubTotal = New System.Windows.Forms.Label()
        Me.lblIndMonthlyChargeTxt = New System.Windows.Forms.Label()
        Me.lblIndPackageText = New System.Windows.Forms.Label()
        Me.lblIndOptionsTxt = New System.Windows.Forms.Label()
        Me.lblIndPhoneTotalTxt = New System.Windows.Forms.Label()
        Me.lblIndTaxTxt = New System.Windows.Forms.Label()
        Me.lblIndPhoneSubtxt = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.grpIndSelectPhone.SuspendLayout()
        Me.grpIndSelectPackage.SuspendLayout()
        Me.grpIndSelectOptions.SuspendLayout()
        Me.grpIndTotals.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIndividual
        '
        Me.lblIndividual.AutoSize = True
        Me.lblIndividual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndividual.Location = New System.Drawing.Point(12, 9)
        Me.lblIndividual.Name = "lblIndividual"
        Me.lblIndividual.Size = New System.Drawing.Size(292, 28)
        Me.lblIndividual.TabIndex = 0
        Me.lblIndividual.Text = "Individual Plan Selection List"
        '
        'grpIndSelectPhone
        '
        Me.grpIndSelectPhone.Controls.Add(Me.radIndModel200)
        Me.grpIndSelectPhone.Controls.Add(Me.radIndModel110)
        Me.grpIndSelectPhone.Controls.Add(Me.radIndModel100)
        Me.grpIndSelectPhone.Location = New System.Drawing.Point(12, 73)
        Me.grpIndSelectPhone.Name = "grpIndSelectPhone"
        Me.grpIndSelectPhone.Size = New System.Drawing.Size(157, 100)
        Me.grpIndSelectPhone.TabIndex = 1
        Me.grpIndSelectPhone.TabStop = False
        Me.grpIndSelectPhone.Text = "Select a Phone"
        '
        'radIndModel200
        '
        Me.radIndModel200.AutoSize = True
        Me.radIndModel200.Location = New System.Drawing.Point(7, 74)
        Me.radIndModel200.Name = "radIndModel200"
        Me.radIndModel200.Size = New System.Drawing.Size(75, 17)
        Me.radIndModel200.TabIndex = 2
        Me.radIndModel200.TabStop = True
        Me.radIndModel200.Text = "Model 200"
        Me.radIndModel200.UseVisualStyleBackColor = True
        '
        'radIndModel110
        '
        Me.radIndModel110.AutoSize = True
        Me.radIndModel110.Location = New System.Drawing.Point(7, 48)
        Me.radIndModel110.Name = "radIndModel110"
        Me.radIndModel110.Size = New System.Drawing.Size(75, 17)
        Me.radIndModel110.TabIndex = 1
        Me.radIndModel110.TabStop = True
        Me.radIndModel110.Text = "Model 110"
        Me.radIndModel110.UseVisualStyleBackColor = True
        '
        'radIndModel100
        '
        Me.radIndModel100.AutoSize = True
        Me.radIndModel100.Location = New System.Drawing.Point(7, 22)
        Me.radIndModel100.Name = "radIndModel100"
        Me.radIndModel100.Size = New System.Drawing.Size(75, 17)
        Me.radIndModel100.TabIndex = 0
        Me.radIndModel100.TabStop = True
        Me.radIndModel100.Text = "Model 100"
        Me.radIndModel100.UseVisualStyleBackColor = True
        '
        'grpIndSelectPackage
        '
        Me.grpIndSelectPackage.Controls.Add(Me.radIndMin1500)
        Me.grpIndSelectPackage.Controls.Add(Me.radIndMin800)
        Me.grpIndSelectPackage.Controls.Add(Me.radIndMin300)
        Me.grpIndSelectPackage.Location = New System.Drawing.Point(182, 73)
        Me.grpIndSelectPackage.Name = "grpIndSelectPackage"
        Me.grpIndSelectPackage.Size = New System.Drawing.Size(200, 100)
        Me.grpIndSelectPackage.TabIndex = 2
        Me.grpIndSelectPackage.TabStop = False
        Me.grpIndSelectPackage.Text = "Select a Package"
        '
        'radIndMin1500
        '
        Me.radIndMin1500.AutoSize = True
        Me.radIndMin1500.Location = New System.Drawing.Point(23, 73)
        Me.radIndMin1500.Name = "radIndMin1500"
        Me.radIndMin1500.Size = New System.Drawing.Size(124, 17)
        Me.radIndMin1500.TabIndex = 2
        Me.radIndMin1500.TabStop = True
        Me.radIndMin1500.Text = "1500 Minutes/Month"
        Me.radIndMin1500.UseVisualStyleBackColor = True
        '
        'radIndMin800
        '
        Me.radIndMin800.AutoSize = True
        Me.radIndMin800.Location = New System.Drawing.Point(23, 47)
        Me.radIndMin800.Name = "radIndMin800"
        Me.radIndMin800.Size = New System.Drawing.Size(118, 17)
        Me.radIndMin800.TabIndex = 1
        Me.radIndMin800.TabStop = True
        Me.radIndMin800.Text = "800 Minutes/Month"
        Me.radIndMin800.UseVisualStyleBackColor = True
        '
        'radIndMin300
        '
        Me.radIndMin300.AutoSize = True
        Me.radIndMin300.Location = New System.Drawing.Point(23, 22)
        Me.radIndMin300.Name = "radIndMin300"
        Me.radIndMin300.Size = New System.Drawing.Size(118, 17)
        Me.radIndMin300.TabIndex = 0
        Me.radIndMin300.TabStop = True
        Me.radIndMin300.Text = "300 Minutes/Month"
        Me.radIndMin300.UseVisualStyleBackColor = True
        '
        'grpIndSelectOptions
        '
        Me.grpIndSelectOptions.Controls.Add(Me.chkIndText)
        Me.grpIndSelectOptions.Controls.Add(Me.chkIndVoiceMail)
        Me.grpIndSelectOptions.Location = New System.Drawing.Point(12, 199)
        Me.grpIndSelectOptions.Name = "grpIndSelectOptions"
        Me.grpIndSelectOptions.Size = New System.Drawing.Size(157, 100)
        Me.grpIndSelectOptions.TabIndex = 3
        Me.grpIndSelectOptions.TabStop = False
        Me.grpIndSelectOptions.Text = "Select Options"
        '
        'chkIndText
        '
        Me.chkIndText.AutoSize = True
        Me.chkIndText.Location = New System.Drawing.Point(7, 66)
        Me.chkIndText.Name = "chkIndText"
        Me.chkIndText.Size = New System.Drawing.Size(101, 17)
        Me.chkIndText.TabIndex = 1
        Me.chkIndText.Text = "Text Messaging"
        Me.chkIndText.UseVisualStyleBackColor = True
        '
        'chkIndVoiceMail
        '
        Me.chkIndVoiceMail.AutoSize = True
        Me.chkIndVoiceMail.Location = New System.Drawing.Point(7, 31)
        Me.chkIndVoiceMail.Name = "chkIndVoiceMail"
        Me.chkIndVoiceMail.Size = New System.Drawing.Size(75, 17)
        Me.chkIndVoiceMail.TabIndex = 0
        Me.chkIndVoiceMail.Text = "Voice Mail"
        Me.chkIndVoiceMail.UseVisualStyleBackColor = True
        '
        'grpIndTotals
        '
        Me.grpIndTotals.Controls.Add(Me.lblIndMonthCharge)
        Me.grpIndTotals.Controls.Add(Me.lblIndPackCharge)
        Me.grpIndTotals.Controls.Add(Me.lblIndOptions)
        Me.grpIndTotals.Controls.Add(Me.lblIndPhoneTotal)
        Me.grpIndTotals.Controls.Add(Me.lblIndTax)
        Me.grpIndTotals.Controls.Add(Me.lblIndSubTotal)
        Me.grpIndTotals.Controls.Add(Me.lblIndMonthlyChargeTxt)
        Me.grpIndTotals.Controls.Add(Me.lblIndPackageText)
        Me.grpIndTotals.Controls.Add(Me.lblIndOptionsTxt)
        Me.grpIndTotals.Controls.Add(Me.lblIndPhoneTotalTxt)
        Me.grpIndTotals.Controls.Add(Me.lblIndTaxTxt)
        Me.grpIndTotals.Controls.Add(Me.lblIndPhoneSubtxt)
        Me.grpIndTotals.Location = New System.Drawing.Point(182, 199)
        Me.grpIndTotals.Name = "grpIndTotals"
        Me.grpIndTotals.Size = New System.Drawing.Size(200, 218)
        Me.grpIndTotals.TabIndex = 4
        Me.grpIndTotals.TabStop = False
        Me.grpIndTotals.Text = "Totals"
        '
        'lblIndMonthCharge
        '
        Me.lblIndMonthCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndMonthCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndMonthCharge.Location = New System.Drawing.Point(120, 192)
        Me.lblIndMonthCharge.Name = "lblIndMonthCharge"
        Me.lblIndMonthCharge.Size = New System.Drawing.Size(70, 23)
        Me.lblIndMonthCharge.TabIndex = 11
        '
        'lblIndPackCharge
        '
        Me.lblIndPackCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndPackCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndPackCharge.Location = New System.Drawing.Point(120, 157)
        Me.lblIndPackCharge.Name = "lblIndPackCharge"
        Me.lblIndPackCharge.Size = New System.Drawing.Size(70, 23)
        Me.lblIndPackCharge.TabIndex = 10
        '
        'lblIndOptions
        '
        Me.lblIndOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndOptions.Location = New System.Drawing.Point(120, 122)
        Me.lblIndOptions.Name = "lblIndOptions"
        Me.lblIndOptions.Size = New System.Drawing.Size(70, 23)
        Me.lblIndOptions.TabIndex = 9
        '
        'lblIndPhoneTotal
        '
        Me.lblIndPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndPhoneTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndPhoneTotal.Location = New System.Drawing.Point(120, 85)
        Me.lblIndPhoneTotal.Name = "lblIndPhoneTotal"
        Me.lblIndPhoneTotal.Size = New System.Drawing.Size(70, 23)
        Me.lblIndPhoneTotal.TabIndex = 8
        '
        'lblIndTax
        '
        Me.lblIndTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndTax.Location = New System.Drawing.Point(120, 52)
        Me.lblIndTax.Name = "lblIndTax"
        Me.lblIndTax.Size = New System.Drawing.Size(70, 23)
        Me.lblIndTax.TabIndex = 7
        '
        'lblIndSubTotal
        '
        Me.lblIndSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndSubTotal.Location = New System.Drawing.Point(120, 22)
        Me.lblIndSubTotal.Name = "lblIndSubTotal"
        Me.lblIndSubTotal.Size = New System.Drawing.Size(70, 23)
        Me.lblIndSubTotal.TabIndex = 6
        '
        'lblIndMonthlyChargeTxt
        '
        Me.lblIndMonthlyChargeTxt.Location = New System.Drawing.Point(6, 181)
        Me.lblIndMonthlyChargeTxt.Name = "lblIndMonthlyChargeTxt"
        Me.lblIndMonthlyChargeTxt.Size = New System.Drawing.Size(80, 34)
        Me.lblIndMonthlyChargeTxt.TabIndex = 5
        Me.lblIndMonthlyChargeTxt.Text = "Total Monthy Charge"
        Me.lblIndMonthlyChargeTxt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIndPackageText
        '
        Me.lblIndPackageText.AutoSize = True
        Me.lblIndPackageText.Location = New System.Drawing.Point(6, 157)
        Me.lblIndPackageText.Name = "lblIndPackageText"
        Me.lblIndPackageText.Size = New System.Drawing.Size(87, 13)
        Me.lblIndPackageText.TabIndex = 4
        Me.lblIndPackageText.Text = "Package Charge"
        '
        'lblIndOptionsTxt
        '
        Me.lblIndOptionsTxt.AutoSize = True
        Me.lblIndOptionsTxt.Location = New System.Drawing.Point(43, 124)
        Me.lblIndOptionsTxt.Name = "lblIndOptionsTxt"
        Me.lblIndOptionsTxt.Size = New System.Drawing.Size(43, 13)
        Me.lblIndOptionsTxt.TabIndex = 3
        Me.lblIndOptionsTxt.Text = "Options"
        '
        'lblIndPhoneTotalTxt
        '
        Me.lblIndPhoneTotalTxt.AutoSize = True
        Me.lblIndPhoneTotalTxt.Location = New System.Drawing.Point(22, 87)
        Me.lblIndPhoneTotalTxt.Name = "lblIndPhoneTotalTxt"
        Me.lblIndPhoneTotalTxt.Size = New System.Drawing.Size(65, 13)
        Me.lblIndPhoneTotalTxt.TabIndex = 2
        Me.lblIndPhoneTotalTxt.Text = "Phone Total"
        '
        'lblIndTaxTxt
        '
        Me.lblIndTaxTxt.AutoSize = True
        Me.lblIndTaxTxt.Location = New System.Drawing.Point(59, 52)
        Me.lblIndTaxTxt.Name = "lblIndTaxTxt"
        Me.lblIndTaxTxt.Size = New System.Drawing.Size(25, 13)
        Me.lblIndTaxTxt.TabIndex = 1
        Me.lblIndTaxTxt.Text = "Tax"
        '
        'lblIndPhoneSubtxt
        '
        Me.lblIndPhoneSubtxt.AutoSize = True
        Me.lblIndPhoneSubtxt.Location = New System.Drawing.Point(7, 25)
        Me.lblIndPhoneSubtxt.Name = "lblIndPhoneSubtxt"
        Me.lblIndPhoneSubtxt.Size = New System.Drawing.Size(80, 13)
        Me.lblIndPhoneSubtxt.TabIndex = 0
        Me.lblIndPhoneSubtxt.Text = "Phone Subtotal"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(192, 433)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(297, 433)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLogo.Image = Global.frmCellPhone.My.Resources.Resources.gtlogo
        Me.pbLogo.InitialImage = Nothing
        Me.pbLogo.Location = New System.Drawing.Point(12, 321)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(143, 135)
        Me.pbLogo.TabIndex = 7
        Me.pbLogo.TabStop = False
        '
        'frmIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 480)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpIndTotals)
        Me.Controls.Add(Me.grpIndSelectOptions)
        Me.Controls.Add(Me.grpIndSelectPackage)
        Me.Controls.Add(Me.grpIndSelectPhone)
        Me.Controls.Add(Me.lblIndividual)
        Me.Name = "frmIndividual"
        Me.Text = "Individual Plan"
        Me.grpIndSelectPhone.ResumeLayout(False)
        Me.grpIndSelectPhone.PerformLayout()
        Me.grpIndSelectPackage.ResumeLayout(False)
        Me.grpIndSelectPackage.PerformLayout()
        Me.grpIndSelectOptions.ResumeLayout(False)
        Me.grpIndSelectOptions.PerformLayout()
        Me.grpIndTotals.ResumeLayout(False)
        Me.grpIndTotals.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIndividual As System.Windows.Forms.Label
    Friend WithEvents grpIndSelectPhone As System.Windows.Forms.GroupBox
    Friend WithEvents grpIndSelectPackage As System.Windows.Forms.GroupBox
    Friend WithEvents grpIndSelectOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkIndText As System.Windows.Forms.CheckBox
    Friend WithEvents chkIndVoiceMail As System.Windows.Forms.CheckBox
    Friend WithEvents grpIndTotals As System.Windows.Forms.GroupBox
    Friend WithEvents radIndModel200 As System.Windows.Forms.RadioButton
    Friend WithEvents radIndModel110 As System.Windows.Forms.RadioButton
    Friend WithEvents radIndModel100 As System.Windows.Forms.RadioButton
    Friend WithEvents radIndMin1500 As System.Windows.Forms.RadioButton
    Friend WithEvents radIndMin800 As System.Windows.Forms.RadioButton
    Friend WithEvents radIndMin300 As System.Windows.Forms.RadioButton
    Friend WithEvents lblIndMonthCharge As System.Windows.Forms.Label
    Friend WithEvents lblIndPackCharge As System.Windows.Forms.Label
    Friend WithEvents lblIndOptions As System.Windows.Forms.Label
    Friend WithEvents lblIndPhoneTotal As System.Windows.Forms.Label
    Friend WithEvents lblIndTax As System.Windows.Forms.Label
    Friend WithEvents lblIndSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblIndMonthlyChargeTxt As System.Windows.Forms.Label
    Friend WithEvents lblIndPackageText As System.Windows.Forms.Label
    Friend WithEvents lblIndOptionsTxt As System.Windows.Forms.Label
    Friend WithEvents lblIndPhoneTotalTxt As System.Windows.Forms.Label
    Friend WithEvents lblIndTaxTxt As System.Windows.Forms.Label
    Friend WithEvents lblIndPhoneSubtxt As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
End Class
