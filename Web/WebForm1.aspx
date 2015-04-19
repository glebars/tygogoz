<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="btnstuff"  Text="send mail"/>
        <asp:Button runat="server" ID="btnTestCache"  Text="test cache"/>
        <asp:Label runat ="server" ID="lblTestCache" Text="..." />
    </div>
    </form>
</body>
</html>
