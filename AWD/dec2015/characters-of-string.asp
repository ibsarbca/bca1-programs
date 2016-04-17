<html>
<head>
<meta charset="utf-8" />
<title></title>
<body>
<form action="characters-of-string.asp" method="get">
Enter String: <input type="text" name="user_string"> <br />
<input type="submit" value="Submit">
</form>

<%

if request.ServerVariables("REQUEST_METHOD") = "GET" then
	dim str
	str = request.QueryString("user_string")
	response.write(left(str, 1) & " " & right(str, 1))
end if

%>
</body>
</html>