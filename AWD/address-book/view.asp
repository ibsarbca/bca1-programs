<html>
<head>
	<title>Address Book | All Records</title>
<%
if Session("user") = "" then
	response.redirect("login.asp?m=session expired or direct access")
end if
%>
</head>
<body><center>
<!-- #include file="header.inc" -->


<%
' Create connection and get a set of records
set conn = Server.CreateObject("ADODB.Connection")
conn.Provider="Microsoft.Jet.OLEDB.4.0"
conn.Open Request.ServerVariables("APPL_PHYSICAL_PATH") & "addressbook.mdb"
set rs = Server.CreateObject("ADODB.RecordSet")
rs.Open = "SELECT id, contact_name, phone FROM detail", conn
%>

<h3>Following is the data currently in the database</h3>
<table border="1" width="40%" align="center">
	<tr>
		<th>Name</th>
		<th>Phone</th>
		<th>Action</th>
	</tr>
	<% do until rs.eof  %>
	<tr>
		<td><% response.write(rs.fields("contact_name")) %></td>

