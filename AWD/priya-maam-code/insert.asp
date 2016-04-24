<%
set obj = CreateObject("ADODB.Connection")
obj.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\mydb1.mdb"
a="hhh"
b="b"
sql="insert into emp values(8,'"& a &"','"& b &"',4000)"
on error resume next
obj.Execute sql,recaffected
if err<>0 then
  Response.Write("No Update permision")
else
  Response.Write("<h3>" & recaffected & " record added</h3>")
end if
obj.Close
%>