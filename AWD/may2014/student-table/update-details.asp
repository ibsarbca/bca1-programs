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

std_name = request.queryString("name")
std_course = request.queryString("course")
id = request.QueryString("id")

sql_statement = "UPDATE student SET student_name='" & std_name & "', course = '" & std_course & "' WHERE student_id = " & id

conn.execute sql_statement
%>

UPDATE SUCCESSFUL!

</body>
</html>
