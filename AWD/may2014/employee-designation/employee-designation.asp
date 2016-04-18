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

' Get RecordSet. This part will be common only when you are READING entries in a table

' Get all the designations from the Designation table
set rs = Server.CreateObject("ADODB.RecordSet")
rs.Open "SELECT * from designation",conn


' Sort the recordset departmentwise, and namewise
' rs.sort="dept, emp_name ASC" 
%>

<form action="designation-details.asp" method="get">
	<select name="designations">
		<% do until rs.eof %>
		<option value="<%=rs.fields.item("design_name").value%>" >
			<%=rs.fields.item("design_name").value%>
		</option>
		<%
		rs.movenext
		loop
		%>
	</select>
	<input type="submit" value="Display">
	<input type="reset" value="Reset">
</form>


</body>
</html>
