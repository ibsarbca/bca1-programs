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

' Get RecordSet. This part will be common only when you are READING entries in a table. Here we only create it first
set rs = Server.CreateObject("ADODB.RecordSet")

' This problem requires two result sets.
' First we need to Select designation_no from Designation where designation_name = request.querystring

sql_statement = "SELECT design_no FROM designation WHERE design_name = '" & request.queryString("designations") & "'"

rs.Open sql_statement, conn


design_no = rs.fields.item("design_no").value

rs.close ' Close recordset so we can reassign it later.

' Select all columns from employee where design_no = what we got from form
sql_statement = "SELECT * FROM employee WHERE design_no = " & design_no 

rs.Open sql_statement, conn


%>

<table border="1" width=100%>
<tr>
	<td>EMPLOYEE NO.</td>
	<td>EMPLOYEE NAME</td>
	<td>DESIGNATION NO.</td>
	<td>DEPARTMENT NO.</td>
	<td>DEPARTMENT NAME</td>
	<td>SALARY</td>
</tr>
<% do until rs.eof %>
<tr>
	<td><%=rs.fields.item("emp_no").value%></td>
	<td><%=rs.fields.item("emp_name").value%></td>
	<td><%=rs.fields.item("design_no").value%></td>
	<td><%=rs.fields.item("dept_no").value%></td>
	<td><%=rs.fields.item("dept").value%></td>
	<td><%=rs.fields.item("salary").value%></td>
</tr>

<%
rs.movenext
loop
%>
</table>
</body>
</html>
