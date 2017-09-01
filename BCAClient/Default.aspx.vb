Imports System.Net

Public Class _Default
    Inherits Page

    Dim strWatchlistName As String = Nothing
    Dim strWatchListID As String = String.Empty
    Dim strCompanyID As String = String.Empty
    Public Class QUOTE
        Public Property SYMBOL() As String
            Get
                Return m_SYMBOL
            End Get
            Set
                m_SYMBOL = Value
            End Set
        End Property
        Private m_SYMBOL As String
        Public Property ASK() As String
            Get
                Return m_ASK
            End Get
            Set
                m_ASK = Value
            End Set
        End Property
        Private m_ASK As String
        Public Property AVERAGEDAILYVOLUME() As String
            Get
                Return m_AVERAGEDAILYVOLUME
            End Get
            Set
                m_AVERAGEDAILYVOLUME = Value
            End Set
        End Property
        Private m_AVERAGEDAILYVOLUME As String
        Public Property BID() As String
            Get
                Return m_BID
            End Get
            Set
                m_BID = Value
            End Set
        End Property
        Private m_BID As String
        Public Property ASKREALTIME() As String
            Get
                Return m_ASKREALTIME
            End Get
            Set
                m_ASKREALTIME = Value
            End Set
        End Property
        Private m_ASKREALTIME As String
        Public Property BIDREALTIME() As String
            Get
                Return m_BIDREALTIME
            End Get
            Set
                m_BIDREALTIME = Value
            End Set
        End Property
        Private m_BIDREALTIME As String
        Public Property BOOKVALUE() As String
            Get
                Return m_BOOKVALUE
            End Get
            Set
                m_BOOKVALUE = Value
            End Set
        End Property
        Private m_BOOKVALUE As String
        Public Property CHANGE_PERCENTCHANGE() As String
            Get
                Return m_CHANGE_PERCENTCHANGE
            End Get
            Set
                m_CHANGE_PERCENTCHANGE = Value
            End Set
        End Property
        Private m_CHANGE_PERCENTCHANGE As String
        Public Property CHANGE() As String
            Get
                Return m_CHANGE
            End Get
            Set
                m_CHANGE = Value
            End Set
        End Property
        Private m_CHANGE As String
        Public Property COMMISSION() As String
            Get
                Return m_COMMISSION
            End Get
            Set
                m_COMMISSION = Value
            End Set
        End Property
        Private m_COMMISSION As String
        Public Property CURRENCY() As String
            Get
                Return m_CURRENCY
            End Get
            Set
                m_CURRENCY = Value
            End Set
        End Property
        Private m_CURRENCY As String
        Public Property CHANGEREALTIME() As String
            Get
                Return m_CHANGEREALTIME
            End Get
            Set
                m_CHANGEREALTIME = Value
            End Set
        End Property
        Private m_CHANGEREALTIME As String
        Public Property AFTERHOURSCHANGEREALTIME() As String
            Get
                Return m_AFTERHOURSCHANGEREALTIME
            End Get
            Set
                m_AFTERHOURSCHANGEREALTIME = Value
            End Set
        End Property
        Private m_AFTERHOURSCHANGEREALTIME As String
        Public Property DIVIDENDSHARE() As String
            Get
                Return m_DIVIDENDSHARE
            End Get
            Set
                m_DIVIDENDSHARE = Value
            End Set
        End Property
        Private m_DIVIDENDSHARE As String
        Public Property LASTTRADEDATE() As String
            Get
                Return m_LASTTRADEDATE
            End Get
            Set
                m_LASTTRADEDATE = Value
            End Set
        End Property
        Private m_LASTTRADEDATE As String
        Public Property TRADEDATE() As String
            Get
                Return m_TRADEDATE
            End Get
            Set
                m_TRADEDATE = Value
            End Set
        End Property
        Private m_TRADEDATE As String
        Public Property EARNINGSSHARE() As String
            Get
                Return m_EARNINGSSHARE
            End Get
            Set
                m_EARNINGSSHARE = Value
            End Set
        End Property
        Private m_EARNINGSSHARE As String
        Public Property ERRORINDICATIONRETURNEDFORSYMBOLCHANGEDINVALID() As String
            Get
                Return m_ERRORINDICATIONRETURNEDFORSYMBOLCHANGEDINVALID
            End Get
            Set
                m_ERRORINDICATIONRETURNEDFORSYMBOLCHANGEDINVALID = Value
            End Set
        End Property
        Private m_ERRORINDICATIONRETURNEDFORSYMBOLCHANGEDINVALID As String
        Public Property EPSESTIMATECURRENTYEAR() As String
            Get
                Return m_EPSESTIMATECURRENTYEAR
            End Get
            Set
                m_EPSESTIMATECURRENTYEAR = Value
            End Set
        End Property
        Private m_EPSESTIMATECURRENTYEAR As String
        Public Property EPSESTIMATENEXTYEAR() As String
            Get
                Return m_EPSESTIMATENEXTYEAR
            End Get
            Set
                m_EPSESTIMATENEXTYEAR = Value
            End Set
        End Property
        Private m_EPSESTIMATENEXTYEAR As String
        Public Property EPSESTIMATENEXTQUARTER() As String
            Get
                Return m_EPSESTIMATENEXTQUARTER
            End Get
            Set
                m_EPSESTIMATENEXTQUARTER = Value
            End Set
        End Property
        Private m_EPSESTIMATENEXTQUARTER As String
        Public Property DAYSLOW() As String
            Get
                Return m_DAYSLOW
            End Get
            Set
                m_DAYSLOW = Value
            End Set
        End Property
        Private m_DAYSLOW As String
        Public Property DAYSHIGH() As String
            Get
                Return m_DAYSHIGH
            End Get
            Set
                m_DAYSHIGH = Value
            End Set
        End Property
        Private m_DAYSHIGH As String
        Public Property YEARLOW() As String
            Get
                Return m_YEARLOW
            End Get
            Set
                m_YEARLOW = Value
            End Set
        End Property
        Private m_YEARLOW As String
        Public Property YEARHIGH() As String
            Get
                Return m_YEARHIGH
            End Get
            Set
                m_YEARHIGH = Value
            End Set
        End Property
        Private m_YEARHIGH As String
        Public Property HOLDINGSGAINPERCENT() As String
            Get
                Return m_HOLDINGSGAINPERCENT
            End Get
            Set
                m_HOLDINGSGAINPERCENT = Value
            End Set
        End Property
        Private m_HOLDINGSGAINPERCENT As String
        Public Property ANNUALIZEDGAIN() As String
            Get
                Return m_ANNUALIZEDGAIN
            End Get
            Set
                m_ANNUALIZEDGAIN = Value
            End Set
        End Property
        Private m_ANNUALIZEDGAIN As String
        Public Property HOLDINGSGAIN() As String
            Get
                Return m_HOLDINGSGAIN
            End Get
            Set
                m_HOLDINGSGAIN = Value
            End Set
        End Property
        Private m_HOLDINGSGAIN As String
        Public Property HOLDINGSGAINPERCENTREALTIME() As String
            Get
                Return m_HOLDINGSGAINPERCENTREALTIME
            End Get
            Set
                m_HOLDINGSGAINPERCENTREALTIME = Value
            End Set
        End Property
        Private m_HOLDINGSGAINPERCENTREALTIME As String
        Public Property HOLDINGSGAINREALTIME() As String
            Get
                Return m_HOLDINGSGAINREALTIME
            End Get
            Set
                m_HOLDINGSGAINREALTIME = Value
            End Set
        End Property
        Private m_HOLDINGSGAINREALTIME As String
        Public Property MOREINFO() As String
            Get
                Return m_MOREINFO
            End Get
            Set
                m_MOREINFO = Value
            End Set
        End Property
        Private m_MOREINFO As String
        Public Property ORDERBOOKREALTIME() As String
            Get
                Return m_ORDERBOOKREALTIME
            End Get
            Set
                m_ORDERBOOKREALTIME = Value
            End Set
        End Property
        Private m_ORDERBOOKREALTIME As String
        Public Property MARKETCAPITALIZATION() As String
            Get
                Return m_MARKETCAPITALIZATION
            End Get
            Set
                m_MARKETCAPITALIZATION = Value
            End Set
        End Property
        Private m_MARKETCAPITALIZATION As String
        Public Property MARKETCAPREALTIME() As String
            Get
                Return m_MARKETCAPREALTIME
            End Get
            Set
                m_MARKETCAPREALTIME = Value
            End Set
        End Property
        Private m_MARKETCAPREALTIME As String
        Public Property EBITDA() As String
            Get
                Return m_EBITDA
            End Get
            Set
                m_EBITDA = Value
            End Set
        End Property
        Private m_EBITDA As String
        Public Property CHANGEFROMYEARLOW() As String
            Get
                Return m_CHANGEFROMYEARLOW
            End Get
            Set
                m_CHANGEFROMYEARLOW = Value
            End Set
        End Property
        Private m_CHANGEFROMYEARLOW As String
        Public Property PERCENTCHANGEFROMYEARLOW() As String
            Get
                Return m_PERCENTCHANGEFROMYEARLOW
            End Get
            Set
                m_PERCENTCHANGEFROMYEARLOW = Value
            End Set
        End Property
        Private m_PERCENTCHANGEFROMYEARLOW As String
        Public Property LASTTRADEREALTIMEWITHTIME() As String
            Get
                Return m_LASTTRADEREALTIMEWITHTIME
            End Get
            Set
                m_LASTTRADEREALTIMEWITHTIME = Value
            End Set
        End Property
        Private m_LASTTRADEREALTIMEWITHTIME As String
        Public Property CHANGEPERCENTREALTIME() As String
            Get
                Return m_CHANGEPERCENTREALTIME
            End Get
            Set
                m_CHANGEPERCENTREALTIME = Value
            End Set
        End Property
        Private m_CHANGEPERCENTREALTIME As String
        Public Property CHANGEFROMYEARHIGH() As String
            Get
                Return m_CHANGEFROMYEARHIGH
            End Get
            Set
                m_CHANGEFROMYEARHIGH = Value
            End Set
        End Property
        Private m_CHANGEFROMYEARHIGH As String
        Public Property PERCEBTCHANGEFROMYEARHIGH() As String
            Get
                Return m_PERCEBTCHANGEFROMYEARHIGH
            End Get
            Set
                m_PERCEBTCHANGEFROMYEARHIGH = Value
            End Set
        End Property
        Private m_PERCEBTCHANGEFROMYEARHIGH As String
        Public Property LASTTRADEWITHTIME() As String
            Get
                Return m_LASTTRADEWITHTIME
            End Get
            Set
                m_LASTTRADEWITHTIME = Value
            End Set
        End Property
        Private m_LASTTRADEWITHTIME As String
        Public Property LASTTRADEPRICEONLY() As String
            Get
                Return m_LASTTRADEPRICEONLY
            End Get
            Set
                m_LASTTRADEPRICEONLY = Value
            End Set
        End Property
        Private m_LASTTRADEPRICEONLY As String
        Public Property HIGHLIMIT() As String
            Get
                Return m_HIGHLIMIT
            End Get
            Set
                m_HIGHLIMIT = Value
            End Set
        End Property
        Private m_HIGHLIMIT As String
        Public Property LOWLIMIT() As String
            Get
                Return m_LOWLIMIT
            End Get
            Set
                m_LOWLIMIT = Value
            End Set
        End Property
        Private m_LOWLIMIT As String
        Public Property DAYSRANGE() As String
            Get
                Return m_DAYSRANGE
            End Get
            Set
                m_DAYSRANGE = Value
            End Set
        End Property
        Private m_DAYSRANGE As String
        Public Property DAYSRANGEREALTIME() As String
            Get
                Return m_DAYSRANGEREALTIME
            End Get
            Set
                m_DAYSRANGEREALTIME = Value
            End Set
        End Property
        Private m_DAYSRANGEREALTIME As String
        Public Property FIFTYDAYMOVINGAVERAGE() As String
            Get
                Return m_FIFTYDAYMOVINGAVERAGE
            End Get
            Set
                m_FIFTYDAYMOVINGAVERAGE = Value
            End Set
        End Property
        Private m_FIFTYDAYMOVINGAVERAGE As String
        Public Property TWOHUNDREDDAYMOVINGAVERAGE() As String
            Get
                Return m_TWOHUNDREDDAYMOVINGAVERAGE
            End Get
            Set
                m_TWOHUNDREDDAYMOVINGAVERAGE = Value
            End Set
        End Property
        Private m_TWOHUNDREDDAYMOVINGAVERAGE As String
        Public Property CHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE() As String
            Get
                Return m_CHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE
            End Get
            Set
                m_CHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE = Value
            End Set
        End Property
        Private m_CHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE As String
        Public Property PERCENTCHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE() As String
            Get
                Return m_PERCENTCHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE
            End Get
            Set
                m_PERCENTCHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE = Value
            End Set
        End Property
        Private m_PERCENTCHANGEFROMTWOHUNDREDDAYMOVINGAVERAGE As String
        Public Property CHANGEFROMFIFTYDAYMOVINGAVERAGE() As String
            Get
                Return m_CHANGEFROMFIFTYDAYMOVINGAVERAGE
            End Get
            Set
                m_CHANGEFROMFIFTYDAYMOVINGAVERAGE = Value
            End Set
        End Property
        Private m_CHANGEFROMFIFTYDAYMOVINGAVERAGE As String
        Public Property PERCENTCHANGEFROMFIFTYDAYMOVINGAVERAGE() As String
            Get
                Return m_PERCENTCHANGEFROMFIFTYDAYMOVINGAVERAGE
            End Get
            Set
                m_PERCENTCHANGEFROMFIFTYDAYMOVINGAVERAGE = Value
            End Set
        End Property
        Private m_PERCENTCHANGEFROMFIFTYDAYMOVINGAVERAGE As String
        Public Property NAME() As String
            Get
                Return m_NAME
            End Get
            Set
                m_NAME = Value
            End Set
        End Property
        Private m_NAME As String
        Public Property NOTES() As String
            Get
                Return m_NOTES
            End Get
            Set
                m_NOTES = Value
            End Set
        End Property
        Private m_NOTES As String
        Public Property OPEN() As String
            Get
                Return m_OPEN
            End Get
            Set
                m_OPEN = Value
            End Set
        End Property
        Private m_OPEN As String
        Public Property PREVIOUSCLOSE() As String
            Get
                Return m_PREVIOUSCLOSE
            End Get
            Set
                m_PREVIOUSCLOSE = Value
            End Set
        End Property
        Private m_PREVIOUSCLOSE As String
        Public Property PRICEPAID() As String
            Get
                Return m_PRICEPAID
            End Get
            Set
                m_PRICEPAID = Value
            End Set
        End Property
        Private m_PRICEPAID As String
        Public Property CHANGEINPERCENT() As String
            Get
                Return m_CHANGEINPERCENT
            End Get
            Set
                m_CHANGEINPERCENT = Value
            End Set
        End Property
        Private m_CHANGEINPERCENT As String
        Public Property PRICESALES() As String
            Get
                Return m_PRICESALES
            End Get
            Set
                m_PRICESALES = Value
            End Set
        End Property
        Private m_PRICESALES As String
        Public Property PRICEBOOK() As String
            Get
                Return m_PRICEBOOK
            End Get
            Set
                m_PRICEBOOK = Value
            End Set
        End Property
        Private m_PRICEBOOK As String
        Public Property EXDIVIDENDDATE() As String
            Get
                Return m_EXDIVIDENDDATE
            End Get
            Set
                m_EXDIVIDENDDATE = Value
            End Set
        End Property
        Private m_EXDIVIDENDDATE As String
        Public Property PERATIO() As String
            Get
                Return m_PERATIO
            End Get
            Set
                m_PERATIO = Value
            End Set
        End Property
        Private m_PERATIO As String
        Public Property DIVIDENDPAYDATE() As String
            Get
                Return m_DIVIDENDPAYDATE
            End Get
            Set
                m_DIVIDENDPAYDATE = Value
            End Set
        End Property
        Private m_DIVIDENDPAYDATE As String
        Public Property PERATIOREALTIME() As String
            Get
                Return m_PERATIOREALTIME
            End Get
            Set
                m_PERATIOREALTIME = Value
            End Set
        End Property
        Private m_PERATIOREALTIME As String
        Public Property PEGRATIO() As String
            Get
                Return m_PEGRATIO
            End Get
            Set
                m_PEGRATIO = Value
            End Set
        End Property
        Private m_PEGRATIO As String
        Public Property PRICEEPSESTIMATECURRENTYEAR() As String
            Get
                Return m_PRICEEPSESTIMATECURRENTYEAR
            End Get
            Set
                m_PRICEEPSESTIMATECURRENTYEAR = Value
            End Set
        End Property
        Private m_PRICEEPSESTIMATECURRENTYEAR As String
        Public Property PRICEEPSESTIMATENEXTYEAR() As String
            Get
                Return m_PRICEEPSESTIMATENEXTYEAR
            End Get
            Set
                m_PRICEEPSESTIMATENEXTYEAR = Value
            End Set
        End Property
        Private m_PRICEEPSESTIMATENEXTYEAR As String
        Public Property SHARESOWNED() As String
            Get
                Return m_SHARESOWNED
            End Get
            Set
                m_SHARESOWNED = Value
            End Set
        End Property
        Private m_SHARESOWNED As String
        Public Property SHORTRATIO() As String
            Get
                Return m_SHORTRATIO
            End Get
            Set
                m_SHORTRATIO = Value
            End Set
        End Property
        Private m_SHORTRATIO As String
        Public Property LASTTRADETIME() As String
            Get
                Return m_LASTTRADETIME
            End Get
            Set
                m_LASTTRADETIME = Value
            End Set
        End Property
        Private m_LASTTRADETIME As String
        Public Property TICKERTREND() As String
            Get
                Return m_TICKERTREND
            End Get
            Set
                m_TICKERTREND = Value
            End Set
        End Property
        Private m_TICKERTREND As String
        Public Property ONEYRTARGETPRICE() As String
            Get
                Return m_ONEYRTARGETPRICE
            End Get
            Set
                m_ONEYRTARGETPRICE = Value
            End Set
        End Property
        Private m_ONEYRTARGETPRICE As String
        Public Property VOLUME() As String
            Get
                Return m_VOLUME
            End Get
            Set
                m_VOLUME = Value
            End Set
        End Property
        Private m_VOLUME As String
        Public Property HOLDINGSVALUE() As String
            Get
                Return m_HOLDINGSVALUE
            End Get
            Set
                m_HOLDINGSVALUE = Value
            End Set
        End Property
        Private m_HOLDINGSVALUE As String
        Public Property HOLDINGSVALUEREALTIME() As String
            Get
                Return m_HOLDINGSVALUEREALTIME
            End Get
            Set
                m_HOLDINGSVALUEREALTIME = Value
            End Set
        End Property
        Private m_HOLDINGSVALUEREALTIME As String
        Public Property YEARRANGE() As String
            Get
                Return m_YEARRANGE
            End Get
            Set
                m_YEARRANGE = Value
            End Set
        End Property
        Private m_YEARRANGE As String
        Public Property DAYSVALUECHANGE() As String
            Get
                Return m_DAYSVALUECHANGE
            End Get
            Set
                m_DAYSVALUECHANGE = Value
            End Set
        End Property
        Private m_DAYSVALUECHANGE As String
        Public Property DAYSVALUECHANGEREALTIME() As String
            Get
                Return m_DAYSVALUECHANGEREALTIME
            End Get
            Set
                m_DAYSVALUECHANGEREALTIME = Value
            End Set
        End Property
        Private m_DAYSVALUECHANGEREALTIME As String
        Public Property STOCKEXCHANGE() As String
            Get
                Return m_STOCKEXCHANGE
            End Get
            Set
                m_STOCKEXCHANGE = Value
            End Set
        End Property
        Private m_STOCKEXCHANGE As String
        Public Property DIVIDENDYIELD() As String
            Get
                Return m_DIVIDENDYIELD
            End Get
            Set
                m_DIVIDENDYIELD = Value
            End Set
        End Property
        Private m_DIVIDENDYIELD As String
        Public Property PERCENTCHANGE() As String
            Get
                Return m_PERCENTCHANGE
            End Get
            Set
                m_PERCENTCHANGE = Value
            End Set
        End Property
        Private m_PERCENTCHANGE As String
    End Class
    Public Class RESULTS
        'Public Property QUOTE() As List(Of QUOTE)
        Public Property QUOTE() As QUOTE
            Get
                Return m_QUOTE
            End Get
            Set
                m_QUOTE = Value
            End Set
        End Property
        'Private m_QUOTE As List(Of QUOTE)
        Private m_QUOTE As QUOTE
    End Class
    Public Class QUERY
        Public Property COUNT() As Integer
            Get
                Return m_COUNT
            End Get
            Set
                m_COUNT = Value
            End Set
        End Property
        Private m_COUNT As Integer
        Public Property CREATED() As String
            Get
                Return m_CREATED
            End Get
            Set
                m_CREATED = Value
            End Set
        End Property
        Private m_CREATED As String
        Public Property LANG() As String
            Get
                Return m_LANG
            End Get
            Set
                m_LANG = Value
            End Set
        End Property
        Private m_LANG As String
        Public Property RESULTS() As RESULTS
            Get
                Return m_RESULTS
            End Get
            Set
                m_RESULTS = Value
            End Set
        End Property
        Private m_RESULTS As RESULTS
    End Class
    Public Class YQLRootObject
        Public Property QUERY() As QUERY
            Get
                Return m_QUERY
            End Get
            Set
                m_QUERY = Value
            End Set
        End Property
        Private m_QUERY As QUERY
    End Class
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Context.User.Identity.IsAuthenticated = False AndAlso Request.Url.ToString.Contains("Login") = False Then
            Response.Redirect("/Account/Login.aspx")
        End If

        Dim txtSearchForStock As TextBox = Page.Master.FindControl("txtSearchForStock")
        Dim strSearchString As String = txtSearchForStock.Text
        txtSearchForStock.Text = String.Empty

        strWatchListID = Request.QueryString("watchlistid")
        strCompanyID = Request.QueryString("companyid")

        If IsPostBack() Then
            Dim strPostbackFunctionToCall As String = Request("__EVENTTARGET")
            Dim strParams() As String = Request("__EVENTARGUMENT").ToString.Split("|")

            If strPostbackFunctionToCall = "LoadCompany" OrElse strPostbackFunctionToCall = "fvFundamentalDataPoints" Then
                strCompanyID = strParams(0)
                strWatchListID = strParams(1)

                If Not IsNumeric(strCompanyID) Then
                    'posting back from search box

                    Dim i As Integer = InStr(strSearchString, "(") + 1
                    Dim j As Integer = InStr(strSearchString, ")")
                    Dim strStockSymbol As String = Strings.Mid(strSearchString, i, j - i)

                    Dim params(0) As SqlClient.SqlParameter
                    params(0) = New SqlClient.SqlParameter("@strSymbol", SqlDbType.VarChar)
                    params(0).Value = strStockSymbol

                    Dim dsSPResults As DataSet = RunSP("dbo.spGetCompanyIDFromSymbol", params)
                    Try
                        If dsSPResults.Tables.Count > 0 Then
                            If dsSPResults.Tables(0).Rows.Count > 0 Then
                                strCompanyID = dsSPResults.Tables(0).Rows(0).Item("intCompanyID")
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                End If

                If IsNumeric(strWatchListID) Then
                    GetWatchlistNameFromID(strWatchListID)
                ElseIf strWatchListID = "current" Then
                    strWatchListID = hfCurrentWatchlistID.Value
                    If strWatchListID = String.Empty Then
                        GetUserFirstWatchlist()
                    Else
                        GetWatchlistNameFromID(strWatchListID)

                    End If
                Else
                    GetWatchlistNameFromID(strWatchListID)
                    'lblListName.Text
                    'this should not happen
                    GetUserFirstWatchlist()
                End If
            ElseIf strPostbackFunctionToCall.Contains("btnDeleteWatchlist") Then 'Delete watchlist
                Dim paramsWL1(1) As SqlClient.SqlParameter
                paramsWL1(0) = New SqlClient.SqlParameter("@strUserName", SqlDbType.NVarChar)
                paramsWL1(0).Value = Context.User.Identity.Name
                paramsWL1(1) = New SqlClient.SqlParameter("@intUserWatchlistID", SqlDbType.Int)
                paramsWL1(1).Value = hfCurrentWatchlistID.Value
                Dim dsSPResultsWL1 As DataSet = RunSP("dbo.spDeleteUserWatchlist", paramsWL1)

                Response.Redirect("/Default.aspx")

            ElseIf strPostbackFunctionToCall.Contains("btnSaveUserWatchlists") OrElse strPostbackFunctionToCall.Contains("ddlUserWatchlists") Then 'Add to watchlist
                Dim ddlUserWatchlists As DropDownList = fvFundamentalDataPoints.FindControl("ddlUserWatchlists")
                Dim lblWatchlistStockSymbol As Label = fvFundamentalDataPoints.FindControl("lblWatchlistStockSymbol")
                Dim intUserWatchlistID As Integer = Nothing
                Dim hfListName As HiddenField = fvFundamentalDataPoints.FindControl("hfListName")

                If ddlUserWatchlists.SelectedValue = -1 Then
                    'create and get id of new list
                    Dim paramsWL1(1) As SqlClient.SqlParameter
                    paramsWL1(0) = New SqlClient.SqlParameter("@strUserName", SqlDbType.NVarChar)
                    paramsWL1(0).Value = Context.User.Identity.Name
                    paramsWL1(1) = New SqlClient.SqlParameter("@strWatchlistName", SqlDbType.VarChar)
                    paramsWL1(1).Value = hfListName.Value
                    Dim dsSPResultsWL1 As DataSet = RunSP("dbo.spInsertWatchlistName", paramsWL1)

                    Dim paramsWL2(1) As SqlClient.SqlParameter
                    paramsWL2(0) = New SqlClient.SqlParameter("@strUserName", SqlDbType.NVarChar)
                    paramsWL2(0).Value = Context.User.Identity.Name
                    paramsWL2(1) = New SqlClient.SqlParameter("@strWatchlistName", SqlDbType.VarChar)
                    paramsWL2(1).Value = hfListName.Value
                    Dim dsSPResultsWL2 As DataSet = RunSP("dbo.spGetUserWatchListIDFromName", paramsWL2)
                    Try
                        If dsSPResultsWL2.Tables.Count > 0 Then
                            If dsSPResultsWL2.Tables(0).Rows.Count > 0 Then
                                intUserWatchlistID = dsSPResultsWL2.Tables(0).Rows(0).Item("intUserWatchlistID")
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                Else
                    intUserWatchlistID = ddlUserWatchlists.SelectedValue
                End If

                Dim params(1) As SqlClient.SqlParameter
                params(0) = New SqlClient.SqlParameter("@intUserWatchlistID", SqlDbType.Int)
                params(0).Value = intUserWatchlistID
                params(1) = New SqlClient.SqlParameter("@strStockSymbol", SqlDbType.VarChar)
                params(1).Value = lblWatchlistStockSymbol.Text
                Dim dsSPResults As DataSet = RunSP("dbo.spInsertCompanyIntoUserWatchlist", params)

                Dim params2(0) As SqlClient.SqlParameter
                params2(0) = New SqlClient.SqlParameter("@strSymbol", SqlDbType.VarChar)
                params2(0).Value = lblWatchlistStockSymbol.Text
                Dim dsSPResults2 As DataSet = RunSP("dbo.spGetCompanyIDFromSymbol", params2)
                Try
                    If dsSPResults2.Tables.Count > 0 Then
                        If dsSPResults2.Tables(0).Rows.Count > 0 Then
                            strCompanyID = dsSPResults2.Tables(0).Rows(0).Item("intCompanyID")
                        End If
                    End If
                Catch ex As Exception
                End Try

                Response.Redirect("/Default.aspx?watchlistid=" & intUserWatchlistID & "&companyid=" & strCompanyID)
            End If
        Else
            If strWatchListID = String.Empty Then
                GetUserFirstWatchlist()
            Else
                GetWatchlistNameFromID(strWatchListID)
            End If
        End If

        If strCompanyID = String.Empty Then
            Dim params(0) As SqlClient.SqlParameter
            params(0) = New SqlClient.SqlParameter("@intWatchlistID", SqlDbType.Int)
            params(0).Value = strWatchListID

            Dim dsSPResults As DataSet = RunSP("dbo.spGetFirstItemInWatchlistByID", params)
            Try
                If dsSPResults.Tables.Count > 0 Then
                    If dsSPResults.Tables(0).Rows.Count > 0 Then
                        strCompanyID = dsSPResults.Tables(0).Rows(0).Item("intCompanyID")
                    End If
                End If
            Catch ex As Exception
            End Try
        End If

        'load variables here
        lblListName.Text = strWatchlistName
        hfCurrentWatchlistID.Value = strWatchListID
        dsGetWatchlistByID.SelectParameters("intWatchlistID").DefaultValue = strWatchListID
        rssWatchListRepeater.DataBind()

        dsGetAllDataPointsForASingleStock.SelectParameters("intCompanyID").DefaultValue = strCompanyID
        fvFundamentalDataPoints.DataBind()

        'Get Market Prices
        Dim strResults As String = GetMarketPriceYQL("^GSPC")
        Dim strMarketPriceData() As String = strResults.Split("|")

        lblSPXMarketPrice.Text = strMarketPriceData(0)
        lblSPXMarketPriceChange.Text = strMarketPriceData(1)
        If strMarketPriceData(1)(0) = "-" Then
            lblSPXMarketPriceChange.CssClass = "color-red"
        Else
            lblSPXMarketPriceChange.CssClass = "color-green"
        End If

    End Sub

#Region "Form Controls"
    Public Sub rssWatchListRepeater_OnItemDataBound(ByVal sender As Object, ByVal e As RepeaterItemEventArgs)
            Dim myWatchListRepeater As Repeater = sender

            If e.Item.ItemType = ListItemType.Item OrElse e.Item.ItemType = ListItemType.AlternatingItem Then
                Dim lblCompanyScoreAbbrv As Label = e.Item.FindControl("lblCompanyScoreAbbrv")

                If Not IsNothing(lblCompanyScoreAbbrv) Then
                    If lblCompanyScoreAbbrv.Text = "VS" Then
                        lblCompanyScoreAbbrv.CssClass = "badge badge-success"
                    ElseIf lblCompanyScoreAbbrv.Text = "S" Then
                        lblCompanyScoreAbbrv.CssClass = "badge badge-success"
                    ElseIf lblCompanyScoreAbbrv.Text = "N+" Then
                        lblCompanyScoreAbbrv.CssClass = "badge badge-warning"
                    ElseIf lblCompanyScoreAbbrv.Text = "N" Then
                        lblCompanyScoreAbbrv.CssClass = "badge badge-warning"
                    ElseIf lblCompanyScoreAbbrv.Text = "W" Then
                        lblCompanyScoreAbbrv.CssClass = "badge badge-danger"
                    ElseIf lblCompanyScoreAbbrv.Text = "VW" Then
                        lblCompanyScoreAbbrv.CssClass = "badge badge-danger"
                    End If
                End If
            End If

        End Sub
    Public Sub lblCompanyOverallRating_OnPreRender(ByVal sender As Object, ByVal e As EventArgs)
        Dim lblCompanyOverallRating As Label = sender

        'set the class
        Dim strNewClass As String = String.Empty
        If lblCompanyOverallRating.Text.Contains("STRONG") Then
            strNewClass = " label-success"
        ElseIf lblCompanyOverallRating.Text.Contains("NEUTRAL") Then
            strNewClass = " label-warning"
        ElseIf lblCompanyOverallRating.Text.Contains("WEAK") Then
            strNewClass = " label-danger"
        End If

        lblCompanyOverallRating.CssClass = lblCompanyOverallRating.CssClass.ToString & strNewClass
    End Sub
    Public Sub lblCompanyIVRank_OnPreRender(ByVal sender As Object, ByVal e As EventArgs)
        Dim lblCompanyIVRank As Label = sender
        Dim strNewClass As String = String.Empty
        Try
            Dim intIVRank = CInt(lblCompanyIVRank.Text)

            'set the class
            If intIVRank >= 50 Then
                strNewClass = " label-success"
            ElseIf intIVRank >= 40 Then
                strNewClass = " label-warning"
            Else
                strNewClass = " label-danger"
            End If
        Catch ex As Exception
        End Try

        lblCompanyIVRank.CssClass = lblCompanyIVRank.CssClass.ToString & strNewClass
    End Sub
    Public Sub lblRSPercentile_OnPreRender(ByVal sender As Object, ByVal e As EventArgs)
        Dim lblRSPercentile As Label = sender

        Dim strNewClass As String = String.Empty
        Try
            Dim intRSPercentile = CInt(lblRSPercentile.Text)

            'set the class
            If intRSPercentile >= 75 Then
                strNewClass = " label-success"
            ElseIf intRSPercentile >= 50 Then
                strNewClass = " label-warning"
            Else
                strNewClass = " label-danger"
            End If
        Catch ex As Exception
        End Try

        lblRSPercentile.CssClass = lblRSPercentile.CssClass.ToString & strNewClass
    End Sub
    Public Sub fvFundamentalDataPoints_OnDataBound(ByVal sender As Object, ByVal e As EventArgs)
        Dim fvFundamentalDataPoints As FormView = sender
        Dim lblStockSymbol As Label = fvFundamentalDataPoints.FindControl("lblStockSymbol")
        Dim lblMarketPrice As Label = fvFundamentalDataPoints.FindControl("lblMarketPrice")
        Dim lblMarketPriceChange As Label = fvFundamentalDataPoints.FindControl("lblMarketPriceChange")

        Dim strPriceResults() As String = GetStockPrice(lblStockSymbol.Text)

        lblMarketPrice.Text = strPriceResults(0)
        lblMarketPriceChange.Text = strPriceResults(1)
        If strPriceResults(1)(0) = "-" Then
            lblMarketPriceChange.CssClass = "color-red"
        Else
            lblMarketPriceChange.CssClass = "color-green"
        End If

        upFundamentalDataPoints.Update()
    End Sub
    Public Sub ColorTrueFalse(ByVal sender As Object, ByVal e As EventArgs)
        Dim myLabel As Label = sender
        Dim strNewClass As String = String.Empty

        If myLabel.Text = "TRUE" Then
            strNewClass = " label-success"
        ElseIf myLabel.Text = "FALSE" Then
            strNewClass = " label-danger"
        End If

        myLabel.CssClass = myLabel.CssClass.ToString & strNewClass
    End Sub
    Public Sub ColorDaysTillEarnings(ByVal sender As Object, ByVal e As EventArgs)
        Dim myLabel As Label = sender
        Dim strNewClass As String = String.Empty
        Try
            Dim intIVDays = CInt(myLabel.Text)

            'set the class
            If intIVDays >= 45 Then
                strNewClass = " label-success"
            ElseIf intIVDays >= 30 Then
                strNewClass = " label-warning"
            Else
                strNewClass = " label-danger"
            End If
        Catch ex As Exception
        End Try

        myLabel.CssClass = myLabel.CssClass.ToString & strNewClass
        myLabel.Text &= " Days"
    End Sub
    Public Sub ColorPassFail(ByVal sender As Object, ByVal e As EventArgs)
        Dim myLabel As Label = sender
        Dim strNewClass As String = String.Empty

        If myLabel.Text = "PASS" Then
            strNewClass = " label-success"
        ElseIf myLabel.Text = "FAIL" Then
            strNewClass = " label-danger"
        End If

        myLabel.CssClass = myLabel.CssClass.ToString & strNewClass
    End Sub
#End Region

#Region "Watchlist"
    Public Sub ddlUserWatchlists_OnPreRender(ByVal sender As Object, ByVal e As EventArgs)
        dsGetWatchListsForAUser.SelectParameters("strUserName").DefaultValue = Context.User.Identity.Name
    End Sub
    Public Sub btnDeleteWatchlist_OnClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim x = 1
    End Sub
#End Region

#Region "Functions"
    Function GetMarketPriceYQL(strSymbol As String) As String
        Dim strMarketPrice As String = "N/A|N/A"

        Dim strURLEncodedSymbol As String = strSymbol.Replace("/", "%27")
        strURLEncodedSymbol = strURLEncodedSymbol.Replace(".", "%27")

        'Single stock
        Dim URI As String = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22" & strURLEncodedSymbol & "%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback="

        'you can give it a list of stocks
        'but you got to change the class to a list
        'Dim URI As String = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(%22" & strURLEncodedSymbol & "%22,%22GOOG%22)&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback="

        Dim webClient As New WebClient()
        Dim strResponseString = String.Empty

        Dim intServerRetry As Integer = 0
        Dim intRetryNumber As Integer = 0
RETRY:
        Try
            strResponseString = webClient.DownloadString(URI).ToUpper
        Catch ex As WebException
            If TypeOf ex.Response Is HttpWebResponse Then
                Select Case DirectCast(ex.Response, HttpWebResponse).StatusCode
                    Case HttpStatusCode.NotFound

                    Case HttpStatusCode.InternalServerError
                        If intServerRetry = 0 Then
                            intServerRetry += 1
                            Dim SW2 As New Stopwatch
                            SW2.Restart()
                            Do

                            Loop Until SW2.ElapsedMilliseconds >= 2000

                            GoTo RETRY
                        End If

                    Case Else
                End Select
            End If
        End Try

        If strResponseString = "" Then
            intRetryNumber += 1
            If intRetryNumber > 5 Then
                Return strMarketPrice
            End If
            GoTo RETRY
        End If
        If strResponseString.Contains(">THIS FEATURE CURRENTLY IS UNAVAILABLE FOR") Then
            Return strMarketPrice
        End If

        strResponseString = strResponseString.Replace("NULL", """NULL""")
        Dim oJSONStuff As New YQLRootObject
        oJSONStuff = Newtonsoft.Json.JsonConvert.DeserializeObject(Of YQLRootObject)(strResponseString)

        Dim strMarketPriceData As String = oJSONStuff.QUERY.RESULTS.QUOTE.ASK & "|" & oJSONStuff.QUERY.RESULTS.QUOTE.CHANGE

        Return strMarketPriceData
    End Function
    Public Function GetStockPrice(strSymbol As String) As String()
        'Get Market Prices
        Dim strResults As String = GetMarketPriceYQL(strSymbol)
        Dim strMarketPriceData() As String = strResults.Split("|")

        Return strMarketPriceData
    End Function
    Sub GetWatchlistNameFromID(strWatchlistID As String)
        Dim params(0) As SqlClient.SqlParameter
        params(0) = New SqlClient.SqlParameter("@intWatchlistID", SqlDbType.Int)
        params(0).Value = strWatchlistID

        Dim dsSPResults As DataSet = RunSP("dbo.spGetWatchListsName", params)
        Try
            If dsSPResults.Tables.Count > 0 Then
                If dsSPResults.Tables(0).Rows.Count > 0 Then
                    strWatchlistName = dsSPResults.Tables(0).Rows(0).Item("strWatchlistName")
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub
    Sub GetUserFirstWatchlist()
        'if there is no id, get the top list and load that
        Dim params(0) As SqlClient.SqlParameter
        params(0) = New SqlClient.SqlParameter("@strUserName", SqlDbType.VarChar)
        params(0).Value = Context.User.Identity.Name.ToString

        Dim dsSPResults As DataSet = RunSP("dbo.spGetFirstWatchListsForAUser", params)
        Try
            If dsSPResults.Tables.Count > 0 Then
                If dsSPResults.Tables(0).Rows.Count > 0 Then
                    strWatchlistName = dsSPResults.Tables(0).Rows(0).Item("strWatchlistName")
                    strWatchListID = dsSPResults.Tables(0).Rows(0).Item("intUserWatchlistID")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Search API"
    <System.Web.Script.Services.ScriptMethod> <System.Web.Services.WebMethod> Public Shared Function GetStockList(prefixText As String) As List(Of String)
        Dim dt As New DataTable()

        Dim params(0) As SqlClient.SqlParameter
        params(0) = New SqlClient.SqlParameter("@strSearchVariable", SqlDbType.VarChar)
        params(0).Value = prefixText

        'This inserts to the tblPatients Table AND gets back the intPatientID
        Dim dsSPResults As DataSet = RunSP("dbo.spGetCompanyListForSearch", params)
        'Dim dsSPResults As DataSet = Nothing

        If dsSPResults.Tables.Count > 0 Then
            dt = dsSPResults.Tables(0)
        End If

        Dim CompanyNames As New List(Of String)()
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim strStockName As String = dt.Rows(i)(1).ToString() & "(" & dt.Rows(i)(0).ToString().ToUpper & ")"
            CompanyNames.Add(strStockName)
        Next

        Return CompanyNames
    End Function
#End Region

#Region "Stored Procedure"
    Public Shared Function RunSP(ByVal p_SP As String, Optional ByVal params() As SqlClient.SqlParameter = Nothing) As DataSet
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
    End Function

    'check the progress here.
    'Dim params(1) As SqlClient.SqlParameter
    'params(0) = New SqlClient.SqlParameter("@strSymbol", SqlDbType.VarChar)
    'params(0).Value = hfWaitingForStockToProcessName.Value.ToUpper
    'params(1) = New SqlClient.SqlParameter("@UserName", SqlDbType.NVarChar)
    'params(1).Value = Context.User.Identity.Name.ToString

    'Dim dsSPResults As DataSet = RunSP("dbo.spGetStatusOfOnDemandSymbol", params)
    'Try
    '   If dsSPResults.Tables.Count > 0 Then
    '      If dsSPResults.Tables(0).Rows.Count > 0 Then
    '             bitSymbolInsertedIntoMasterTable = dsSPResults.Tables(0).Rows(0).Item("bitSymbolInsertedIntoMasterTable")
    '   End If
    '   End If
    'Catch ex As Exception
    'End Try

#End Region
End Class