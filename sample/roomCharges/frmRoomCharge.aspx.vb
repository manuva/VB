
Partial Class frmRoomCharge
    Inherits System.Web.UI.Page

    'variables
    Dim dblRoomCharges As Double 'for room charges
    Dim dblAddCharges As Double 'for additional charges
    Dim dblSubTotal As Double 'for subtotal
    Dim dblTax As Double 'for tax
    Dim dblTotal As Double 'for total
    Dim decTAX_RATE As Decimal = 0.08D 'constant tax rate


    Private Sub frmRoomCharge_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblToday.Text = Now.ToString("D") 'set to today's date
        lblTime.Text = Now.ToString("T") 'set to current time


    End Sub


    Protected Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        If Page.IsValid Then 'if page is valid
            Calc() 'calculate
            Display() 'display calcs
        End If
  
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Sub Clear()

        '//clear all the boxes
        txtNights.Text = String.Empty
        txtNightlyCharges.Text = String.Empty
        txtRoomSvc.Text = String.Empty
        txtPhone.Text = String.Empty
        txtMisc.Text = String.Empty

        lblRmCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalCharges.Text = String.Empty

    End Sub

    Sub Calc()

        'calculate room charges
        dblRoomCharges = CDec(txtNights.Text * txtNightlyCharges.Text)

        'calculate additional charges

        '//to protect against converting a null string to dec
        If txtRoomSvc.Text = "" Then
            txtRoomSvc.Text = 0
        End If
        If txtPhone.Text = "" Then
            txtPhone.Text = 0
        End If
        If txtMisc.Text = "" Then
            txtMisc.Text = 0
        End If
        dblAddCharges = CDec(txtRoomSvc.Text) + CDec(txtPhone.Text) + CDec(txtMisc.Text)

        'calc subtotal
        dblSubTotal = CDec(dblRoomCharges + dblAddCharges)

        'calc tax
        dblTax = CDec(dblSubTotal * decTAX_RATE)

        'calc total charges
        dblTotal = CDec(dblSubTotal + dblTax)

    End Sub

    Sub Display()
        'display calcs

        lblRmCharges.Text = FormatCurrency(dblRoomCharges)
        lblAddCharges.Text = FormatCurrency(dblAddCharges)
        lblSubtotal.Text = FormatCurrency(dblSubTotal)
        lblTax.Text = FormatCurrency(dblTax)
        lblTotalCharges.Text = FormatCurrency(dblTotal)
    End Sub
End Class
