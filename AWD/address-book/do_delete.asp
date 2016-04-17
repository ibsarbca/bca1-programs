<html>
<head>
<title>Address Book | Delete status </title>
<%
' If session expired, redirect to login page with error message we set.
if Session("user") = "" then
	response.redirect("login.asp?m=" & Application("login_message"))
end if
%>
</head>
<body>
<center>
<!-- #include file="header.inc" -->
<%
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "addressbookdsn"

sql = "DELETE FROM detail WHERE id=" & request.form("txtId")
response.write(sql)

' This part starts a section of the code where we expect an error. If an error is detected, we move ahead
on error resume next
conn.execute sql
if err then
	response.write(err.description)
else
	response.write("<br><br>Record no " & request.form("txtId") & ": " & request.form("txtName") & " " & request.form("txtNo") & " deleted successfully!<br />")
end if
conn.close
on error goto 0
' End that section where we expect an error

%>

<!-- #include file="footer.inc" -->
</center>
</body>
</head>
