<html>
<head>
<meta charset="utf-8">
</head>
<body>
<%
' Set connection. This will be common for all programs that connect to a database

set conn = Server.CreateObject("ADODB.Connection")
conn.Open "productdsn"

' DSN less method for connecting. If the method above doens't work, try this:
' conn.Provider="Microsoft.Jet.OLEDB.4.0"
' conn.Open Request.ServerVariables("APPL_PHYISICAL_PATH") & "database.mdb"
' database.mdb should be the name of your database


' Get RecordSet. This part will be common only when you are READING entries in a table

sql = "SELECT * FROM product" ' product is our table name

set rs =  Server.CreateObject("ADODB.RecordSet")
rs.Open sql, conn

%>

<table border="1" width="100%" style="border-collapse: collapse">
<tr>
<td>NAME</td>
<td>PRICE</td>
<td>QUANTITY</td>
</tr>
<% do while not rs.eof %>
<tr>
	<td><%=rs.fields.item("product_name").value%></td>
	<td><%=rs.fields.item("price").value%></td>
	<td><%=rs.fields.item("quantity").value%></td>
	<td>
		<a href="purchase-product.asp?id=<%= rs.fields.item("product_id").value%>&name=<%=rs.fields.item("product_name").value%>" >Buy Now!</a>
	</td>
</tr>
<%
rs.moveNext
loop
%>
</table>


</body>
</html>

