Public Class frmAddNewMotor


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim strFieldName As String
        Dim objMotor As New Motor

        gblnErrFlg = False

        '-----PASTED VALIDATIONS FROM CLASS FILE------
        '-----gblnErrFlg commented out and error is now going to first field----
        strFieldName = "Motor ID"
        If ValidateRequired(txtMotorID, strFieldName) Then
            txtMotorID.BackColor = Color.White
            strFieldName = "Motor ID"
            If ValidLength(txtMotorID, strFieldName, 5, 5) Then
                txtMotorID.BackColor = Color.White
                objMotor.MotorId = txtMotorID.Text
            Else ': gblnErrFlg = False
                'txtMotorID.Focus()
            End If
        Else ': gblnErrFlg = False
            ' txtMotorID.Focus()
        End If

        strFieldName = "Description"
        If ValidateRequired(txtDesc, strFieldName) Then
            txtDesc.BackColor = Color.White
            objMotor.Description = txtDesc.Text
        Else ': gblnErrFlg = False
            ' txtDesc.Focus()
        End If

        strFieldName = "Motor RPMs"
        If ValidateRequired(txtMotorRPM, strFieldName) Then
            txtMotorRPM.BackColor = Color.White
            strFieldName = "Motor RPMs"
            If ValidNumber(txtMotorRPM, strFieldName) Then
                txtVoltage.BackColor = Color.White
                strFieldName = "Motor RPMs"
                If ValidRange(txtMotorRPM, CInt(txtMotorRPM.Text.Trim), 10, 999, strFieldName) Then
                    txtMotorRPM.BackColor = Color.White
                    objMotor.RPM = CSng(txtMotorRPM.Text)

                Else ': gblnErrFlg = False
                    '  txtMotorRPM.Focus()
                End If
            Else ': gblnErrFlg = False
                '  txtMotorRPM.Focus()
            End If
        Else ': gblnErrFlg = False
            '   txtMotorRPM.Focus()
        End If

        strFieldName = "Voltage"
        If ValidateRequired(txtVoltage, strFieldName) Then
            txtVoltage.BackColor = Color.White
            strFieldName = "Voltage"
            If ValidNumber(txtVoltage, strFieldName) Then
                strFieldName = "Voltage"
                txtVoltage.BackColor = Color.White
                If ValidRange(txtVoltage, CInt(txtVoltage.Text.Trim), 1, 499, strFieldName) Then
                    txtVoltage.BackColor = Color.White
                    objMotor.Voltage = CSng(txtVoltage.Text)

                Else ': gblnErrFlg = False
                    ' txtVoltage.Focus()
                End If
            Else ' : gblnErrFlg = False
                ' txtVoltage.Focus()
            End If
        Else ': gblnErrFlg = False
            '  txtVoltage.Focus()
        End If

        If txtMotorID.BackColor = Color.White And txtDesc.BackColor = Color.White And txtMotorRPM.BackColor = Color.White And txtVoltage.BackColor = Color.White Then
            Dim Motors1 As New Motor
            Motors1.MotorId = txtMotorID.Text.Trim
            Motors1.Description = txtDesc.Text.Trim
            Motors1.RPM = CSng(txtMotorRPM.Text.Trim)
            Motors1.Voltage = CSng(txtVoltage.Text.Trim)

            If radOn.Checked Then
                Motors1.Status = "ON"
            End If
            If radOff.Checked Then
                Motors1.Status = "OFF"
            End If
            If radMNT.Checked Then
                Motors1.Status = "MNT"
            End If
            If radNA.Checked Then
                Motors1.Status = "NA"
            End If

            motors.Add(Motors1)

            txtMotorID.Text = ""
            txtDesc.Text = ""
            txtMotorRPM.Text = ""
            txtVoltage.Text = ""
            radOn.Checked = True
            MsgBox("Motor Added")
            '--------------------END PASTE--------------------
            With frmMain 'update the listbox
                .ListUpdate()
            End With

            ' Save the records in the collection to the file.
               ' Save the records in the collection to the file.
            Dim outFile As System.IO.StreamWriter
            'Dim intI As Integer
            Dim NewMotor As New Motor
            
                outFile = System.IO.File.CreateText("Motors.txt")
                ' Save the collection.

            For Each NewMotor In motors
                WriteRecord(outFile, NewMotor)
            Next
            outFile.Close()

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtMotorID.Text = ""
        txtDesc.Text = ""
        txtMotorRPM.Text = ""
        txtVoltage.Text = ""
        radON.Checked = True
        txtMotorID.BackColor = Color.White
        txtDesc.BackColor = Color.White
        txtMotorRPM.BackColor = Color.White
        txtVoltage.BackColor = Color.White
        txtMotorID.Focus()
        Me.CausesValidation = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddNewMotor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtMotorID.Focus()
    End Sub

    Private Sub frmAddNewMotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radOn.Checked = True
        'txtMotorID.Focus()
    End Sub


    Private Sub WriteRecord(ByRef outfile As System.IO.StreamWriter, ByRef m As Motor)
        'write the contents of m to the file
        outfile.WriteLine(m.MotorId)
        outfile.WriteLine(m.Description)
        outfile.WriteLine(m.RPM)
        outfile.WriteLine(m.Voltage)
        outfile.WriteLine(m.Status)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        txtMotorID.Text = ""
        txtDesc.Text = ""
        txtMotorRPM.Text = ""
        txtVoltage.Text = ""
        radOn.Checked = True
        txtMotorID.BackColor = Color.White
        txtDesc.BackColor = Color.White
        txtMotorRPM.BackColor = Color.White
        txtVoltage.BackColor = Color.White
        txtMotorID.Focus()
        Me.CausesValidation = False
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strFieldName As String
        Dim mblnErrFlg As Boolean
        Dim objMotor As New Motor

        '-----PASTED VALIDATIONS FROM CLASS FILE------
        strFieldName = "Motor ID"
        If ValidateRequired(txtMotorID, strFieldName) Then
            txtMotorID.BackColor = Color.White
            strFieldName = "Motor ID"
            If ValidLength(txtMotorID, strFieldName, 5, 5) Then
                txtMotorID.BackColor = Color.White
                objMotor.MotorId = txtMotorID.Text
            Else : mblnErrFlg = False
            End If
        Else : mblnErrFlg = False
        End If

        strFieldName = "Description"
        If ValidateRequired(txtDesc, strFieldName) Then
            txtDesc.BackColor = Color.White
            objMotor.Description = txtDesc.Text
        Else : mblnErrFlg = False
        End If

        strFieldName = "Motor RPMs"
        If ValidateRequired(txtMotorRPM, strFieldName) Then
            txtMotorRPM.BackColor = Color.White
            strFieldName = "Motor RPMs"
            If ValidNumber(txtMotorRPM, strFieldName) Then
                txtVoltage.BackColor = Color.White
                strFieldName = "Motor RPMs"
                If ValidRange(txtMotorRPM, CInt(txtMotorRPM.Text.Trim), 10, 999, strFieldName) Then
                    txtMotorRPM.BackColor = Color.White
                    objMotor.RPM = CSng(txtMotorRPM.Text)

                Else : mblnErrFlg = False
                End If
            Else : mblnErrFlg = False
            End If
        Else : mblnErrFlg = False
        End If

        strFieldName = "Voltage"
        If ValidateRequired(txtVoltage, strFieldName) Then
            txtVoltage.BackColor = Color.White
            strFieldName = "Voltage"
            If ValidNumber(txtVoltage, strFieldName) Then
                strFieldName = "Voltage"
                txtVoltage.BackColor = Color.White
                If ValidRange(txtVoltage, CInt(txtVoltage.Text.Trim), 1, 499, strFieldName) Then
                    txtVoltage.BackColor = Color.White
                    objMotor.Voltage = CSng(txtVoltage.Text)

                Else : mblnErrFlg = False
                End If
            Else : mblnErrFlg = False
            End If
        Else : mblnErrFlg = False
        End If

        If txtMotorID.BackColor = Color.White And txtDesc.BackColor = Color.White And txtMotorRPM.BackColor = Color.White And txtVoltage.BackColor = Color.White Then
            Dim Motors1 As New Motor
            Motors1.MotorId = txtMotorID.Text.Trim
            Motors1.Description = txtDesc.Text.Trim
            Motors1.RPM = CSng(txtMotorRPM.Text.Trim)
            Motors1.Voltage = CSng(txtVoltage.Text.Trim)

            If radOn.Checked Then
                Motors1.Status = "ON"
            End If
            If radOff.Checked Then
                Motors1.Status = "OFF"
            End If
            If radMNT.Checked Then
                Motors1.Status = "MNT"
            End If
            If radNA.Checked Then
                Motors1.Status = "NA"
            End If

            motors.Add(Motors1)

            txtMotorID.Text = ""
            txtDesc.Text = ""
            txtMotorRPM.Text = ""
            txtVoltage.Text = ""
            radOn.Checked = True
            MsgBox("Motor Added")
            '--------------------END PASTE--------------------
            With frmMain 'update the listbox
                .ListUpdate()
            End With

            ' Save the records in the collection to the file.
            ' Save the records in the collection to the file.
            Dim outFile As System.IO.StreamWriter
            'Dim intI As Integer
            Dim NewMotor As Motor

            If motors.Count > 0 Then
                ' Create the file.
                outFile = System.IO.File.CreateText("Motors.txt")
                ' Save the collection.
                For Each NewMotor In motors
                    WriteRecord(outFile, NewMotor)
                Next
                outFile.Close()
            End If

        End If
    End Sub
End Class
