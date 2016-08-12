<%
set obj = CreateObject("ADODB.Connection")
obj.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\mydb1.mdb"
Set rs=obj.Execute("select * from emp")
Response.write("<table border=1>")
Do While Not rs.EOF
Response.write("<tr>")
Response.write("<td>"&rs.Fields(0)&"</td>")
Response.write("<td>"&rs.Fields(1)&"</td>")
Response.write("<td>"&rs.Fields(2)&"</td>")
Response.write("<td>"&rs.Fields(3)&"</td>")
Response.write("</tr>")
rs.MoveNext
Loop
Response.write("</table>")
obj.Close
%>