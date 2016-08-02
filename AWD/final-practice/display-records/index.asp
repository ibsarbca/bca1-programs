<html>
<head>
</head>
<body>

<%
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "practicalsdsn"

sql_statement = "SELECT * from student"

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
</table>

</body>
</html>
