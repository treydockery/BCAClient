<%@ Page Title="Blue Chip Authority" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="BCAClient._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
<style>
    /*Stuff I added.  Needs to go to CSS file
        Changed line to test github
    */
    .stock {
        height: 42px;
        background-color: rgb(84, 84, 84);
        border-bottom: 1px solid #adadad;
        font-weight: bold;
        background-color: white;
        background-image: -webkit-linear-gradient(bottom, #e8e8e8 0%, #ffffff 100%);
        background-image: linear-gradient(bottom, #e8e8e8 0%, #ffffff 100%);
        background-image: -o-linear-gradient(bottom, #e8e8e8 0%, #ffffff 100%);
        background-image: -moz-linear-gradient(bottom, #e8e8e8 0%, #ffffff 100%);
        background-image: -webkit-linear-gradient(bottom, #e8e8e8 0%, #ffffff 100%);
        /*background-image: -ms-linear-gradient(bottom, #e8e8e8 0%, #ffffff 100%);*/
        background-image: -webkit-gradient( linear, left bottom, left top, color-stop(0, #e8e8e8), color-stop(1, #ffffff) );
        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#e8e8e8', endColorstr='#ffffff');
        outline: none;
    }
    .stock.selected {
        background-color: white;
        background-image: -webkit-linear-gradient(bottom, #1055EC 0%, #4574EE 100%);
        background-image: linear-gradient(bottom, #1055EC 0%, #4574EE 100%);
        background-image: -o-linear-gradient(bottom, #1055EC 0%, #4574EE 100%);
        background-image: -moz-linear-gradient(bottom, #1055EC 0%, #4574EE 100%);
        background-image: -webkit-linear-gradient(bottom, #1055EC 0%, #4574EE 100%);
        /*background-image: -ms-linear-gradient(bottom, #1055EC 0%, #4574EE 100%);*/
        background-image: -webkit-gradient( linear, left bottom, left top, color-stop(0, #1055EC), color-stop(1, #4574EE) );
        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#1055EC', endColorstr='#4574EE');
    }
    .stock.unfocus {
        background: gray;
    }

</style>
<!-- page specific scripts -->

<!-- page application js -->
<script src="js/ui-dialogs.js"></script>

<asp:SqlDataSource ID="dsGetWatchlistByID" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
    SelectCommand="dbo.spGetWatchlistByID" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:Parameter Name="intWatchlistID" />
    </SelectParameters>
</asp:SqlDataSource>
<asp:SqlDataSource ID="dsGetAllDataPointsForASingleStock" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
    SelectCommand="dbo.spGetAllDataPointsForASingleStock" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:Parameter Name="intCompanyID" />
    </SelectParameters>
</asp:SqlDataSource>
<asp:SqlDataSource ID="dsGetWatchListsForAUser" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
    SelectCommand="dbo.spGetWatchListsForAUser" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:Parameter Name="strUserName" />
    </SelectParameters>
</asp:SqlDataSource>
<div class="content container" style="margin:5px;">
    <script type="text/javascript">
        function fnChooseCompany(parameter) {
            //alert("inside function");
            //alert(parameter);
            __doPostBack('LoadCompany', parameter);
        }
        function fnAddNewList() {
            //alert("inside function");
            var strNewListName;

            strNewListName = document.getElementById('txtNewListName').value;
            if (strNewListName != "") {
                //alert(strNewListName);
                var hfname = document.getElementById('<%= fvFundamentalDataPoints.FindControl("hfListName").ClientID %>');
                hfname.value = strNewListName;
                //alert(hfname.value);

                document.getElementById('txtNewListName').value = "";
                var btnSaveUserWatchlists = document.getElementById('<%= fvFundamentalDataPoints.FindControl("btnSaveUserWatchlists").ClientID %>');
                btnSaveUserWatchlists.click();
           } else {
                alert("You must enter a Watchlist name.");
            }
        }
        function fnAreYouSure() {
            if (!confirm('Are you sure? This will delete THIS LIST and ALL symbols! \n\nCancel for NO. \nOK for YES.')) return false;
        }

    </script>
    <div class="row">
        <div class="col-lg-8 col-md-6 col-sm-12" style="">
            <asp:HiddenField ID="hfCurrentWatchlistID" runat="server" />
            <asp:Label ID="lblListName" runat="server" CssClass="h2 page-title"></asp:Label>
                <asp:LinkButton ID="btnDeleteWatchlist" runat="server" class="" style="" 
                    Text="<i class='fa fa-minus-circle fa-2x' style='padding-top:5px;color:red;'></i>" 
                    OnClientClick="return fnAreYouSure();"/>
                <i class="fa fa-pencil fa-2x" style="padding-top:5px;"></i>
        </div>
        <div class="col-lg-4 col-md-6 col-sm-12" style="">
            <h2 class="pull-right" style="font-size:1.2em">SPX: <asp:Label ID="lblSPXMarketPrice" runat="server" CssClass=""></asp:Label>
            <asp:Label ID="lblSPXMarketPriceChange" runat="server" CssClass=""></asp:Label>

            </h2>
        </div>
    </div><!-- Watchlist Name and Market Prices -->
    <div class="row" style="">
        <asp:UpdatePanel ID="upFundamentalDataPoints" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
            <ContentTemplate>
                <div class="col-sm-4 col-md-3">
                    <section class="widget">
                        <div class="list-group">
                            <asp:Label ID="lblStockSymbol" runat="server" Text="This list is Empty." Visible="false"></asp:Label>
                            <asp:Repeater ID = "rssWatchListRepeater" runat = "server" DataSourceID="dsGetWatchlistByID" OnItemDataBound="rssWatchListRepeater_OnItemDataBound">
                                <ItemTemplate>
                                    <a id="HyperLink1" runat="server" onclick=<%#"fnChooseCompany('" & Eval("intCompanyID") & "|" & Eval("intWatchlistID") & "')" %>
                                        href="javascript:void(0);" 
                                        class="list-group-item">
                                        <i class="fa fa-chevron-right pull-right"></i>
                                        <asp:Label ID="lblCompanyScoreAbbrv" runat="server" CssClass="badge" Text='<%#Eval("strCompanyScoreAbbrv")%>'></asp:Label>
                                        <asp:Label ID="lblStockSymbol" runat="server" Text='<%#Eval("strStockSymbol")%>'
                                            ToolTip='<%#Eval("strCompanyName")%>'></asp:Label>
                                    </a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </section>
                </div><!-- Selected Watch List List -->
                <div class="col-sm-8 col-md-9">
                    <asp:FormView ID="fvFundamentalDataPoints" runat="server" DataSourceID="dsGetAllDataPointsForASingleStock" 
                        Width="100%" DataKeyNames="strStockSymbol" OnDataBound ="fvFundamentalDataPoints_OnDataBound">
					    <ItemTemplate>
                            <div class="row">
                                <div class="col-lg-12 page-title">
                                    <div  style="float:left;clear:none;margin-right:20px;">
                                        <i class="fa fa-info-circle fa-2x" style="padding-top:5px;color:lightblue;"></i>
                                        <asp:LinkButton runat="server" ID="btnAddToWatchList" Text="<i class='fa fa-plus-circle fa-2x' style='padding-top:5px;color:#17c457;'></i>"
                                            ToolTip="Add to Watch List" data-toggle="modal" href="#stack1" data-backdrop="static"/>
                                    </div>
                                    <div style="float:left;clear:none;margin-right:20px;">
                                        <h2 style="margin:0px;"><asp:Label ID="lblStockSymbol" runat="server" CssClass="" Text='<%# Eval("strStockSymbol")%>'></asp:Label>
                                            <small>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblCompanyName" runat="server" CssClass="" Text='<%# Eval("strCompanyName")%>'></asp:Label>
                                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMarketPrice" runat="server" CssClass=""></asp:Label>
                                                <asp:Label ID="lblMarketPriceChange" runat="server" CssClass=""></asp:Label></small></h2>
                                    </div>
                                    <div  style="float:left;clear:both;">
                                        <h3 style="margin:0px 20px;">Rating:<asp:label ID="lblCompanyOverallRating" runat="server" CssClass="margin-left-10 label-bigbadge" 
                                            Text='<%#Eval("strOverallScore") %>' OnPreRender="lblCompanyOverallRating_OnPreRender"></asp:label></h3>
                                        </div>
                                    <div style="float:left;clear:both;">
                                        <h3 style="margin:0px 20px;">IV Rank:<asp:label ID="lblCompanyIVRank" runat="server" CssClass="margin-left-10 label-bigbadge" 
                                            Text='<%#Eval("strIVXPercentile") %>' OnPreRender="lblCompanyIVRank_OnPreRender"></asp:label></h3>
                                    </div>
                                    <div  style="float:left;clear:both;">
                                        <h3 style="margin:0px 20px;">RS Percentile:<asp:label ID="lblRSPercentile" runat="server" CssClass="margin-left-10 label-bigbadge" 
                                            Text='<%#Eval("strRSPercentile") %>' OnPreRender="lblRSPercentile_OnPreRender"></asp:label></h3>
                                        </div>
                                </div>
                            </div><!-- Ratings and Name -->
                            <div class="row">
                                <div class="col-lg-12">
                                    <section class="widget">
                                        <header>
                                            <h3>Stock Information and Fundamentals</h3>
                                            <div class="widget-controls" style="padding-top:10px;">
                                                <%--<a title="Options" href="#"><i class="glyphicon glyphicon-cog"></i></a>--%>
                                                <a data-widgster="expand" title="Expand" href="#"><i class="glyphicon glyphicon-chevron-up"></i></a>
                                                <a data-widgster="collapse" title="Collapse" href="#"><i class="glyphicon glyphicon-chevron-down"></i></a>
                                                <%--<a data-widgster="fullscreen" title="Close" href="#"><i class="glyphicon glyphicon-remove"></i></a>
                                                <a data-widgster="restore" title="Close" href="#"><i class="glyphicon glyphicon-remove"></i></a>--%>
                                            </div>
                                        </header>
                                        <div class="body no-margin">
                                            <div class="row modal-body">
                                                <h4 style="border-bottom:1px solid black;">Company Information</h4>
                                                <div class="col-sm-12 no-padding" style="">
                                                    <div class="col-lg-12 no-padding" style="font-weight:bold;">
                                                        <span class="modal-body">Sector:&nbsp;<%# Eval("strSector")%></span>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 no-padding" style="">
                                                        <span class="modal-body">S&P 500 Company?</span>
                                                        <asp:label ID="Label1" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strSP500") %>' OnPreRender="ColorTrueFalse"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 no-padding" style="">
                                                        <span class="modal-body">Weekly Options Available?</span>
                                                        <asp:label ID="Label2" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strIsWeeklyOption") %>' OnPreRender="ColorTrueFalse"></asp:label>

                                                    </div>
                                                    <div class="col-sm-12 col-md-6 no-padding" style="">
                                                        <span class="modal-body">Next Earnings:&nbsp;<%#Eval("strExpEarningsDate") %></span>
                                                        <asp:label ID="Label3" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("intDaysTillEarnings") %>' OnPreRender="ColorDaysTillEarnings"></asp:label>

                                                    </div>
                                                    <div class="col-sm-12 col-md-6 no-padding" style="">
                                                        <span class="modal-body">Previous Earnings: N/A</span><span style="margin-left:10px;" class="label label-success">N/A%</span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="row modal-body">
                                                    <h4 style="border-bottom:1px solid black;">
                                                    Fundamental Data Points
                                                </h4>
                                                <div class="col-sm-12 no-padding" style="">
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Analyst Rec</span>
                                                        <asp:label ID="Label4" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strAnalystRecommendationScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Days To Cover</span>
                                                        <asp:label ID="Label5" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strDaysToCoverScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Earnings Forecast</span>
                                                        <asp:label ID="Label6" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strEarningsForecastScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Earnings Growth</span>
                                                        <asp:label ID="Label7" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strEarningsGrowthScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Earnings Surprise</span>
                                                        <asp:label ID="Label8" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strEarningsSurpriseScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">EPS</span>
                                                        <asp:label ID="Label9" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strEPSScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Industry Earnings</span>
                                                        <asp:label ID="Label10" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strIndustryEarningsScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Insider Trading</span>
                                                        <asp:label ID="Label11" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strInsiderTradingScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">PEG Ratio</span>
                                                        <asp:label ID="Label12" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strPEGRatioScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Revenue</span>
                                                        <asp:label ID="Label13" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strRevenueScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">ROE</span>
                                                        <asp:label ID="Label14" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strROEScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                    <div class="col-sm-12 col-md-6 col-lg-4 no-padding" style="">
                                                        <span class="modal-body">Weighted Alpha</span>
                                                        <asp:label ID="Label15" runat="server" CssClass="margin-left-5 label" 
                                                            Text='<%#Eval("strWeightedAlphaScore") %>' OnPreRender="ColorPassFail"></asp:label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="visits-info well well-sm padding3">
                                                    Last updated on <%# CDate(Eval("dScored")).ToLongDateString %>
                                            </div>
                                        </div>
                                    </section>
                                </div>
                            </div><!-- Stock Information -->
                            <div class="row">
                                <div class="col-md-12 col-lg-12" style="">
                                    <section class="widget" style="">
                                        <header>
                                            <h3>
                                                Charting
                                                <%--<small>Next Widget</small>--%>
                                            </h3>
                                            <div class="widget-controls" style="padding-top:10px;">
                                                <%--<a title="Options" href="#"><i class="glyphicon glyphicon-cog"></i></a>--%>
                                                <a data-widgster="expand" title="Expand" href="#"><i class="glyphicon glyphicon-chevron-up"></i></a>
                                                <a data-widgster="collapse" title="Collapse" href="#"><i class="glyphicon glyphicon-chevron-down"></i></a>
                <%--                            <a data-widgster="fullscreen" title="Close" href="#"><i class="glyphicon glyphicon-remove"></i></a>
                                                <a data-widgster="restore" title="Close" href="#"><i class="glyphicon glyphicon-remove"></i></a>--%>
                                            </div>
                                        </header>
                                        <div class="body no-margin" style="">
                                            <div class="row modal-body" style="">
                                                <div class="col-lg-12 no-padding clearfix" style="" >
                                                    <!-- TradingView Widget BEGIN -->
                                                    <div id="tv-medium-widget-81cf7"></div>
                                                    <script type="text/javascript" src="https://d33t3vvu2t2yu5.cloudfront.net/tv.js"></script>
	                                                    <script type="text/javascript">
                                                    new TradingView.MediumWidget({
                                                        "container_id": "tv-medium-widget-81cf7",
                                                        "symbols": [
                                                            [
                                                                '<%#Eval("strCompanyName")%>',
                                                                '<%#Eval("strStockSymbol")%>'
                                                            ],
                                                        ],
                                                        "gridLineColor": "#e9e9ea",
                                                        "fontColor": "#83888D",
                                                        "underLineColor": "#dbeffb",
                                                        "trendLineColor": "#4bafe9",
                                                        "width": "100%",
                                                        "height": "100%",
                                                        "locale": "en"
                                                    });
                                                    </script><!-- Add top 3 competitors here, maybe -->
                                                    <!-- TradingView Widget END -->

                                                    <!-- TradingView Widget BEGIN -->
                                                    <div id="tv-medium-widget-81cf7-chart"></div>
                                                    <script type="text/javascript" src="https://d33t3vvu2t2yu5.cloudfront.net/tv.js"></script>
                                                    <script type="text/javascript">
                                                        try{
                                                            new TradingView.widget({
                                                                "container_id": "tv-medium-widget-81cf7-chart",
                                                                "width": "100%",
                                                                "symbol": "<%#Eval("strStockSymbol")%>",
                                                                "interval": "D",
                                                                "timezone": "America/New_York",
                                                                "theme": "White",
                                                                "style": "1",
                                                                "locale": "en",
                                                                "toolbar_bg": "#f1f3f6",
                                                                "enable_publishing": false,
                                                                "withdateranges": true,
                                                                "hide_side_toolbar": true,
                                                                "hideideas": true,
                                                                "studies": [
                                                                "KLTNR@tv-basicstudies",
                                                                "MASimple@tv-basicstudies"
                                                                ],
                                                                "show_popup_button": true,
                                                                "popup_width": "1000",
                                                                "popup_height": "650"
                                                            });
                                                        }
                                                        catch (e) {
                                                            alert('An error has occurred: ' + e.message);
                                                        }
                                                    </script>
                                                    <!-- TradingView Widget END -->
                                                </div>
                                            </div>
                                        </div>
                                    </section>
                                </div>
                            </div><!-- TradingView Widget Row -->
                            <div id="stack1" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" data-focus-on="input:first" style="display: none;">
                                <div class="modal-dialog">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                            <h4 class="modal-title">Manage Watchlists</h4>
                                        </div>
                                        <div class="modal-body">
                                            <div style="float:left;clear:both;margin-right:20px;">
                                                <div style="float:left;clear:none;margin-right:20px;">
                                                    <h2 style="margin:0px;"><asp:Label ID="lblWatchlistStockSymbol" runat="server" CssClass="" Text='<%# Eval("strStockSymbol")%>'></asp:Label>
                                                        <small>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label18" runat="server" CssClass="" Text='<%# Eval("strCompanyName")%>'></asp:Label></small></h2>
                                                </div>
                                                <div  style="float:left;clear:both;">
                                                    <h3 style="margin:0px 20px;">Rating:<asp:label ID="Label19" runat="server" CssClass="margin-left-10 label-bigbadge" 
                                                        Text='<%#Eval("strOverallScore") %>' OnPreRender="lblCompanyOverallRating_OnPreRender"></asp:label></h3>
                                                </div>
                                                <div style="float:left;clear:both;">
                                                    <h3 style="margin:0px 20px;">IV Rank:<asp:label ID="Label23" runat="server" CssClass="margin-left-10 label-bigbadge" 
                                                        Text='<%#Eval("strIVXPercentile") %>' OnPreRender="lblCompanyIVRank_OnPreRender"></asp:label></h3>
                                                </div>
                                                <div  style="float:left;clear:both;">
                                                    <h3 style="margin:0px 20px;">RS Percentile:<asp:label ID="Label24" runat="server" CssClass="margin-left-10 label-bigbadge" 
                                                        Text='<%#Eval("strRSPercentile") %>' OnPreRender="lblRSPercentile_OnPreRender"></asp:label></h3>
                                                </div>
                                            </div>
                                            <div style="float:left;clear:both;">
                                                <h4>Choose a Watchlist</h4>
                                            </div>
                                            <asp:DropDownList ID="ddlUserWatchlists" runat="server" class="select2 select-block-level form-group"
                                                DataSourceID="dsGetWatchListsForAUser" AppendDataBoundItems="true" OnPreRender="ddlUserWatchlists_OnPreRender"
                                                AutoPostBack="true" DataTextField="strWatchlistName" DataValueField="intUserWatchlistID" CausesValidation="true">
                                                <asp:ListItem Text="-- Select Watchlist --" Value="-1"></asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:HiddenField ID="hfListName" runat="server" />
                                        </div>
                                        <div class="modal-footer">
                                            <div style="float:left;clear:none;">
                                                <asp:LinkButton runat="server" class="btn btn-primary" 
                                                    data-toggle="modal" href="#stack2" data-backdrop="static"
                                                    style="" Text="<i class='fa fa-pencil' style='padding:0px;'></i>&nbsp;Add a New List" />
                                            </div>
                                            <button type="button" class="btn btn-danger" data-dismiss="modal">Don't Save</button>
                                            <asp:button ID="btnSaveUserWatchlists" runat="server" class="btn btn-success hide" UseSubmitBehavior="false" data-dismiss="modal"
                                                Text="Save Watchlist"></asp:button>
                                        </div>
                                    </div>
                                </div><!-- /.modal-content -->
                            </div><!-- /.modal-dialog -->
                            <div id="stack2" class="modal fade" tabindex="-1" data-focus-on="input:first" style="display: none;">
                                <div class="modal-dialog">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                            <h4 class="modal-title">Create New Watchlist</h4>
                                        </div>
                                        <div class="modal-body clearfix">
                                            <div  style="float:left;clear:both;padding-top:7px;">
                                                <h4 style="margin:0px 20px;">Name: </h4>
                                            </div>
                                             <div  style="float:left;clear:none;">
                                                <%--<asp:TextBox ID="txtNewListName2" runat="server" CssClass="margin-left-10 form-control"
                                                        placeholder="New List Name..."></asp:TextBox>--%>
                                                <input type="text" id="txtNewListName" name="txtNewListName" 
                                                    class="margin-left-10 form-control" placeholder="New List Name...">
                                            </div>
                                        </div>
                                        <div class="modal-footer">
                                            <button type="button" class="btn btn-danger" data-dismiss="modal">Don't Save</button>
                                            <button type="button" class="btn btn-success" data-dismiss="modal" 
                                                onclick="fnAddNewList()" >Save List Name</button>
                                        </div>
                                    </div>
                                </div><!-- /.modal-content -->
                            </div><!-- /.modal-dialog -->
                            </div>
                        </ItemTemplate>
				    </asp:FormView>
                </div><!-- Selected Stock Main Area & Watchlist -->
            </ContentTemplate>
        </asp:UpdatePanel>
    </div><!-- Selected Stock Main Area -->
</div><!-- Content Container -->
</asp:Content>
