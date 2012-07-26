Public Class frmCarpet

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'Dim mblnErrFlg As Boolean 'error flag
        Dim dblArea As Double 'for holding the calculated area
        Dim dblTotal As Double 'for holding the calculated total cost
        Dim strFieldName As String 'string for modtools
        Dim RectangleObject As New clsRectangle 'rectangle object
        Dim CarpetObject As New Carpet 'carpet object

        'CarpetObject = New Carpet 'carpet object
        'RectangleObject = New Rectangle 'rectangle object

        gblnErrFlg = False 'set our error flag to false by default

        txtColor.BackColor = System.Drawing.Color.White
        txtStyle.BackColor = System.Drawing.Color.White
        txtPrice.BackColor = System.Drawing.Color.White
        txtLength.BackColor = System.Drawing.Color.White
        txtWidth.BackColor = System.Drawing.Color.White


        '-----validate Color-----
        strFieldName = "Color"
        If ValidateRequired(txtColor, strFieldName) Then 'do we have something input?
            CarpetObject.Color = txtColor.Text 'store
            'mblnErrFlg = False 'make sure our flag is false
        Else
            ' gblnErrFlg = True
            ' txtColor.Focus()
        End If

        '----validate Style----
        strFieldName = "Style"
        If ValidateRequired(txtStyle, strFieldName) Then '//is something input? (can be anything)
            CarpetObject.Style = txtStyle.Text
            'mblnErrFlg = False
        Else
            ' gblnErrFlg = True
            ' txtStyle.Focus()
        End If

        '----validate price----'
        strFieldName = "Price"
        If ValidateRequired(txtPrice, strFieldName) Then 'is something input?
            If ValidNumber(txtPrice, strFieldName) Then 'is it a number?
                If ValidInteger(txtPrice, strFieldName, 0) Then 'is it greater than 0?
                    CarpetObject.Price = CDec(txtPrice.Text.Trim) 'store it in class object if true
                    'mblnErrFlg = False 'set our error flag to false
                Else
                    '  gblnErrFlg = True
                    '  txtPrice.Focus()
                End If
            Else
                ' gblnErrFlg = True
                '  txtPrice.Focus()
            End If
        Else
            ' gblnErrFlg = True
            ' txtPrice.Focus()
        End If

        '-----validate width-----
        strFieldName = "Width"
        If ValidateRequired(txtWidth, strFieldName) Then
            If ValidNumber(txtWidth, strFieldName) Then
                If ValidInteger(txtWidth, strFieldName, 0) Then
                    RectangleObject.Width = CDbl(txtWidth.Text)

                    'mblnErrFlg = False
                Else
                    '  gblnErrFlg = True
                    '    txtWidth.Focus()
                End If
            Else
                ' gblnErrFlg = True
                '  txtWidth.Focus()
            End If
        Else
            ' gblnErrFlg = True
            ' txtWidth.Focus()
        End If

            '-----validate length------
            strFieldName = "Length"
            If ValidateRequired(txtLength, strFieldName) Then
                If ValidNumber(txtLength, strFieldName) Then
                    If ValidInteger(txtLength, strFieldName, 0) Then
                        RectangleObject.Length = CDbl(txtLength.Text)

                        'mblnErrFlg = False
                Else
                    ' txtLength.Focus()
                    '  gblnErrFlg = True
                    End If
                Else
                ' txtLength.Focus()
                '  gblnErrFlg = True
                End If
            Else
            ' txtLength.Focus()
            ' gblnErrFlg = True
            End If

            'calc the area
            'dblArea = CDbl(CStr(RectangleObject.CalcArea(RectangleObject.Length, RectangleObject.Width)))
            'calc the total
            'dblTotal = RectangleObject.CalcTotal(CarpetObject.Price, RectangleObject.CalcArea(RectangleObject.Length, RectangleObject.Width))

            'display if everything meets requirements and is valid
            If gblnErrFlg = False Then
                'calc the area
                dblArea = CDbl(CStr(RectangleObject.CalcArea(RectangleObject.Length, RectangleObject.Width)))
                'calc the total
                dblTotal = RectangleObject.CalcTotal(CarpetObject.Price, RectangleObject.CalcArea(RectangleObject.Length, RectangleObject.Width))
                'display- this code's labels originally did not have variables assigned
                'but i added them for possible easier reading
                lblAreaBox.Text = CStr(dblArea)
                lblTotal.Text = FormatCurrency(CStr(CDec(dblTotal)))
            Else
                'focus on first field if error
            MsgBox("Input must be valid before you can calculate")
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        CloseForm()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear() 'call to clear
    End Sub

    Sub Clear() 'clears form
        txtColor.Clear()
        txtStyle.Clear()
        txtPrice.Clear()
        txtWidth.Clear()
        txtLength.Clear()
        lblAreaBox.Text = String.Empty
        lblTotal.Text = String.Empty
        txtColor.BackColor = System.Drawing.Color.White
        txtStyle.BackColor = System.Drawing.Color.White
        txtPrice.BackColor = System.Drawing.Color.White
        txtLength.BackColor = System.Drawing.Color.White
        txtWidth.BackColor = System.Drawing.Color.White
        txtColor.Focus()
    End Sub
    Sub CloseForm() 'closes form
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        frmAboutBox.ShowDialog() 'shows the about form
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        CloseForm()
    End Sub

    Private Sub frmCarpet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtColor.Focus()
    End Sub

    Private Sub frmCarpet_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtColor.Focus()
    End Sub
End Class
