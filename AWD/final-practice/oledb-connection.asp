<html>
<%
set conn = Server.CreateObject("ADODB.Connection")
' conn.Open "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\database1.mdb;"
' conn.Open "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\database1.mdb;"
' conn.Open "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\database1.mdb;"
' conn.Open "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\database1.mdb;"
' conn.Open "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=F:\databas1.mdb;"
conn.Open "Provider=Micrsoft.JET.OLEDB.4.0; Data Source=F:\database1.mdb;"


set rs=Server.CreateObject("ADODB.RecordSet")
rs.Open "SELECT * FROM student", conn

do until rs.eof
	response.write(rs.fields.item("student_name").value)
	rs.moveNext
loop

%>
</html>
