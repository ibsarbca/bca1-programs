<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="BankingApplication.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username: <asp:TextBox runat="server" id="txtUsername"/><br />
            <asp:TextBox runat="server" id="txtPassword1" TextMode="Password"/><br />
            <asp:TextBox runat="server" id="txtPassowrd2" TextMode="Password"/><br />
            <asp:RadioButtonList runat="server" ID="userType">
                <asp:ListItem Text="Manager" />
                <asp:ListItem Text="Admin" />
            </asp:RadioButtonList>

            <asp:Button Text="Submit" UseSubmitBehavior="true" ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" />
        </div>
    </form>
</body>
</html>
