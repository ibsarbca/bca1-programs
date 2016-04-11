<html>
<head>
<title>Address Book | Delete </title>
<%
if Session("user") = "" then
	response.redirect("login.asp?m=" & Application("login_message"))
end if
%>

<%
' Connect to database and retrieve the set of records
set conn = Server.CreateObject("ADODB.Connection")
conn.Open "addressbookdsn"

id = request.querystring("id")
action = request.querystring("a")

set rs = Server.CreateObject("ADODB.Recordset")
rs.open "SELECT * FROM detail WHERE id=" & id, conn
%>
</head>
<body>
<center>
<!-- #include file="header.inc" -->
<h3>Address Book: <%=action%> Record</h3>
<form method="post" action="do_<%=action%>.asp">
<table align="center">
	<tr>
		<td>ID: </td>
		<td><%= rs.fields.item("id").value%></td>
	</tr>
	<tr>
		<td>Name: </td>
		<td><%=rs.fields.item("contact_name").value%></td>
	</tr>
	<tr>
		<td>Phone: </td>
		<td><%=rs.fields.item("phone").value%></td>
	</tr>
	<input type='hidden' name='txtId' value="<%=rs.fields.item("id").value%>" >
	<tr>
		<td colspan='2'>
			<input type='submit' value="<%=action%> record">
		</td>
	</tr>
</table>
</form>
<!-- #include file="footer.inc" -->
</body>
<%
rs.close
conn.close
%>
</html>
