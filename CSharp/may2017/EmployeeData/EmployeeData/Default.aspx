<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmployeeData._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
        
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPAN" runat="server" Text="PAN:"></asp:Label>
        <asp:TextBox ID="txtPAN" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="btnSave" runat="server" Text="GO!" OnClick="btnSave_Click" />
    </div>
    </form>
</body>
</html>
