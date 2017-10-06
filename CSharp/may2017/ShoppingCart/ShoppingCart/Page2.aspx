<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="ShoppingCart.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        HttpCookie cookie = Request.Cookies["cart"];        
     %>
     TABLES: <%=cookie.Values.Get("Tables")%>
     CHAIRS: <%=cookie.Values.Get("Chairs") %>
     BOTTLES: <%=cookie.Values.Get("Bottles") %>
    </div>
    </form>
</body>
</html>
