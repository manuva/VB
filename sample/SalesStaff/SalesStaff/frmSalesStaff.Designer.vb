<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesStaff
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
        Me.dgvSalesStaff = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New SalesStaff.CompanyDataSet()
        Me.radFullTime = New System.Windows.Forms.RadioButton()
        Me.radPartTime = New System.Windows.Forms.RadioButton()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.SalesStaffTableAdapter = New SalesStaff.CompanyDataSetTableAdapters.SalesStaffTableAdapter()
        Me.TableAdapterManager = New SalesStaff.CompanyDataSetTableAdapters.TableAdapterManager()
        Me.lblEmploymentStatus = New System.Windows.Forms.Label()
        Me.lblAverageSalary = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvSalesStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSalesStaff
        '
        Me.dgvSalesStaff.AllowUserToAddRows = False
        Me.dgvSalesStaff.AllowUserToDeleteRows = False
        Me.dgvSalesStaff.AutoGenerateColumns = False
        Me.dgvSalesStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvSalesStaff.DataSource = Me.SalesStaffBindingSource
        Me.dgvSalesStaff.Location = New System.Drawing.Point(0, 185)
        Me.dgvSalesStaff.Name = "dgvSalesStaff"
        Me.dgvSalesStaff.Size = New System.Drawing.Size(357, 234)
        Me.dgvSalesStaff.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Salary"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'radFullTime
        '
        Me.radFullTime.AutoSize = True
        Me.radFullTime.Checked = True
        Me.radFullTime.Location = New System.Drawing.Point(162, 85)
        Me.radFullTime.Name = "radFullTime"
        Me.radFullTime.Size = New System.Drawing.Size(67, 17)
        Me.radFullTime.TabIndex = 2
        Me.radFullTime.TabStop = True
        Me.radFullTime.Text = "Full Time"
        Me.radFullTime.UseVisualStyleBackColor = True
        '
        'radPartTime
        '
        Me.radPartTime.AutoSize = True
        Me.radPartTime.Location = New System.Drawing.Point(235, 85)
        Me.radPartTime.Name = "radPartTime"
        Me.radPartTime.Size = New System.Drawing.Size(70, 17)
        Me.radPartTime.TabIndex = 3
        Me.radPartTime.Text = "Part Time"
        Me.radPartTime.UseVisualStyleBackColor = True
        '
        'lblSalary
        '
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalary.Location = New System.Drawing.Point(162, 121)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(110, 21)
        Me.lblSalary.TabIndex = 4
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SalesStaff.CompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblEmploymentStatus
        '
        Me.lblEmploymentStatus.AutoSize = True
        Me.lblEmploymentStatus.Location = New System.Drawing.Point(12, 89)
        Me.lblEmploymentStatus.Name = "lblEmploymentStatus"
        Me.lblEmploymentStatus.Size = New System.Drawing.Size(133, 13)
        Me.lblEmploymentStatus.TabIndex = 5
        Me.lblEmploymentStatus.Text = "Select Employment Status:"
        '
        'lblAverageSalary
        '
        Me.lblAverageSalary.AutoSize = True
        Me.lblAverageSalary.Location = New System.Drawing.Point(63, 122)
        Me.lblAverageSalary.Name = "lblAverageSalary"
        Me.lblAverageSalary.Size = New System.Drawing.Size(82, 13)
        Me.lblAverageSalary.TabIndex = 6
        Me.lblAverageSalary.Text = "Average Salary:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sales Staff Salary Average"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(358, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileAbout, Me.ToolStripSeparator1, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuFileAbout
        '
        Me.mnuFileAbout.Name = "mnuFileAbout"
        Me.mnuFileAbout.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuFileAbout.Size = New System.Drawing.Size(181, 22)
        Me.mnuFileAbout.Text = "&About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(181, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'frmSalesStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAverageSalary)
        Me.Controls.Add(Me.lblEmploymentStatus)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.radPartTime)
        Me.Controls.Add(Me.radFullTime)
        Me.Controls.Add(Me.dgvSalesStaff)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSalesStaff"
        Me.Text = "Sales Staff Salary Average"
        CType(Me.dgvSalesStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompanyDataSet As SalesStaff.CompanyDataSet
    Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffTableAdapter As SalesStaff.CompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents TableAdapterManager As SalesStaff.CompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvSalesStaff As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents radFullTime As System.Windows.Forms.RadioButton
    Friend WithEvents radPartTime As System.Windows.Forms.RadioButton
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblEmploymentStatus As System.Windows.Forms.Label
    Friend WithEvents lblAverageSalary As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem

End Class
