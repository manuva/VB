Module modtools

    'Public gintArrayCount As Integer
   
    Public gblnErrFlg As Boolean



    Public Function RightAlign(ByVal Source As String, ByVal Length As Integer) As String
        'Be sure to use a proportional font to make this work  Courier New, Regular Courier
        '            is one Lucida should be also

        Dim Result As String

        Result = Space(Length)
        Result = RSet(Source, Length)
        RightAlign = Result

    End Function
    Public Function CenterAlign(ByVal source As String, ByVal length As Integer) As String

        'Be sure to use a proportional font to make this work  Courier New, Regular Courier
        '            is one Lucida should be alsoDim Result As String
        Dim Result As String
        Result = Space(length)
        source = source & Space(CInt((length - Len(source)) / 2))
        Result = RSet(source, length)
        CenterAlign = Result
    End Function
    Public Function LeftAlign(ByVal source As String, ByVal length As Integer) As String
        'Be sure to use a proportional font to make this work  Courier New, Regular Courier
        '            is one Lucida should be also
        Dim Result As String

        Result = Space(length)
        Result = LSet(source, length)
        LeftAlign = Result
    End Function
    Public Function ValidNumber(ByVal vInputText As TextBox, ByVal vstrFieldName As String) As Boolean
        Dim strmsg As String
        strmsg = vstrFieldName & " Must be a Number"
        If IsNumeric(vInputText.Text.Trim) Then
            ValidNumber = True
        Else
            MsgBox(strmsg)
            Call InputError(vInputText)
            ValidNumber = False
        End If
    End Function
    Public Function ValidLength(ByVal vInputText As TextBox, ByVal vstrFieldName As String, _
                ByVal vUpperBounds As Integer, _
                ByVal vLowerBounds As Integer) As Boolean
        Dim strMsg As String
        strMsg = vstrFieldName & " Is a Required Field Beween " & Convert.ToString(vLowerBounds) & " and " & Convert.ToString(vUpperBounds)
        If vInputText.Text.Trim.Length >= vLowerBounds _
            And vInputText.Text.Trim.Length <= vUpperBounds Then
            ValidLength = True
        Else
            MsgBox(strMsg)
            Call InputError(vInputText)
            ValidLength = False
        End If
    End Function

    Public Function ValidateRequired(ByVal vInputText As TextBox, ByVal vstrFieldName As String) As Boolean
        Dim strMsg As String
        strMsg = vstrFieldName & " Is a Required Field"
        If vInputText.Text.Trim.Length > 0 Then
            ValidateRequired = True
        Else
            MsgBox(strMsg)
            Call InputError(vInputText)
            ValidateRequired = False
        End If
    End Function
    Public Sub InputError(ByVal TextError As TextBox)
        TextError.BackColor = System.Drawing.Color.Red
        If gblnErrFlg = False Then
            gblnErrFlg = True
            With TextError
                .Focus()
                .SelectAll()
            End With
        End If
    End Sub
    Public Function ValidRange(ByVal vInputText As TextBox, ByVal vdecNumber As Decimal, _
                    ByVal vdecLowerRange As Decimal, ByVal vdecUpperRange As Decimal, _
                    ByVal vstrFieldName As String) As Boolean
        Dim strMsg As String
        strMsg = vstrFieldName & " Must be a Number Greater than or Equal to " & Convert.ToString(vdecLowerRange) & " and " & Convert.ToString(vdecUpperRange)
        If vdecNumber >= vdecLowerRange _
           And vdecNumber <= vdecUpperRange Then
            ValidRange = True
        Else
            MsgBox(strMsg)
            Call InputError(vInputText)
            ValidRange = False
        End If
    End Function
    Public Function ValidZip(ByVal vInputText As TextBox, ByVal vstrFieldName As String, _
                              ByRef rstrFormattedZip As String) As Boolean
        Dim strmsg As String
        Dim strFieldname As String

        strmsg = vstrFieldName & " Must be a 5 or 9 Digit Number or 5 - 4 Number"
        If vInputText.Text.Trim.Length = 5 _
            Or vInputText.Text.Trim.Length = 9 _
            Or vInputText.Text.Trim.Length = 10 Then
            If vInputText.Text.Trim.Length = 5 _
                Or vInputText.Text.Trim.Length = 9 Then
                strFieldname = "Zip Code"
                If ValidNumber(vInputText, strFieldname) Then
                    If vInputText.Text.Trim.Length = 5 Then
                        rstrFormattedZip = vInputText.Text
                        ValidZip = True
                    Else
                        rstrFormattedZip = vInputText.Text.Substring(0, 5) & "-" & vInputText.Text.Substring(5, 4)
                        ValidZip = True
                    End If
                Else
                    MsgBox(strmsg)
                    Call InputError(vInputText)
                    rstrFormattedZip = ""
                    ValidZip = False
                End If
            Else
                ' this is the 10 char zip sent
                If vInputText.Text.Trim.IndexOf("-", 0) = 5 _
                    And IsNumeric(vInputText.Text.Trim.Substring(0, 5)) _
                    And IsNumeric(vInputText.Text.Trim.Substring(6, 4)) Then
                    rstrFormattedZip = vInputText.Text
                    ValidZip = True
                Else
                    MsgBox(strmsg)
                    Call InputError(vInputText)
                    rstrFormattedZip = ""
                    ValidZip = False
                End If
            End If

        Else
            MsgBox(strmsg)
            Call InputError(vInputText)
            rstrFormattedZip = ""
            ValidZip = False
        End If

    End Function

    'added extra function to validate number is greater than 0
    'because validLength has an upper range
    ' and validNumber accepts 0 as input
    Public Function ValidInteger(ByVal vInputText As TextBox, ByVal vstrFieldName As String, _
              ByVal vLowerBounds As Integer) As Boolean
        Dim strMsg As String
        strMsg = vstrFieldName & " Must Be Greater Than " & Convert.ToString(vLowerBounds)
        If CDbl(vInputText.Text) > vLowerBounds Then
            ValidInteger = True
        Else
            MsgBox(strMsg)
            Call InputError(vInputText)
            ValidInteger = False
        End If
    End Function

End Module
