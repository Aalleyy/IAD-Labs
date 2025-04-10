Partial Public Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Increment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles increment.serverclick

        Dim Counter As Integer
        If ViewState("Counter") Is Nothing Then
            Counter = 1
        Else
            Counter = CType(ViewState("Counter"), Integer) + 1
        End If
        ViewState("Counter") = Counter
        lblCount.Text = "Counter: " & Counter.ToString()
    End Sub
End Class