<html>
<head>
<title>Address book | Add status </title>
<%
' Redirect user if session expired
if Session("user") = "" then
	response.redirect("login.asp?m=" & Application("login_message"))
end if
%>
</head>
<body>
<center>
<!-- #include file="header.inc" -->
<%
' Connect to database
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "addressbookdsn"

sql = "INSERT INTO detail (contact_name, phone) values"
sql = sql & "('" & request.form("txtName") & "', "
sql = sql & "'" & request.form("txtNo") & "')"


' This part starts a section of the code where we expect an error. If an error is detected, we move ahead
on error resume next
conn.execute sql
if err then
	response.write("Error: ")
	response.write(err.description)
else
	response.write "<br />"
	response.write request.form("txtName") & " "
	response.write request.form("txtNo")& " "
	response.write("<br><h3>Added successfully</h3><br>")
end if
conn.close
on error goto 0
' End that section where we expect an error

%>
<!-- #include file="footer.inc" -->
</center>
</body>
</html>
