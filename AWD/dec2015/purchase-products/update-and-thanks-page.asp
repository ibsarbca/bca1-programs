<html>
<head>
<meta charset="utf-8">
</head>
<body>
<%
' Set connection. This will be common for all programs that connect to a database

set conn = Server.CreateObject("ADODB.Connection")
conn.Open "productdsn"

id = request.form("id")
quantity_purchased = request.form("qty")

sql_statement = "UPDATE product SET quantity = quantity - " & quantity_purchased & " WHERE product_id = " & id

conn.execute sql_statement

%>

THANK YOU FOR YOUR PURCHASE!

<a href="list-products.asp">Go back to product list</a>
</body>
</html>

