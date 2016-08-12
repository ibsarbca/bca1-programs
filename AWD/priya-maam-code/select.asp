<html>
<%
n=Request.Querystring("txtnum")
select case n
case 1:
Response.write("mon")
case 2:
Response.write("tue")
case else
Response.write("Invalid")
end select
%>
</html>