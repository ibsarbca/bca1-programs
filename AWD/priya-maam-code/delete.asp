<%
set obj = CreateObject("ADODB.Connection")
obj.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\mydb1.mdb"
sql="delete from emp where emp_no=8"
on error resume next
obj.Execute sql,recaffected
if err<>0 then
  Response.Write("No Update permision")
else
  Response.Write("<h3>" & recaffected & " record deleted</h3>")
end if
obj.Close
%>