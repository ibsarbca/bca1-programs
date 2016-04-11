<%
' If session cookie has expired, then redirect to login page
if Session("user") = "" then
	response.redirect("login.asp?m=session expired or direct access")
end if
%>

<%
' Create connection
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "addressbookdsn"

' Get the variables sent from login.asp using the GET method
id = Request.QueryString("id")
action = Request.QueryString("a")

' Get all the records where the id is the one we have here
set rs = Server.CreateObject("ADODB.RecordSet")
rs.open "SELECT * FROM detail WHERE id=" & id, conn
%>

<html>
<head>
	<title> Address Book | <%=action%> </title>
<script src="validation.js" type="text/javascript"></script>
</head>
<body>
<center>
<!-- #include file="header.inc" -->
<h3>Address Book : <%=action%> Record </h3>
<form method="post" action="do_<%=action%>.asp" name="f1" onsubmit="return checkform(f1)">
<table align="center">
	<tr>
		<td>ID: </td><td><%=rs.fields.item("id").value%></td>
	</tr>
	<tr>
		<td>Name: </td>
		<td>
			<input type='text' name='txtName' value='<%=rs.fields.item("contact_name").value%>' > 
		</td>
	</tr>
	<tr>
		<td>Phone: </td>
		<td>
			<input type='text' name='txtNo' value='<%=rs.fields.item("phone").value%>' >
		</td>
	</tr>
	<input type='hidden' name='txtId' value='<%=rs.fields.item("id").value%>' >
	<tr>
		<td colspan='2'>
			<input type='submit' value="<%=action%> record" >
		</td>
	</tr>
</table>
</form>

<!-- #include file="footer.inc" -->

<%
rs.close
conn.close
%>

</center>
</body>
</html>

