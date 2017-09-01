Public Class SiteMaster
    Inherits MasterPage

    Const AntiXsrfTokenKey As String = "__AntiXsrfToken"
    Const AntiXsrfUserNameKey As String = "__AntiXsrfUserName"
    Dim _antiXsrfTokenValue As String

    Protected Sub Page_Init(sender As Object, e As System.EventArgs)
        ' The code below helps to protect against XSRF attacks
        Dim requestCookie As HttpCookie = Request.Cookies(AntiXsrfTokenKey)
        Dim requestCookieGuidValue As Guid
        If ((Not requestCookie Is Nothing) AndAlso Guid.TryParse(requestCookie.Value, requestCookieGuidValue)) Then
            ' Use the Anti-XSRF token from the cookie
            _antiXsrfTokenValue = requestCookie.Value
            Page.ViewStateUserKey = _antiXsrfTokenValue
        Else
            ' Generate a new Anti-XSRF token and save to the cookie
            _antiXsrfTokenValue = Guid.NewGuid().ToString("N")
            Page.ViewStateUserKey = _antiXsrfTokenValue

            Dim responseCookie As HttpCookie = New HttpCookie(AntiXsrfTokenKey) With {.HttpOnly = True, .Value = _antiXsrfTokenValue}
            If (FormsAuthentication.RequireSSL And Request.IsSecureConnection) Then
                responseCookie.Secure = True
            End If
            Response.Cookies.Set(responseCookie)
        End If

        AddHandler Page.PreLoad, AddressOf master_Page_PreLoad
    End Sub

    Private Sub master_Page_PreLoad(sender As Object, e As System.EventArgs)
        If (Not IsPostBack) Then
            ' Set Anti-XSRF token
            ViewState(AntiXsrfTokenKey) = Page.ViewStateUserKey
            ViewState(AntiXsrfUserNameKey) = If(Context.User.Identity.Name, String.Empty)
        Else
            ' Validate the Anti-XSRF token
            'If (Not DirectCast(ViewState(AntiXsrfTokenKey), String) = _antiXsrfTokenValue _
            '    Or Not DirectCast(ViewState(AntiXsrfUserNameKey), String) = If(Context.User.Identity.Name, String.Empty)) Then
            '    Throw New InvalidOperationException("Validation of Anti-XSRF token failed.")
            'End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Context.User.Identity.IsAuthenticated = False AndAlso Request.Url.ToString.Contains("Login") = False Then
            Response.Redirect("/Account/Login.aspx")
        End If

        dsGetWatchListsForAUser.SelectParameters("strUserName").DefaultValue = Context.User.Identity.Name.ToString

    End Sub
    Public Function RunSP(ByVal p_SP As String, Optional ByVal params() As SqlClient.SqlParameter = Nothing) As DataSet
        Dim l_DataSet As DataSet = Nothing
        Try
            l_DataSet = New DataSet()

            ' Run the stored procedure
            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = p_SP

            If Not params Is Nothing Then
                For i As Integer = 0 To params.Count - 1
                    cmd.Parameters.Add(params(i))
                Next i
            End If


            'l_Adapter = GetDataAdapter(p_SP)

            ' Capture the returned dataset to return
            Dim l_Adapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
            l_Adapter.SelectCommand = cmd
            l_Adapter.Fill(l_DataSet)


        Catch ex As Exception
            'MsgBox(Now.ToString() & " User: " & SystemUser & " Proc: ExecuteSQL ErrorTrap: " & Err.Number.ToString() & " " & Err.Description)
        End Try

        Return l_DataSet

        'Usage Example
        'Dim params(0) As SqlClient.SqlParameter
        'params(0) = New SqlClient.SqlParameter("@strSiteName", SqlDbType.VarChar)
        'params(0).Value = strSiteName

        ''This inserts to the tblPatients Table AND gets back the intPatientID
        'Dim dsSPResults As DataSet = RunSP("dbo.spGetUserIDandPassword", params)

        'If dsSPResults.Tables.Count > 0 Then
        '    If dsSPResults.Tables(0).Rows.Count > 0 Then
        '        myUserIDandPassword.URL = dsSPResults.Tables(0).Rows(0).Item("strURL").ToString
        '        myUserIDandPassword.UserName = dsSPResults.Tables(0).Rows(0).Item("strUserName").ToString
        '        myUserIDandPassword.Password = dsSPResults.Tables(0).Rows(0).Item("strPassword").ToString
        '        myUserIDandPassword.SourceID = dsSPResults.Tables(0).Rows(0).Item("strSourceID").ToString
        '        myUserIDandPassword.AccountNumber = dsSPResults.Tables(0).Rows(0).Item("strAccountNumber").ToString
        '    End If
        'End If

    End Function
End Class