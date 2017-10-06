<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomerDetails._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Search By Date:
        <asp:TextBox runat="server" ID="txtSpecificDate" />
        <asp:Button runat="server" ID="btnSpecificDate" Text="GO" OnClick="btnSpecificDate_Click"/>
        <br />
        <hr />
        <br />
        Search By Date Range:
        <asp:TextBox runat="server" ID="txtStartDate" />
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox runat="server" ID="txtEndDate" />
        <asp:Button runat="server" ID="btnDateRange" Text="GO" OnClick="btnDateRange_Click"/>
        <br />
        <hr />
        <br />
        Search By Product No:
        <asp:TextBox runat="server" ID="txtProductNo" />
        <asp:Button runat="server" ID="btnProductNo" Text="GO" OnClick="btnProductNo_Click"/>
        <br />
        <hr />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
         
    </div>
    </form>
</body>
</html>
