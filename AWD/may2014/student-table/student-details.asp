<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
</head>
<body>

<%
' Set connection. This will be common for all programs that connect to a database

set conn = Server.CreateObject("ADODB.Connection")
conn.Open "practicalsdsn"

' DSN less method for connecting. If the method above doens't work, try this:
' conn.Provider="Microsoft.Jet.OLEDB.4.0"
' conn.Open Request.ServerVariables("APPL_PHYISICAL_PATH") & "database.mdb"
' database.mdb should be the name of your database

' Get RecordSet. This part will be common only when you are READING entries in a table

sql_statement = "SELECT * FROM student " 'student is our table name

set rs =  Server.CreateObject("ADODB.RecordSet")
rs.Open sql_statement, conn

%>

<table border="1" width=100%>
<tr>
	<td>ID</td>
	<td>NAME</td>
	<td>COURSE</td>
</tr>
<% do until rs.eof %>
<tr>
	<td><%=rs.fields.item("student_id").value%></td>
	<td><%=rs.fields.item("student_name").value%></td>
	<td><%=rs.fields.item("course").value%></td>
	<td>
		<a href="update-form.asp?id=<%=rs.fields.item("student_id").value%>" > Update</a>
	</td>
	<td>
		<a href="delete-form.asp?id=<%=rs.fields.item("student_id").value%>">Delete</a>
	</td>
</tr>

<%
rs.movenext
loop
%>

</table>
</body>
</html>
