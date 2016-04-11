<html>
<head>
<title>Address Book | Add a record </title>
<%
' Redirect user if session expired
if Session("user") = "" then
	response.redirect("login.asp?m=" & Application("login_message"))
end if
%>
<script src="validation.js" type="text/javascript"></script>
</head>
<body onload="document.f1.txtName.focus()">
<center>
<!-- #include file="header.inc" -->
<form action="do_add.asp" name="f1" method="post" onsubmit="return checkform(f1)">
	<p id="errorText" style="color: red"></p>
	<p>Name: <input type="text" name="txtName"> </p>
	<p>Phone: <input type="text" name="txtNo"> </p>
	<p> <input type="submit" name="subBtn" value="Save"> 
	&nbsp;&nbsp;&nbsp;&nbsp;
	<input type="reset" value="Reset">
	</p>
</form>

<!-- #include file="footer.inc" -->
</center>
</body>
</html>
