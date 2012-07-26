Public Class frmFamily

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim decPhoneCost As Decimal 'Holds cost of phone models, depending on which one we click
        Dim decPackageCost As Decimal
        Dim decOptions As Decimal
        Dim decPhoneTotal As Decimal
        Dim decTotalMonthly As Decimal
        Dim gblnErrFlg As Boolean
        Dim intNumPhones As Integer

        'Get and calculate phone model and charges
        If txtNumPhones.Text.Trim.Length > 0 Then
            If IsNumeric(txtNumPhones.Text.Trim) = True Then
                intNumPhones = CInt(txtNumPhones.Text.Trim)
                If intNumPhones > 0 Then
                Else
                    MsgBox("Number of phones must be a positive number or at least 1")
                    If gblnErrFlg = False Then
                        gblnErrFlg = True
                        txtNumPhones.SelectAll()
                        txtNumPhones.Focus()
                    End If
                End If
            Else
                MsgBox("Number of phones must be a positive number or at least 1")
                If gblnErrFlg = False Then
                    gblnErrFlg = True
                    txtNumPhones.SelectAll()
                    txtNumPhones.Focus()
                End If
            End If
        Else
            gblnErrFlg = True
        End If

        If radModel100.Checked = True Then
            decPhoneCost = CalcPhoneSubtotal(intNumPhones, 100) 'set number of phones to 1 since this is the individual form
        ElseIf radModel110.Checked = True Then
            decPhoneCost = CalcPhoneSubtotal(intNumPhones, 110)
        ElseIf radModel200.Checked = True Then
            decPhoneCost = CalcPhoneSubtotal(intNumPhones, 200)
        Else
            MsgBox("You must select a phone model")
        End If

        'get and calculate Package charges
        If radMin300.Checked = True Then
            decPackageCost = CalcPackageCharge(300)
            gblnErrFlg = False
        ElseIf radMin800.Checked = True Then
            decPackageCost = CalcPackageCharge(800)
            gblnErrFlg = False
        ElseIf radMin1500.Checked = True Then
            decPackageCost = CalcPackageCharge(1500)
            gblnErrFlg = False
        Else
            MsgBox("you must select a phone package")
            gblnErrFlg = True
        End If


        If gblnErrFlg = False Then 'calculate and display charges
            'Get and calculate options charges, if any
            If chkText.Checked = True And chkVoiceMail.Checked = False Then
                decOptions += CalcOptions(intNumPhones, False, True)
            ElseIf chkText.Checked = False And chkVoiceMail.Checked = True Then
                decOptions += CalcOptions(intNumPhones, True, False)
            ElseIf chkText.Checked = True And chkVoiceMail.Checked = True Then
                decOptions = CalcOptions(intNumPhones, True, True)
            End If

            'Get and add phone total
            decPhoneTotal = CalcTax(decPhoneCost) + decPhoneCost

            'Add package cost and options cost to get total monthly payment
            decTotalMonthly = decPackageCost + decOptions

            If intNumPhones >= 1 Then
                'Display results
                lblSubTotal.Text = FormatCurrency(decPhoneCost)
                lblTax.Text = FormatCurrency(CalcTax(decPhoneCost))
                lblPhoneTotal.Text = FormatCurrency(decPhoneTotal)
                lblOptions.Text = FormatCurrency(decOptions)
                lblPackCharge.Text = FormatCurrency(CStr(decPackageCost))
                lblMonthCharge.Text = FormatCurrency(decTotalMonthly)
            Else
                MsgBox("Number of phones must be 1 or more")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class