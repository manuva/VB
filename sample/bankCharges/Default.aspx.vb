
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim intNumChecks As Integer 'hold number of checks
        Dim decFees As Decimal 'hold fees

        intNumChecks = txtChecks.Text 'store user input in numchecks var

        If intNumChecks < 20 Then
            decFees = (intNumChecks * 0.1) + 10
        ElseIf intNumChecks >= 20 And intNumChecks <= 39 Then
            decFees = (intNumChecks * 0.08) + 10
        ElseIf intNumChecks >= 40 And intNumChecks <= 59 Then
            decFees = (intNumChecks * 0.06) + 10
        ElseIf intNumChecks >= 60 Then
            decFees = (intNumChecks * 0.04) + 10
        End If



        'display
        lblFees.Text = FormatCurrency(decFees)
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblFees.Text = String.Empty
        txtChecks.Text = String.Empty
    End Sub

End Class
