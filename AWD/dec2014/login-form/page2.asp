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

' Create RecordSet (but we don't fill it here)
set rs = Server.CreateObject("ADODB.RecordSet")

%>


<%
' Get the username and password entered in the login form
user = request.form("user")
pass = request.form("pass")

' Get recordset from users table
' Select all columns from users table where username = user and password = pass
sql_statement = "SELECT * FROM users WHERE username = '" & user & "' and password = '" & pass & "'"


rs.Open sql_statement, conn

' if rs isn't already empty
if not rs.eof then
	response.write("WELCOME!")
else
		response.write("INCORRECT USERNAME OR PASSWORD")
end if

%>
</body>
</html>
