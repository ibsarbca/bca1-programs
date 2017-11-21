<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AddRemoveList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
                <asp:ListItem Text="Blue" />
                <asp:ListItem Text="Black" />
                <asp:ListItem Text="Green" />
                <asp:ListItem Text="Orange" />
            </asp:ListBox>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True"></asp:ListBox><br />
            <asp:Button Text=">>" ID="btnMoveLeft" OnClick="btnMoveLeft_Click" runat="server" />
            <asp:Button Text="<<" ID="btnMoveRight" OnClick="btnMoveRight_Click" runat="server" />
        </div>
    </form>
</body>
</html>
