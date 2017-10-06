<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="Cookie.Page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
    <%
        HttpCookie cookie = Request.Cookies["cookie"];
        if (null != cookie)
            Response.Write(cookie.Value);
      %>
    </div>
    </form>
</body>
</html>
