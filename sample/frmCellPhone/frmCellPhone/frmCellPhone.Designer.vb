<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCellPhone
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSelectPlan = New System.Windows.Forms.GroupBox()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblIndividual = New System.Windows.Forms.Label()
        Me.btnFamily = New System.Windows.Forms.Button()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSelectPlan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Blade Runner Movie Font", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GT Cell Phone Plans"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSelectPlan
        '
        Me.grpSelectPlan.Controls.Add(Me.lblFamily)
        Me.grpSelectPlan.Controls.Add(Me.lblIndividual)
        Me.grpSelectPlan.Controls.Add(Me.btnFamily)
        Me.grpSelectPlan.Controls.Add(Me.btnIndividual)
        Me.grpSelectPlan.Location = New System.Drawing.Point(32, 65)
        Me.grpSelectPlan.Name = "grpSelectPlan"
        Me.grpSelectPlan.Size = New System.Drawing.Size(317, 155)
        Me.grpSelectPlan.TabIndex = 1
        Me.grpSelectPlan.TabStop = False
        Me.grpSelectPlan.Text = "Select a Plan"
        '
        'lblFamily
        '
        Me.lblFamily.Location = New System.Drawing.Point(7, 84)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(173, 54)
        Me.lblFamily.TabIndex = 3
        Me.lblFamily.Text = "The Family plan allows you to purchase multiple cell phones of the same model, wi" & _
            "th each phone sharing one monthly package."
        '
        'lblIndividual
        '
        Me.lblIndividual.Location = New System.Drawing.Point(6, 20)
        Me.lblIndividual.Name = "lblIndividual"
        Me.lblIndividual.Size = New System.Drawing.Size(163, 45)
        Me.lblIndividual.TabIndex = 2
        Me.lblIndividual.Text = "The individual plan provides one cell phone and a variety of monthly packages."
        '
        'btnFamily
        '
        Me.btnFamily.Location = New System.Drawing.Point(199, 98)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(75, 23)
        Me.btnFamily.TabIndex = 1
        Me.btnFamily.Text = "Family"
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(199, 25)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(75, 23)
        Me.btnIndividual.TabIndex = 0
        Me.btnIndividual.Text = "Individual"
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(231, 235)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCellPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 270)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpSelectPlan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCellPhone"
        Me.Text = "Cell Phone Plans"
        Me.grpSelectPlan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpSelectPlan As System.Windows.Forms.GroupBox
    Friend WithEvents btnFamily As System.Windows.Forms.Button
    Friend WithEvents btnIndividual As System.Windows.Forms.Button
    Friend WithEvents lblFamily As System.Windows.Forms.Label
    Friend WithEvents lblIndividual As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
