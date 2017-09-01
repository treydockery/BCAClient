<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Chart.aspx.vb" Inherits="BCAClient.Chart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                                                    <!-- make a page with just the chart in it and call that in an iframe. -->
                                                        <!-- TradingView Widget BEGIN -->
                                                        <script type="text/javascript" src="https://d33t3vvu2t2yu5.cloudfront.net/tv.js"></script>
                                                        <script type="text/javascript">
                                                        new TradingView.widget({
                                                            "width": "100%",
                                                            "symbol": "AAPL",
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
                                                        </script>
                                                        <!-- TradingView Widget END --><%--"symbol": "<%#Eval("strStockSymbol")%>",--%>
    </div>
    </form>
</body>
</html>
