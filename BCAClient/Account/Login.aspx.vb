Imports System.Security.Principal

Public Class Login
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim amILoggedIn = Context.User.Identity.IsAuthenticated

        'RegisterHyperLink.NavigateUrl = "Register"
        'OpenAuthLogin.ReturnUrl = Request.QueryString("ReturnUrl")

        Dim returnUrl = HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
        'If Not String.IsNullOrEmpty(returnUrl) Then
        '    RegisterHyperLink.NavigateUrl &= "?ReturnUrl=" & returnUrl
        'End If
        If amILoggedIn = True Then
            If Request.QueryString("action") = "logout" Then
                Request.QueryString("action") = Nothing
                FormsAuthentication.SignOut()
                HttpContext.Current.User = New GenericPrincipal(New GenericIdentity(String.Empty), Nothing)
            Else
                Response.Redirect("/default.aspx")
            End If
        End If
    End Sub
    Public Sub LoginControl1_OnLoggedIn(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("/default.aspx")
    End Sub
End Class