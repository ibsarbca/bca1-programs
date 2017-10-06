<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShoppingCart._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>Price</th>
                <th></th>
            </tr>
            
            <tr>
                <td>Table</td>
                <td>100</td>
                <td><asp:Button ID="btnTable" runat="server" Text="Add to Cart" OnClick="AddToCart"/></td>
            </tr>
            
            <tr>
                <td>Chair</td>
                <td>100</td>
                <td><asp:Button ID="btnChair" runat="server" Text="Add to Cart" OnClick="AddToCart"/></td>
            </tr>
            
            <tr>
                <td>Bottle</td>
                <td>100</td>
                <td><asp:Button ID="btnBottle" runat="server" Text="Add to Cart" OnClick="AddToCart"/></td>
            </tr>
        </table>
    </div>

    </form>
    <a href="Page2.aspx">View Cart</a>
</body>
</html>
