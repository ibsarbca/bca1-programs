<html>
<head>
</head>
<body>

<%
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "practicalsdsn"

name = request.form("name")

sql_statement = "SELECT * FROM student WHERE student_name = '" & name & "'"

set rs = Server.CreateObject("ADODB.RecordSet")
rs.Open sql_statement, conn

%>

<table border="1" width=100%>
	<tr>
		<td>ID</td>
		<td>NAME</td>
		<td>COURSE</td>
	</tr>
	<tr>
		<td><%=rs.fields.item("student_id").value%></td>
		<td><%=rs.fields.item("student_name").value%></td>
		<td><%=rs.fields.item("course").value%></td>
	</tr>
</table>


