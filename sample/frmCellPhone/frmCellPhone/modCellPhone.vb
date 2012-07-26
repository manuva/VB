Module modCellPhone

        ' Module level constants
        Const taxRate As Single = 0.06                  ' Sales Tax Rate

        Const decVOICE_MAIL_COST As Decimal = 5D         ' Monthly cost for voice mail
        Const decTEXT_MSG_COST As Decimal = 10D      ' Monthly cost for textMsg messaging
        Const mod100Cost As Decimal = 29.95D   ' Cost of a Model 100 phone
        Const mod110Cost As Decimal = 49.95D   ' Cost of a Model 110 phone
        Const mod200Cost As Decimal = 99.95D     ' Cost of a Model 200 phone

        Public Const plan300Cost As Decimal = 45D    ' Cost of the 300 minute plan
        Public Const plan800Cost As Decimal = 65D    ' Cost of the 800 minute plan
        Public Const plan1500Cost As Decimal = 99D  ' Cost of the 1500 minute plan

        Public Function CalcPhoneSubtotal(ByVal intNumPhones As Integer, _
         ByVal intModel As Integer) As Decimal

            ' This function returns the subtotal for the
            ' phones purchased. The number of phones purchased and
            ' the model number are passed as arguments.

            Dim decPhoneCost As Decimal

            ' Determine the cost based on model.
            Select Case intModel
                Case 100
                    decPhoneCost = intNumPhones * mod100Cost
                Case 110
                    decPhoneCost = intNumPhones * mod110Cost
                Case 200
                    decPhoneCost = intNumPhones * mod200Cost
            End Select

            ' Return the phone cost.
            Return decPhoneCost

        End Function

        Public Function CalcTax(ByVal decPhoneCost As Decimal) As Decimal
            ' This function returns the sales tax on the phones
            ' purchased. The phone cost is passed as an argument.

            Return CDec(decPhoneCost * taxRate)

        End Function


        Public Function CalcOptions(ByVal intPhones As Integer, _
         ByVal blnGotVoiceMail As Boolean, ByVal blnGotText As Boolean) As Decimal

            ' This function returns the monthly cost of the selected
            ' options. The first argument is the number of phones.
            ' The boolean arguments should be True or False, indicating
            ' whether the customer has selected voice mail and/or textMsg messaging.

            Dim decOptions As Decimal = 0D

            ' Determine if voice mail is selected.
            If blnGotVoiceMail = True Then
                decOptions += decVOICE_MAIL_COST
            End If

            ' Determine if textMsg messaging is selected.
            If blnGotText = True Then
                decOptions += decTEXT_MSG_COST
            End If

            ' Calculate for the number of phones purchased.
            decOptions *= intPhones

            ' Return the options monthly cost.
            Return decOptions

        End Function

        Public Function CalcPackageCharge(ByVal plan As Integer) As Decimal

            ' This function returns the total monthly cost
            Dim decMonthly As Decimal

            ' Determine plan cost.
        Select Case plan
            Case 300
                decMonthly = plan300Cost
            Case 800
                decMonthly = plan800Cost
            Case 1500
                decMonthly = plan1500Cost
        End Select

            ' Return the monthly cost
            Return decMonthly

        End Function

End Module
