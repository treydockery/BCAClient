Public Class BulkInsert
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub btnTreysButton_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim myString As String = txtUserInfo.Text.Trim
        Dim x As String() = myString.Split(New Char() {vbCrLf}, StringSplitOptions.RemoveEmptyEntries)

        'For Each myLine In x
        '    Try
        '        Dim strAccountInfo As String() = myLine.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
        '        Dim strUserName As String = strAccountInfo(0).ToString.Trim
        '        ForcePasswordChange(strUserName)
        '    Catch ex As Exception

        '    End Try
        'Next

        For Each myLine In x
            Try
                Dim strAccountInfo As String() = myLine.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
                Dim strLastName As String = strAccountInfo(0).ToString.Trim
                Dim strFirstName As String = strAccountInfo(1).ToString.Trim
                Dim strUserName As String = strAccountInfo(2).ToString.Trim

                Dim newUser As MembershipUser = Membership.CreateUser(strUserName, "password", strUserName)
                newUser.IsApproved = False
                newUser.Comment = strLastName & ", " & strFirstName
                Membership.UpdateUser(newUser)


                Roles.AddUserToRole(strUserName, "DOCTOR")
                Roles.AddUserToRole(strUserName, "FORCE_PASSWORD_CHANGE")

                Dim newUserID As Guid = DirectCast(newUser.ProviderUserKey, Guid)

                Dim params(14) As SqlClient.SqlParameter
                params(0) = New SqlClient.SqlParameter("@newUserID", SqlDbType.UniqueIdentifier)
                params(0).Value = newUserID
                params(1) = New SqlClient.SqlParameter("@newUser", SqlDbType.VarChar)
                params(1).Value = newUser.UserName.Trim
                params(2) = New SqlClient.SqlParameter("@strFirstName", SqlDbType.VarChar)
                params(2).Value = strFirstName
                params(3) = New SqlClient.SqlParameter("@strLastName", SqlDbType.VarChar)
                params(3).Value = strLastName
                params(4) = New SqlClient.SqlParameter("@strTitle", SqlDbType.VarChar)
                params(4).Value = DBNull.Value
                params(5) = New SqlClient.SqlParameter("@strPhoneNumber", SqlDbType.VarChar)
                params(5).Value = DBNull.Value
                params(6) = New SqlClient.SqlParameter("@strPreferredContactMethod", SqlDbType.VarChar)
                params(6).Value = DBNull.Value
                params(7) = New SqlClient.SqlParameter("@bitParticipatedInResearch", SqlDbType.Bit)
                params(7).Value = True
                params(8) = New SqlClient.SqlParameter("@intUserTypeID", SqlDbType.Int)
                params(8).Value = DBNull.Value
                params(9) = New SqlClient.SqlParameter("@intOrganizationID", SqlDbType.Int)
                params(9).Value = DBNull.Value
                params(10) = New SqlClient.SqlParameter("@strOrganizationName", SqlDbType.VarChar)
                params(10).Value = DBNull.Value
                params(11) = New SqlClient.SqlParameter("@intOrganizationTypeID", SqlDbType.Int)
                params(11).Value = DBNull.Value
                params(12) = New SqlClient.SqlParameter("@bitHasResearchInterests", SqlDbType.Bit)
                params(12).Value = True
                params(13) = New SqlClient.SqlParameter("@bitAcceptTermsOfService", SqlDbType.Bit)
                params(13).Value = True
                params(14) = New SqlClient.SqlParameter("@strResearchInterestIDs", SqlDbType.VarChar)
                params(14).Value = DBNull.Value

                'This inserts to the tblPatients Table AND gets back the intPatientID
                Dim dsSPResults As DataSet = RunSP("dbo.spInsertExtendedProfileInformation", params)

            Catch ex As Exception
                Continue For
            End Try
        Next

        txtUserInfo.Text = txtUserInfo.Text & vbCrLf & "i'm Done"


    End Sub

    Public Sub ForcePasswordChange(ByRef strUserName As String)
        Roles.AddUserToRole(strUserName, "FORCE_PASSWORD_CHANGE")
    End Sub

#Region "StoredProcedure"
    Public Function RunSP(ByVal p_SP As String, Optional ByVal params() As SqlClient.SqlParameter = Nothing) As DataSet

        Dim l_DataSet As DataSet = Nothing
        Try
            l_DataSet = New DataSet()

            ' Run the stored procedure
            Dim cmd As New SqlClient.SqlCommand()
            'cmd.Connection = New SqlClient.SqlConnection("Data Source=mssql.dockeryfamily.com;Initial Catalog=treydock_sandbox;User ID=treydock_owner;Password=Tr3yd0ck3ry;Connect Timeout=120")
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
    End Function
#End Region

End Class