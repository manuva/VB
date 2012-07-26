Public Class frmRainfallStats
    Dim strMonths() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Dim intMonths(12) As Integer
    Dim intRain As Integer
    Const intMAX_MONTHS = 12

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        '---------------------------------Exits the program from button-------------------------------------------------------------------------

        Me.Close()

        '---------------------------------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click

        '---------------------------------Exits the program from file menu----------------------------------------------------------------------

        Me.Close()

        '------------------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileAbout.Click

        '----------------------------------Shows the ABOUT form when clicked-----------------------------------------------------

        Dim aboutInfo As New frmAbout
        aboutInfo.ShowDialog()

        '--------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        Dim intCount As Integer
        Dim intMaximum As Integer = intMonths(0)
        Dim intMinimum As Integer = intMonths(0)
        Dim dblAverage As Double
        Dim strMax, strMin As Integer
        Dim intTotal As Integer = 0


        'calculate maximum

        For intCount = 1 To (intMonths.Length - 1)
            If intMonths(intCount) > intMaximum Then
                intMaximum = intMonths(intCount)
                strMax = intCount
            End If

        Next intCount

        'calculate(minimum)
        For intCount = 1 To (strMonths.Length - 1)
            If intMonths(intCount) < intMinimum Then
                intMinimum = intMonths(intCount)
                strMin = intCount
            End If

        Next intCount

        'calculate Total and Average
        For intCount = 0 To (strMonths.Length - 1)
            intTotal += intMonths(intCount)
        Next intCount
        'use floating-point division to compute the average
        dblAverage = (intTotal / strMonths.Length)

        lblAverage.Text = "The average monthly rainfall was " & dblAverage.ToString("N2")
        lblAnnual.Text = "The total annual rainfall was " & intTotal
        lblMinimum.Text = "The minimum monthly rainfall was " & intMinimum & " (" & strMonths(strMin) & ")"
        lblMaximum.Text = "The maximum monthly rainfall was " & intMaximum & " (" & strMonths(strMax) & ")"



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        '---------------------Clear all the boxes on the form--------------------------------------------

        lblAnnual.Text = ""
        lblAverage.Text = ""
        lblMaximum.Text = ""
        lblMinimum.Text = ""
        lstRainfall.Items.Clear()


        '---------------------------------------------------------------------------------------------------


    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click

        Dim intCount As Integer 'loop counter
        Dim intRain As Integer 'Amount of rain

        lstRainfall.Items.Add("Monthly Rainfall")
        lstRainfall.Items.Add("-------------------------")

        'get the rain for each month
        For intCount = 0 To intMAX_MONTHS - 1
            intRain = CInt((InputBox("Enter the inches of rainfall for" & " " & strMonths(intCount))))
            Do Until intRain >= 0
                intRain = CInt(InputBox("Inches of rainfall must be a positive number, enter the inches of rainfall for " & " " & strMonths(intCount)))


                ' MsgBox("Rainfall must be a positive number, please enter the rainfall for the month of " & strMonths(intCount))
            Loop
            lstRainfall.Items.Add((intRain).ToString() & " for " & strMonths(intCount))
            intMonths(intCount) = intRain
        Next intCount




    End Sub


End Class