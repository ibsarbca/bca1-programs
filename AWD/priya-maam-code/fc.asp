<html> 
<head> 
<title>
displaying details
</title> 
</head> 
<body> 
You have typed the Name <%=Request.Querystring("fname")%>
 and fav. color
<%=Request.Querystring("favcolor")%> 
<%	
Response.Cookies("fname")=Request.Querystring("fname")
Response.Cookies("favcolor")=Request.Querystring("favcolor")
%>
</body> </html>