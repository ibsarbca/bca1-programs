<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IsQueryStringEmpty.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%
            if (Request.QueryString.Keys.Count == 0)
            {
                Response.Write("Query String is empty");
            }
            else
            {
                foreach(string key in Request.QueryString.Keys)
                {
                    Response.Write(key+ " : " + Request.QueryString[key]);
                }
            }
                
         %>    
    </div>
    </form>
</body>
</html>
