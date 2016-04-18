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

sql_statement = "SELECT * FROM emp_details WHERE dept = 'IT'"
' emp_datails is our table name

set rs =  Server.CreateObject("ADODB.RecordSet")
rs.open sql_statement, conn

' Sort the recordset departmentwise, and namewise
' rs.sort="dept, emp_name ASC" 
%>

EMPLOYEES IN IT DEPARTMENT:<br>
<%
do until rs.eof
	response.write(rs.fields.item("emp_name").value & "<br>")
	rs.moveNext
loop

' Close this recordset so we can make a new one
rs.close
%>
<br /><br /><br /><br />
<%
' Now we do the same for the Sales department
sql_statement = "SELECT * FROM emp_details WHERE dept='Sales'"
rs.Open sql_statement, conn
%>


EMPLOYEES IN SALES DEPARTMENT:<br>
<%
do until rs.eof
	response.write(rs.fields.item("emp_name").value&"<br>")
	rs.moveNext
loop

' Close this recordset 
rs.close
%>


</body>
</html>
