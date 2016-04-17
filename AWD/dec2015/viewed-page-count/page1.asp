<html>
<head>
<meta charset="utf-8">
</head>
<body>
<%
If Session("page_count") = "" then
	Session("page_count") = 0
else
	Session("page_count") = Session("page_count") + 1
end if

%>
<a href="home.asp">Home Page </a><br>

<a href="page1.asp">Page 1 </a> <br>

<a href="page2.asp">Page 2 </a><br>

This is Page 1

Current Page Count: <%=Session("page_count")%>
</body>
</html>

