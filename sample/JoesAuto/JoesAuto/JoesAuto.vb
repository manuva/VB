Public Class JoesAuto
    Public gblnErrFlg As Boolean
    Dim mdecLabor, mdecPart As Decimal


    Function OilLubeCharges() As Decimal
        'Returns the charges for oil change and lube job
        Dim decCharges As Decimal

        'Add the charges for the oil change, if any
        If chkOil.Checked = True Then
            decCharges = 26
        End If

        'Add charges for the lube job, if any
        If chkLube.Checked = True Then
            decCharges += 18
        End If

        'Return the charges
        Return decCharges
    End Function

    Function FlushCharges() As Decimal
        Dim decFlush As Decimal 'Returns the charges for trans and radiator flush
        If chkRadiator.Checked = True Then 'Add charges for the radiator flush, if any
            decFlush = 30
        End If
        If chkTrans.Checked = True Then 'Add charges for the trans flush if any
            decFlush += 80
        End If

        'Returns the charges
        Return decFlush
    End Function

    Function MiscCharges() As Decimal
        Dim decInspect As Decimal 'Return the charges of inspection job
        If chkInspect.Checked = True Then
            decInspect = 15
        End If
        If chkMuffler.Checked = True Then
            decInspect += 100
        End If
        If chkTire.Checked = True Then
            decInspect += 20
        End If

        Return decInspect

    End Function

    Function OtherCharges(ByVal mdecPart As Decimal, ByVal mdecLabor As Decimal) As Decimal
        Dim decTotalOtherCharge As Decimal
        decTotalOtherCharge = mdecPart + mdecLabor

        Return decTotalOtherCharge
    End Function

    Function TotalCharges(ByVal mdecOilCharge As Decimal, ByVal mdecFlushCharge As Decimal, _
                          ByVal mdecMiscCharge As Decimal, ByVal mdecOtherCharge As Decimal, _
                          ByVal mdecTaxCharge As Decimal) As Decimal
        Dim decTotal As Decimal

        decTotal = mdecOilCharge + mdecFlushCharge + mdecMiscCharge + mdecOtherCharge + mdecTaxCharge

        Return decTotal

    End Function

    Function TaxCharges(ByVal mdecPart As Decimal) As Decimal
        Dim decTotalTax As Decimal
        If mdecPart > 0 Then
            decTotalTax = CDec(mdecPart * 0.06)

        End If
        Return decTotalTax
    End Function

    Sub ClearOilLube()
        'Clears the oil checkboxes
        chkOil.Checked = False
        chkLube.Checked = False
    End Sub

    Sub ClearFlushes()
        'Clears the flushes checkboxes
        chkRadiator.Checked = False
        chkTrans.Checked = False
    End Sub

    Sub ClearMisc()
        'Clear the misc checkboxes
        chkTire.Checked = False
        chkMuffler.Checked = False
        chkInspect.Checked = False
    End Sub

    Sub ClearOther()
        'Clears "Other Services" textbox
        txtLabor.Clear()
        txtPart.Clear()
    End Sub

    Sub ClearFees()
        'Clears the fees displays
        lblLaborCost.Text = ""
        lblPartCost.Text = ""
        lblTaxCost.Text = ""
        lblTotalCost.Text = ""

    End Sub



    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearOilLube() 'Clear grpbox 1 oil&lube
        ClearFlushes() 'Clear grpbox 2 flushes
        ClearMisc() 'Clears Misc
        ClearOther() 'Clears other fields
        ClearFees() 'Clears the fees
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        Dim mdecOilCharge As Decimal
        Dim mdecFlushCharge As Decimal
        Dim mdecMiscCharge As Decimal
        Dim mdecOtherCharge As Decimal
        Dim mdecTotalCharge As Decimal
        Dim mdecTaxCharge As Decimal
        Dim mdecLaborService As Decimal

        gblnErrFlg = False

        'clear total fees boxes
        lblLaborCost.Text = ""
        lblPartCost.Text = ""
        lblTaxCost.Text = ""
        lblTotalCost.Text = ""


        'Validate Parts Textbox
        If txtPart.Text.Trim.Length > 0 Then
            If IsNumeric(txtPart.Text.Trim) = True Then
                mdecPart = CDec(txtPart.Text.Trim)
                If mdecPart >= 0 Then
                Else
                    MsgBox("parts must be a positive number or 0")
                    If gblnErrFlg = False Then
                        gblnErrFlg = True
                        txtPart.SelectAll()
                        txtPart.Focus()
                    End If
                End If
            Else
                MsgBox("parts must be a positive number or 0")
                If gblnErrFlg = False Then
                    gblnErrFlg = True
                    txtPart.SelectAll()
                    txtPart.Focus()
                End If
            End If

        Else
            mdecPart = 0
            gblnErrFlg = False
        End If



        'Validate Labor textbox
        If txtLabor.Text.Trim.Length > 0 Then
            If IsNumeric(txtLabor.Text.Trim) = True Then
                mdecLabor = CDec(txtLabor.Text.Trim)
                If mdecLabor >= 0 Then
                Else
                    MsgBox("Labor must be a positive number or 0")
                    If gblnErrFlg = False Then
                        gblnErrFlg = True
                        txtLabor.SelectAll()
                        txtLabor.Focus()
                    End If
                End If
            Else
                MsgBox("labor must be a positive number or 0")
                If gblnErrFlg = False Then
                    gblnErrFlg = True
                    txtLabor.SelectAll()
                    txtLabor.Focus()
                End If
            End If

        Else
            mdecLabor = 0
            gblnErrFlg = False
        End If

        'If chkOil.Checked = False Then

        If gblnErrFlg = False Then


            mdecOilCharge = OilLubeCharges() 'Variable for returning Oil&Lube charges function
            mdecFlushCharge = FlushCharges() 'Variable for returning Radiator and Trans Flush function
            mdecMiscCharge = MiscCharges() 'Variable for returning Misc Charges function

            mdecOtherCharge = OtherCharges(mdecPart, mdecLabor)
            mdecTaxCharge = TaxCharges(mdecPart)
            mdecTotalCharge = TotalCharges(mdecOilCharge, mdecFlushCharge, mdecMiscCharge, mdecOtherCharge, mdecTaxCharge)

            'Service and labor calculations
            mdecLaborService = mdecOilCharge + mdecFlushCharge + mdecMiscCharge + mdecLabor

            If mdecTotalCharge >= 1 Then 'if the total is 0 then display error to user telling them to input something to charge
                'Display results in $ format
                lblLaborCost.Text = FormatCurrency(CStr(mdecLaborService))
                lblPartCost.Text = FormatCurrency(CStr(mdecPart))
                lblTaxCost.Text = FormatCurrency(CStr(mdecTaxCharge))
                lblTotalCost.Text = FormatCurrency(CStr(mdecTotalCharge))
            Else
                MsgBox("you must input something")
            End If

        End If

    End Sub
End Class