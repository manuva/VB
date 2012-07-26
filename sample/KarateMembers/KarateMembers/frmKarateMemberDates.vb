Public Class frmKarateMemberDates

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsKarate.Members' table. You can move, or remove it, as needed.
        'Sets datagrid to fill before the selected date as the default since before is checked on boot
        Me.MembersTableAdapter.FillByBefore(Me.DsKarate.Members, dtpDate.Value)

    End Sub

    Private Sub radBefore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBefore.CheckedChanged
        Me.MembersTableAdapter.FillByBefore(Me.DsKarate.Members, dtpDate.Value) 'fills before the date given
    End Sub

    Private Sub radAfter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAfter.CheckedChanged
        Me.MembersTableAdapter.FillByAfter(Me.DsKarate.Members, dtpDate.Value) 'fills by after the date given
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close() 'exits the program
    End Sub
End Class
