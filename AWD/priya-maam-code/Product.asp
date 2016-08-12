<html>
Selected Item 
<%
a=Request.Querystring("list1")
b=Request.Querystring("txtprice")
c=Request.Querystring("txtqty")
Response.write(a&"<br>")
Response.write("Amount: "&(b*c))


%>
<a href="Product1.asp?a=Thanks">Go to original page</a>
</html>