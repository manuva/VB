<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKarateMemberDates
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
        Me.radBefore = New System.Windows.Forms.RadioButton()
        Me.radAfter = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.MembersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsKarate = New KarateMembers.dsKarate()
        Me.MembersTableAdapter = New KarateMembers.dsKarateTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New KarateMembers.dsKarateTableAdapters.TableAdapterManager()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBorderBox = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblView = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsKarate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radBefore
        '
        Me.radBefore.AutoSize = True
        Me.radBefore.Checked = True
        Me.radBefore.Location = New System.Drawing.Point(172, 126)
        Me.radBefore.Name = "radBefore"
        Me.radBefore.Size = New System.Drawing.Size(99, 17)
        Me.radBefore.TabIndex = 0
        Me.radBefore.TabStop = True
        Me.radBefore.Text = "Before this date"
        Me.radBefore.UseVisualStyleBackColor = True
        '
        'radAfter
        '
        Me.radAfter.AutoSize = True
        Me.radAfter.Location = New System.Drawing.Point(277, 126)
        Me.radAfter.Name = "radAfter"
        Me.radAfter.Size = New System.Drawing.Size(118, 17)
        Me.radAfter.TabIndex = 1
        Me.radAfter.Text = "On or after this date"
        Me.radAfter.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(116, 85)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(99, 20)
        Me.dtpDate.TabIndex = 2
        '
        'MembersDataGridView
        '
        Me.MembersDataGridView.AllowUserToAddRows = False
        Me.MembersDataGridView.AllowUserToDeleteRows = False
        Me.MembersDataGridView.AutoGenerateColumns = False
        Me.MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MembersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MembersDataGridView.DataSource = Me.MembersBindingSource
        Me.MembersDataGridView.Location = New System.Drawing.Point(12, 182)
        Me.MembersDataGridView.Name = "MembersDataGridView"
        Me.MembersDataGridView.ReadOnly = True
        Me.MembersDataGridView.Size = New System.Drawing.Size(447, 228)
        Me.MembersDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date_Joined"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date_Joined"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.DsKarate
        '
        'DsKarate
        '
        Me.DsKarate.DataSetName = "dsKarate"
        Me.DsKarate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KarateMembers.dsKarateTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(445, 46)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Karate Kid Members Section"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorderBox
        '
        Me.lblBorderBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBorderBox.Location = New System.Drawing.Point(12, 70)
        Me.lblBorderBox.Name = "lblBorderBox"
        Me.lblBorderBox.Size = New System.Drawing.Size(445, 90)
        Me.lblBorderBox.TabIndex = 6
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(28, 92)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(73, 13)
        Me.lblSelect.TabIndex = 7
        Me.lblSelect.Text = "Select a date:"
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Location = New System.Drawing.Point(28, 130)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(138, 13)
        Me.lblView.TabIndex = 8
        Me.lblView.Text = "View members who joined..."
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(196, 421)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmKarateMemberDates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 456)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MembersDataGridView)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.radAfter)
        Me.Controls.Add(Me.radBefore)
        Me.Controls.Add(Me.lblBorderBox)
        Me.Name = "frmKarateMemberDates"
        Me.Text = "Karate Member Dates"
        CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsKarate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radBefore As System.Windows.Forms.RadioButton
    Friend WithEvents radAfter As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsKarate As KarateMembers.dsKarate
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As KarateMembers.dsKarateTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As KarateMembers.dsKarateTableAdapters.TableAdapterManager
    Friend WithEvents MembersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblBorderBox As System.Windows.Forms.Label
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents lblView As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
