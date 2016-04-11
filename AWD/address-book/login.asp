<html>
<head>
<title>Address Book | Login</title>
</head>
<body>
	<center>
	<!-- #include file="header.inc" -->

	<h3> Please provide login details </h3>
	<!-- This displays the error message -->
	<font color='red'><%=Request.QueryString("m")%></font>
	<form action
		<p>User ID: <input type="text" name="txtId"></p>
		<p>Password: <input type="password" name='txtPwd'></pwd>
		<br />
		<p><input type="submit" name="subBtn" value="Login">
		<input type="reset" value="Reset"></p>
	</form>
<%
' Create connection and get the record set, if successful, redirect user to view.asp
if request.form("subBtn") = "Login" then
	set conn=Server.CreateObject("ADODB.Connection")
	conn.Provider="Microsoft.Jet.OLEDB.4.0"
	conn.Open Request.ServerVariables("APPL_PHYISICAL_PATH") & "addressbook.mdb"
	set rs = Server.CreateObject("ADODB.RecordSet")
	rs.open "SELECT id, user_name, user_password FROM users WHERE user_name = '" & trim(request.form("txtId")) & "' AND user_password = '" & trim(request.form("txtPwd")) & "'", conn

	' If there are no records then reload page with variable m set to invalid user
	' Otherwise create a Session variable and redirect the user to view.asp
	if rs.EOF then
		response.redirect("login.asp?m=Invalid user id or password")
	else
		Session.timeout = 5
		Session("user") = request.form("txtId")
		response.redirect("view.asp")
	end if
end if
%>
<!-- #include file="footer.inc" -->
</center>
</body>
</html>
