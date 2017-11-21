<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BankingApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username: <asp:TextBox runat="server" id="txtUsername"/><br />
            Password: <asp:TextBox runat="server" id="txtPassword" TextMode="Password"/>
            <br />
            <br />
            <asp:Button Text="Log in" ID="btnSubmit" OnClick="btnSubmit_Click" UseSubmitBehavior="true" runat="server" />
            <asp:HyperLink NavigateUrl="~/CreateUser.aspx" ID="lnkCreate" Text="New User?" runat="server" />
        </div>
        <asp:Label Text="" id="lblFail" runat="server" />
    </form>
</body>
</html>
