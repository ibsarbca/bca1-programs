<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <b>Username:</b>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        
        <b>Password:</b>
        <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Login" />
        
       </div>
    </form>
</body>
</html>
