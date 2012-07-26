Public Class frmIndividual

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        Dim decPhoneCost As Decimal 'Holds cost of phone models, depending on which one we click
        Dim decPackageCost As Decimal
        Dim decOptions As Decimal
        Dim decPhoneTotal As Decimal
        Dim decTotalMonthly As Decimal
        Dim gblnErrFlg As Boolean

        'Get and calculate phone model and charges
        If radIndModel100.Checked = True Then
            decPhoneCost = CalcPhoneSubtotal(1, 100) 'set number of phones to 1 since this is the individual form
        ElseIf radIndModel110.Checked = True Then
            decPhoneCost = CalcPhoneSubtotal(1, 110)
        ElseIf radIndModel200.Checked = True Then
            decPhoneCost = CalcPhoneSubtotal(1, 200)
        Else
            MsgBox("You must select a phone model")
        End If

        'get and calculate Package charges
        If radIndMin300.Checked = True Then
            decPackageCost = CalcPackageCharge(300)
            gblnErrFlg = False
        ElseIf radIndMin800.Checked = True Then
            decPackageCost = CalcPackageCharge(800)
            gblnErrFlg = False
        ElseIf radIndMin1500.Checked = True Then
            decPackageCost = CalcPackageCharge(1500)
            gblnErrFlg = False
        Else
            MsgBox("you must select a phone package")
            gblnErrFlg = True
        End If


        If gblnErrFlg = False Then 'calculate and display charges
            'Get and calculate options charges, if any
            If chkIndText.Checked = True And chkIndVoiceMail.Checked = False Then
                decOptions += CalcOptions(1, False, True)
            ElseIf chkIndText.Checked = False And chkIndVoiceMail.Checked = True Then
                decOptions += CalcOptions(1, True, False)
            ElseIf chkIndText.Checked = True And chkIndVoiceMail.Checked = True Then
                decOptions = CalcOptions(1, True, True)
            End If

            'Get and add phone total
            decPhoneTotal = CalcTax(decPhoneCost) + decPhoneCost

            'Add package cost and options cost to get total monthly payment
            decTotalMonthly = decPackageCost + decOptions

            'Display results
            lblIndSubTotal.Text = FormatCurrency(decPhoneCost)
            lblIndTax.Text = FormatCurrency(CalcTax(decPhoneCost))
            lblIndPhoneTotal.Text = FormatCurrency(decPhoneTotal)
            lblIndOptions.Text = FormatCurrency(decOptions)
            lblIndPackCharge.Text = FormatCurrency(CStr(decPackageCost))
            lblIndMonthCharge.Text = FormatCurrency(decTotalMonthly)

        End If
    End Sub
End Class