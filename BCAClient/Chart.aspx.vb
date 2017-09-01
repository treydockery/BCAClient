Public Class Chart
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strStockSymbol As String = Request.QueryString("stocksymbol")
    End Sub

End Class