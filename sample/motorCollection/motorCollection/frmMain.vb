Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'display the add motor form
        Dim addMotorForm As New frmAddNewMotor()

        'display the form
        addMotorForm.ShowDialog()

        'update the contents of the list box.
        ListUpdate()

    End Sub
    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ListUpdate()
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim inFile As System.IO.StreamReader
        Dim NewMotor As Motor
        'Dim intCount As Integer = 0

        'create the collection
        motors = New Collection()

        'load any data from the file
        If System.IO.File.Exists("Motors.txt") Then
            inFile = System.IO.File.OpenText("Motors.txt")
            Do While inFile.Peek <> -1
                'read the record
                NewMotor = New Motor()
                Try
                    NewMotor.MotorId = inFile.ReadLine
                    NewMotor.Description = CStr(inFile.ReadLine)
                    NewMotor.RPM = CSng(inFile.ReadLine)
                    NewMotor.Voltage = CSng(inFile.ReadLine)
                    NewMotor.Status = inFile.ReadLine
                    motors.Add(NewMotor, NewMotor.MotorId)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            Loop

            inFile.Close()
            ListUpdate()

        End If


    End Sub


    Public Sub ListUpdate()
        'Dim intI As Integer
        Dim tempMotor As Motor

        'clear the list box
        lstMotors.Items.Clear()

        'add the items in the collection to the list box
        For Each tempMotor In motors
            lstMotors.Items.Add(tempMotor.ToString)
        Next

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

    Private Sub AddMotorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMotorToolStripMenuItem.Click
        'display the add motor form
        Dim addMotorForm As New frmAddNewMotor()

        'display the form
        addMotorForm.ShowDialog()

        'update the contents of the list box.
        ListUpdate()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
End Class
