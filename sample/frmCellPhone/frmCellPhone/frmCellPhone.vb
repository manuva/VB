Public Class frmCellPhone

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndividual.Click
        'Open individual form after clicking individual button
        Dim indForm As New frmIndividual

        indForm.ShowDialog()
    End Sub

    Private Sub btnFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamily.Click
        Dim famForm As New frmFamily

        famForm.ShowDialog()
    End Sub

    Private Sub frmCellPhone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
