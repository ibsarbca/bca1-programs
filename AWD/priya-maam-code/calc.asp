<html>
<%
n1=CInt(Request.Querystring("txtnum1"))
n2=CInt(Request.Querystring("txtnum2"))
c=Request.Querystring("txtchoice")
select case c
case 1:
Response.write((n1+n2))
case 2:
Response.write(n1-n2)
case 3:
Response.write(n1*n2)
case 4:
Response.write(n1/n2)
case else
Response.write("Invalid")
end select
%>
</html>