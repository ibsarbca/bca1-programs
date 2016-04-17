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

' Get product_id of the record that was submitted 

id = request.queryString("id")

price = request.queryString("price")
name = request.queryString("name")
expiry_date = request.queryString("expiry_date")


' Update table product where the product_id was the one which was submitted

sql = "UPDATE product SET price = '" & price & "', product_name = '" & name & "', expiry_date = '" & expiry_date & "' WHERE product_id=" & id

response.write sql

conn.execute sql
conn.close

' Once we are done, send the user back to the old page
response.redirect("update-form.asp")

%>




</body>
</html>

