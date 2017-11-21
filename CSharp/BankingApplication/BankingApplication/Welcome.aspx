<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="BankingApplication.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome <%=Session["usertype"] %></h1>
            <% if (Session["usertype"].ToString() == "Manager") { %>
               <asp:Table ID="table1" runat="server" GridLines="Both">
                   
               </asp:Table>
            <% } %>

        </div>
    </form>
</body>
</html>
