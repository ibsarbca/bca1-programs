<%
set obj = CreateObject("ADODB.Connection")
obj.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\mydb1.mdb"
sql="update emp set sal=5000 where emp_no=6"
on error resume next
obj.Execute sql,recaffected
if err<>0 then
  Response.Write("No Update permision")
else
  Response.Write("<h3>" & recaffected & " record updated</h3>")
end if
obj.Close
%>