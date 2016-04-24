<html>
<body>
<%
a=Request.Cookies("fname")
b=Request.Cookies("favcolor")
Response.redirect("chk.asp?n="& a & "&c=" & b)
%>
<form action=fc.asp>
  color:<br>
  <input type="text" name="favcolor"><br>
  Name:<br>
  <input type="text" name="fname"><br><br>
  <input type="submit" value="Submit">
</form>
</body>
</html>