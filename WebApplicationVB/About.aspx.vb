Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim dtid1 As DataTable
        'Dim dr As DataRow
        'dr = dtid1.NewRow()
        For Each tn As TreeNode In TreeView1.CheckedNodes
            Dim str As String


            Response.Write(tn.Value + tn.Text)
            str = tn.Value
        Next
        'dtid1.Rows.Add(dr)
    End Sub
End Class