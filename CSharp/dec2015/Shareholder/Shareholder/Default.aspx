<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Shareholder._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     INSERT NEW RECORD: <br /><br /><br />
    <table>
        <tr>
        <td>
            Name:
        </td>
         <td>
             <asp:TextBox ID="txtName" runat="server" />
         </td>
        </tr>

        <tr>
        <td>
            Address:
        </td>
         <td>
             <asp:TextBox ID="txtAddress" runat="server" />
         </td>
        </tr>

        <tr>
        <td>
            Shares:
        </td>
         <td>
             <asp:TextBox ID="txtShares" runat="server" />
         </td>
        </tr>

        <tr>
        <td>
            ShareSrStart:
        </td>
         <td>
             <asp:TextBox ID="txtShareSrStart" runat="server" />
         </td>
        </tr>


        <tr>
        <td>
            ShareSrEnd:
        </td>
         <td>
             <asp:TextBox ID="txtShareSrEnd" runat="server" />
         </td>
        </tr>
    </table>

        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
