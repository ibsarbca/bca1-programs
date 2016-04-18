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

' Get the current details of the student and display it in the form.
set rs = Server.CreateObject("ADODB.RecordSet")
sql_statement = "SELECT * FROM student WHERE student_id = " & request.QueryString("id")
rs.Open sql_statement, conn

std_name = rs.fields.item("student_name").value
std_course = rs.fields.item("course").value
%>

<form action="update-details.asp" method="get">
	NAME: <input type="text" name="name" value="<%=std_name%>" >
	COURSE: <input type="text" name="course" value="<%=std_course%>" >
	<input type="hidden" name="id" value="<%=request.queryString("id")%> " >
	<input type="submit" value="Submit">
</form>
</body>
</html>
