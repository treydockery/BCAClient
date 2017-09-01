<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BulkInsert.aspx.vb" Inherits="DoctorPortal.BulkInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl1" runat="server" Text="CSV 1 Account Per Row"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="LName, FName, Email"></asp:Label>
        <br />
        <asp:textbox ID="txtUserInfo" runat="server" TextMode="MultiLine" Rows="10" Width="500" ></asp:textbox>
        <br />
        <asp:Button ID="btnTreysButton" runat="server" OnClick="btnTreysButton_OnClick" Text="Click Me!" />
    </div>
    </form>
</body>
</html>
