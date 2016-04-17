<html>
<head>
<meta charset="utf-8">
</head>
<body>
<%
' Set connection. This will be common for all programs that connect to a database

set conn = Server.CreateObject("ADODB.Connection")
conn.Open "productdsn"

%>


<form action="update-and-thanks-page.asp" method="post">
PRODUCT NAME: <%=request.QueryString("name") %> <br>
SPECIFY QUANTITY: <input type="text" name="qty"> <br>
<input type="hidden" name="id" value="<%=request.queryString("id")%>" >
<input type="submit" value="BUY!">
</form>

<a href="list-products.asp">Go back to product list</a>
</body>
</html>

