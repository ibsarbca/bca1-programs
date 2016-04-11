<html>
<head>
<title>Address book | Update status</title>
<%
' Redirect to login page if session has expired
if Session("user") = "" then
	response.redirect("login.asp?m=" & Application("login_message"))
end if
%>
</head>
<body>
<center>
<%
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "addressbookdsn"

sql = "UPDATE detail SET "
sql = sql & "contact_name='" & request.form("txtName") & "', "
sql = sql & "phone='" & request.form("txtNo") & "' "
sql = sql & "WHERE id=" & request.form("txtId")

' This part starts a section of the code where we expect an error. If an error is detected, we move ahead
on error resume next
	conn.execute sql
	if err then
		response.write("Error! ")
		response.write(err.description)
	else
		response.write("<br><br>Record no " & request.form("txtId") & ":" & request.form("txtName") & " " & request.form("txtNo") & " was updated successfully!<br>")
end if
conn.close
on error goto 0
' End that section where we expect an error

%>

<!-- #include file="footer.inc" -->
</center>
</body>
</html>
