<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TableRange._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Start:<asp:TextBox ID="txtStart" runat="server" />
        <br />
        End:<asp:TextBox ID="txtEnd" runat="server" />
        <br />
        <asp:Button ID="btnGo" runat="server" Text="GO!" OnClick="btnGo_Click" />
        <hr />
        <asp:Table ID="Table1" runat="server" BorderStyle="Solid"></asp:Table>
    </div>
    </form>
</body>
</html>
