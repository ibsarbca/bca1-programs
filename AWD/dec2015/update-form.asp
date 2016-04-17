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

<% do until rs.EOF %>
<form action="update-form-2.asp" method="get">
PRICE: <input type="text" name="price" value="<%=rs.fields.item("price").value%>" > <br>
NAME: <input type="text" name="name" value="<%=rs.fields.item("product_name").value%>" ><br>
EXPIRY DATE: <input type="text" name="expiry_date" value="<%=rs.fields.item("expiry_date").value%>" ><br>

<input type="hidden" name="id" value="<%=rs.fields.item("product_id").value%>" >

<input type="submit" value="Submit">
</form>

<%
rs.moveNext
loop
%>

</body>
</html>

