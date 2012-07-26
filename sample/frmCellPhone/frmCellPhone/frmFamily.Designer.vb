<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamily
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
        Me.chkText = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.chkVoiceMail = New System.Windows.Forms.CheckBox()
        Me.grpTotals = New System.Windows.Forms.GroupBox()
        Me.lblMonthCharge = New System.Windows.Forms.Label()
        Me.lblPackCharge = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblPhoneTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyChargeTxt = New System.Windows.Forms.Label()
        Me.lblPackageText = New System.Windows.Forms.Label()
        Me.lblOptionsTxt = New System.Windows.Forms.Label()
        Me.lblPhoneTotalTxt = New System.Windows.Forms.Label()
        Me.lblTaxTxt = New System.Windows.Forms.Label()
        Me.lblPhoneSubtxt = New System.Windows.Forms.Label()
        Me.grpSelectOptions = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.radMin300 = New System.Windows.Forms.RadioButton()
        Me.radMin800 = New System.Windows.Forms.RadioButton()
        Me.grpSelectPhone = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.radMin1500 = New System.Windows.Forms.RadioButton()
        Me.grpSelectPackage = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblNumOfPhones = New System.Windows.Forms.Label()
        Me.txtNumPhones = New System.Windows.Forms.TextBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.grpTotals.SuspendLayout()
        Me.grpSelectOptions.SuspendLayout()
        Me.grpSelectPhone.SuspendLayout()
        Me.grpSelectPackage.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkText
        '
        Me.chkText.AutoSize = True
        Me.chkText.Location = New System.Drawing.Point(7, 66)
        Me.chkText.Name = "chkText"
        Me.chkText.Size = New System.Drawing.Size(101, 17)
        Me.chkText.TabIndex = 1
        Me.chkText.Text = "Text Messaging"
        Me.chkText.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(175, 424)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'chkVoiceMail
        '
        Me.chkVoiceMail.AutoSize = True
        Me.chkVoiceMail.Location = New System.Drawing.Point(7, 31)
        Me.chkVoiceMail.Name = "chkVoiceMail"
        Me.chkVoiceMail.Size = New System.Drawing.Size(75, 17)
        Me.chkVoiceMail.TabIndex = 0
        Me.chkVoiceMail.Text = "Voice Mail"
        Me.chkVoiceMail.UseVisualStyleBackColor = True
        '
        'grpTotals
        '
        Me.grpTotals.Controls.Add(Me.lblMonthCharge)
        Me.grpTotals.Controls.Add(Me.lblPackCharge)
        Me.grpTotals.Controls.Add(Me.lblOptions)
        Me.grpTotals.Controls.Add(Me.lblPhoneTotal)
        Me.grpTotals.Controls.Add(Me.lblTax)
        Me.grpTotals.Controls.Add(Me.lblSubTotal)
        Me.grpTotals.Controls.Add(Me.lblMonthlyChargeTxt)
        Me.grpTotals.Controls.Add(Me.lblPackageText)
        Me.grpTotals.Controls.Add(Me.lblOptionsTxt)
        Me.grpTotals.Controls.Add(Me.lblPhoneTotalTxt)
        Me.grpTotals.Controls.Add(Me.lblTaxTxt)
        Me.grpTotals.Controls.Add(Me.lblPhoneSubtxt)
        Me.grpTotals.Location = New System.Drawing.Point(175, 187)
        Me.grpTotals.Name = "grpTotals"
        Me.grpTotals.Size = New System.Drawing.Size(200, 218)
        Me.grpTotals.TabIndex = 11
        Me.grpTotals.TabStop = False
        Me.grpTotals.Text = "Totals"
        '
        'lblMonthCharge
        '
        Me.lblMonthCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthCharge.Location = New System.Drawing.Point(120, 192)
        Me.lblMonthCharge.Name = "lblMonthCharge"
        Me.lblMonthCharge.Size = New System.Drawing.Size(70, 23)
        Me.lblMonthCharge.TabIndex = 11
        '
        'lblPackCharge
        '
        Me.lblPackCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackCharge.Location = New System.Drawing.Point(120, 157)
        Me.lblPackCharge.Name = "lblPackCharge"
        Me.lblPackCharge.Size = New System.Drawing.Size(70, 23)
        Me.lblPackCharge.TabIndex = 10
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(120, 122)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(70, 23)
        Me.lblOptions.TabIndex = 9
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneTotal.Location = New System.Drawing.Point(120, 85)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(70, 23)
        Me.lblPhoneTotal.TabIndex = 8
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(120, 52)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(70, 23)
        Me.lblTax.TabIndex = 7
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(120, 22)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(70, 23)
        Me.lblSubTotal.TabIndex = 6
        '
        'lblMonthlyChargeTxt
        '
        Me.lblMonthlyChargeTxt.Location = New System.Drawing.Point(6, 181)
        Me.lblMonthlyChargeTxt.Name = "lblMonthlyChargeTxt"
        Me.lblMonthlyChargeTxt.Size = New System.Drawing.Size(80, 34)
        Me.lblMonthlyChargeTxt.TabIndex = 5
        Me.lblMonthlyChargeTxt.Text = "Total Monthy Charge"
        Me.lblMonthlyChargeTxt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPackageText
        '
        Me.lblPackageText.AutoSize = True
        Me.lblPackageText.Location = New System.Drawing.Point(6, 157)
        Me.lblPackageText.Name = "lblPackageText"
        Me.lblPackageText.Size = New System.Drawing.Size(87, 13)
        Me.lblPackageText.TabIndex = 4
        Me.lblPackageText.Text = "Package Charge"
        '
        'lblOptionsTxt
        '
        Me.lblOptionsTxt.AutoSize = True
        Me.lblOptionsTxt.Location = New System.Drawing.Point(43, 124)
        Me.lblOptionsTxt.Name = "lblOptionsTxt"
        Me.lblOptionsTxt.Size = New System.Drawing.Size(43, 13)
        Me.lblOptionsTxt.TabIndex = 3
        Me.lblOptionsTxt.Text = "Options"
        '
        'lblPhoneTotalTxt
        '
        Me.lblPhoneTotalTxt.AutoSize = True
        Me.lblPhoneTotalTxt.Location = New System.Drawing.Point(22, 87)
        Me.lblPhoneTotalTxt.Name = "lblPhoneTotalTxt"
        Me.lblPhoneTotalTxt.Size = New System.Drawing.Size(65, 13)
        Me.lblPhoneTotalTxt.TabIndex = 2
        Me.lblPhoneTotalTxt.Text = "Phone Total"
        '
        'lblTaxTxt
        '
        Me.lblTaxTxt.AutoSize = True
        Me.lblTaxTxt.Location = New System.Drawing.Point(59, 52)
        Me.lblTaxTxt.Name = "lblTaxTxt"
        Me.lblTaxTxt.Size = New System.Drawing.Size(25, 13)
        Me.lblTaxTxt.TabIndex = 1
        Me.lblTaxTxt.Text = "Tax"
        '
        'lblPhoneSubtxt
        '
        Me.lblPhoneSubtxt.AutoSize = True
        Me.lblPhoneSubtxt.Location = New System.Drawing.Point(7, 25)
        Me.lblPhoneSubtxt.Name = "lblPhoneSubtxt"
        Me.lblPhoneSubtxt.Size = New System.Drawing.Size(80, 13)
        Me.lblPhoneSubtxt.TabIndex = 0
        Me.lblPhoneSubtxt.Text = "Phone Subtotal"
        '
        'grpSelectOptions
        '
        Me.grpSelectOptions.Controls.Add(Me.chkText)
        Me.grpSelectOptions.Controls.Add(Me.chkVoiceMail)
        Me.grpSelectOptions.Location = New System.Drawing.Point(12, 187)
        Me.grpSelectOptions.Name = "grpSelectOptions"
        Me.grpSelectOptions.Size = New System.Drawing.Size(157, 100)
        Me.grpSelectOptions.TabIndex = 10
        Me.grpSelectOptions.TabStop = False
        Me.grpSelectOptions.Text = "Select Options"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-43, -108)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(292, 28)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Individual Plan Selection List"
        '
        'radMin300
        '
        Me.radMin300.AutoSize = True
        Me.radMin300.Location = New System.Drawing.Point(23, 22)
        Me.radMin300.Name = "radMin300"
        Me.radMin300.Size = New System.Drawing.Size(118, 17)
        Me.radMin300.TabIndex = 0
        Me.radMin300.TabStop = True
        Me.radMin300.Text = "300 Minutes/Month"
        Me.radMin300.UseVisualStyleBackColor = True
        '
        'radMin800
        '
        Me.radMin800.AutoSize = True
        Me.radMin800.Location = New System.Drawing.Point(23, 47)
        Me.radMin800.Name = "radMin800"
        Me.radMin800.Size = New System.Drawing.Size(118, 17)
        Me.radMin800.TabIndex = 1
        Me.radMin800.TabStop = True
        Me.radMin800.Text = "800 Minutes/Month"
        Me.radMin800.UseVisualStyleBackColor = True
        '
        'grpSelectPhone
        '
        Me.grpSelectPhone.Controls.Add(Me.radModel200)
        Me.grpSelectPhone.Controls.Add(Me.radModel110)
        Me.grpSelectPhone.Controls.Add(Me.radModel100)
        Me.grpSelectPhone.Location = New System.Drawing.Point(12, 81)
        Me.grpSelectPhone.Name = "grpSelectPhone"
        Me.grpSelectPhone.Size = New System.Drawing.Size(157, 100)
        Me.grpSelectPhone.TabIndex = 8
        Me.grpSelectPhone.TabStop = False
        Me.grpSelectPhone.Text = "Select a Phone"
        '
        'radModel200
        '
        Me.radModel200.AutoSize = True
        Me.radModel200.Location = New System.Drawing.Point(7, 74)
        Me.radModel200.Name = "radModel200"
        Me.radModel200.Size = New System.Drawing.Size(75, 17)
        Me.radModel200.TabIndex = 2
        Me.radModel200.TabStop = True
        Me.radModel200.Text = "Model 200"
        Me.radModel200.UseVisualStyleBackColor = True
        '
        'radModel110
        '
        Me.radModel110.AutoSize = True
        Me.radModel110.Location = New System.Drawing.Point(7, 48)
        Me.radModel110.Name = "radModel110"
        Me.radModel110.Size = New System.Drawing.Size(75, 17)
        Me.radModel110.TabIndex = 1
        Me.radModel110.TabStop = True
        Me.radModel110.Text = "Model 110"
        Me.radModel110.UseVisualStyleBackColor = True
        '
        'radModel100
        '
        Me.radModel100.AutoSize = True
        Me.radModel100.Location = New System.Drawing.Point(7, 22)
        Me.radModel100.Name = "radModel100"
        Me.radModel100.Size = New System.Drawing.Size(75, 17)
        Me.radModel100.TabIndex = 0
        Me.radModel100.TabStop = True
        Me.radModel100.Text = "Model 100"
        Me.radModel100.UseVisualStyleBackColor = True
        '
        'radMin1500
        '
        Me.radMin1500.AutoSize = True
        Me.radMin1500.Location = New System.Drawing.Point(23, 73)
        Me.radMin1500.Name = "radMin1500"
        Me.radMin1500.Size = New System.Drawing.Size(124, 17)
        Me.radMin1500.TabIndex = 2
        Me.radMin1500.TabStop = True
        Me.radMin1500.Text = "1500 Minutes/Month"
        Me.radMin1500.UseVisualStyleBackColor = True
        '
        'grpSelectPackage
        '
        Me.grpSelectPackage.Controls.Add(Me.radMin1500)
        Me.grpSelectPackage.Controls.Add(Me.radMin800)
        Me.grpSelectPackage.Controls.Add(Me.radMin300)
        Me.grpSelectPackage.Location = New System.Drawing.Point(175, 81)
        Me.grpSelectPackage.Name = "grpSelectPackage"
        Me.grpSelectPackage.Size = New System.Drawing.Size(200, 100)
        Me.grpSelectPackage.TabIndex = 9
        Me.grpSelectPackage.TabStop = False
        Me.grpSelectPackage.Text = "Select a Package"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(290, 424)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily.Location = New System.Drawing.Point(12, 13)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(265, 28)
        Me.lblFamily.TabIndex = 14
        Me.lblFamily.Text = "Family Plan Selection List"
        '
        'lblNumOfPhones
        '
        Me.lblNumOfPhones.AutoSize = True
        Me.lblNumOfPhones.Location = New System.Drawing.Point(19, 53)
        Me.lblNumOfPhones.Name = "lblNumOfPhones"
        Me.lblNumOfPhones.Size = New System.Drawing.Size(95, 13)
        Me.lblNumOfPhones.TabIndex = 15
        Me.lblNumOfPhones.Text = "Number of Phones"
        '
        'txtNumPhones
        '
        Me.txtNumPhones.Location = New System.Drawing.Point(121, 51)
        Me.txtNumPhones.Name = "txtNumPhones"
        Me.txtNumPhones.Size = New System.Drawing.Size(32, 20)
        Me.txtNumPhones.TabIndex = 16
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLogo.Image = Global.frmCellPhone.My.Resources.Resources.gtlogo
        Me.pbLogo.InitialImage = Nothing
        Me.pbLogo.Location = New System.Drawing.Point(12, 293)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(141, 135)
        Me.pbLogo.TabIndex = 17
        Me.pbLogo.TabStop = False
        '
        'frmFamily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 469)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.txtNumPhones)
        Me.Controls.Add(Me.lblNumOfPhones)
        Me.Controls.Add(Me.lblFamily)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpTotals)
        Me.Controls.Add(Me.grpSelectOptions)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpSelectPhone)
        Me.Controls.Add(Me.grpSelectPackage)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmFamily"
        Me.Text = "Family Cell Phone Plans"
        Me.grpTotals.ResumeLayout(False)
        Me.grpTotals.PerformLayout()
        Me.grpSelectOptions.ResumeLayout(False)
        Me.grpSelectOptions.PerformLayout()
        Me.grpSelectPhone.ResumeLayout(False)
        Me.grpSelectPhone.PerformLayout()
        Me.grpSelectPackage.ResumeLayout(False)
        Me.grpSelectPackage.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkText As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents chkVoiceMail As System.Windows.Forms.CheckBox
    Friend WithEvents grpTotals As System.Windows.Forms.GroupBox
    Friend WithEvents lblMonthCharge As System.Windows.Forms.Label
    Friend WithEvents lblPackCharge As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblPhoneTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyChargeTxt As System.Windows.Forms.Label
    Friend WithEvents lblPackageText As System.Windows.Forms.Label
    Friend WithEvents lblOptionsTxt As System.Windows.Forms.Label
    Friend WithEvents lblPhoneTotalTxt As System.Windows.Forms.Label
    Friend WithEvents lblTaxTxt As System.Windows.Forms.Label
    Friend WithEvents lblPhoneSubtxt As System.Windows.Forms.Label
    Friend WithEvents grpSelectOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents radMin300 As System.Windows.Forms.RadioButton
    Friend WithEvents radMin800 As System.Windows.Forms.RadioButton
    Friend WithEvents grpSelectPhone As System.Windows.Forms.GroupBox
    Friend WithEvents radModel200 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel110 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel100 As System.Windows.Forms.RadioButton
    Friend WithEvents radMin1500 As System.Windows.Forms.RadioButton
    Friend WithEvents grpSelectPackage As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblFamily As System.Windows.Forms.Label
    Friend WithEvents lblNumOfPhones As System.Windows.Forms.Label
    Friend WithEvents txtNumPhones As System.Windows.Forms.TextBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
End Class
