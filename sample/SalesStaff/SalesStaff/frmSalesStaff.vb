Public Class frmSalesStaff
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        'Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)
        Dim row As CompanyDataSet.SalesStaffRow
        Dim dblTotal As Double = 0
        Dim dblAverage As Double = 0
        Dim intNameCount As Integer = Me.BindingContext(CompanyDataSet.SalesStaff).Count



        'iterate through the salary row and add each salary to total
        For Each row In Me.CompanyDataSet.SalesStaff.Rows
            dblTotal += row.Salary
        Next row

        dblAverage = dblTotal / intNameCount

        lblSalary.Text = FormatCurrency(dblAverage)

    End Sub

    Private Sub radFullTime_CheckedChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFullTime.CheckedChanged
        FullTime()
    End Sub

    Private Sub radPartTime_CheckedChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPartTime.CheckedChanged
        PartTime()
    End Sub



    Sub FullTime()

        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

        Dim row As CompanyDataSet.SalesStaffRow 'for iterating through the salary rows
        Dim dblTotal As Double = 0 'hold total of salaries
        Dim dblAverage As Double = 0 'hold average salary
        Dim intNameCount As Integer = Me.BindingContext(CompanyDataSet.SalesStaff).Count 'to count the total names


        For Each row In Me.CompanyDataSet.SalesStaff.Rows
            dblTotal += row.Salary
        Next row

        dblAverage = dblTotal / intNameCount

        lblSalary.Text = FormatCurrency(dblAverage)


    End Sub

    Sub PartTime()

        Me.SalesStaffTableAdapter.FillByPartTime(Me.CompanyDataSet.SalesStaff)

        Dim row As CompanyDataSet.SalesStaffRow 'for iterating through the salary rows
        Dim dblTotal As Double = 0 'hold total of salaries
        Dim dblAverage As Double = 0 'hold average salary
        Dim intNameCount As Integer = Me.BindingContext(CompanyDataSet.SalesStaff).Count 'to count the total names


        For Each row In Me.CompanyDataSet.SalesStaff.Rows
            dblTotal += row.Salary
        Next row

        dblAverage = dblTotal / intNameCount

        lblSalary.Text = FormatCurrency(dblAverage)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close() 'exit the form
    End Sub

    Private Sub mnuFileAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileAbout.Click
        MessageBox.Show("Sales Staff Salaries" & vbNewLine & vbNewLine & _
                        "This program loads data from an access file and displays the average salary based on Full-Time Employment and Part Time Employment")
    End Sub
End Class