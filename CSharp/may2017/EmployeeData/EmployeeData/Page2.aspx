<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="EmployeeData.Page2" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tr>
                <th>PAN</th>
                <th>NAME</th>
                <th>ADDR</th>
            </tr>
            <%
                    foreach(DataRow row in this.ds.Tables[0].Rows)
                    {
            %>
                        <td><%=row[0].ToString() %></td>
                        <td><%=row[1].ToString() %></td>
                        <td><%=row[2].ToString() %></td>
            <%
                    }
            %>
        </table>
    </div>
    </form>
</body>
</html>
