<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cookie._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                
        <asp:TextBox ID="txtCookie" runat="server" />
        <asp:Button ID="btnCookie" runat="server" OnClick="btnCookie_Click" Text="Set Cookie" />
        <a href="Page2.aspx">Page 2</a>
        <a href="Page3.aspx">Page 3</a>
    </div>
    </form>
</body>
</html>
