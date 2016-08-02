
<html>
<head>
<meta charset="utf-8">
</head>
<body>
<body>


<%
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "practicalsdsn"

' id = request.form("id")
name = request.form("name")
course = request.form("course")

sql_statement = "INSERT INTO student(student_name, course) VALUES('" & name & "', '" & course & "')"
' response.write(sql_statement)

conn.execute sql_statement

%>

</body>
</html>
