<html>
<body>
	<form method="get" action="checkbox.asp">
		<input type="checkbox" name="chat" value="panipuri">Panipuri<br />
		<input type="checkbox" name="chat" value="shevpuri">shevpuri<br />
		<input type="checkbox" name="chat" value="bhelpuri">bhelpuri<br />
		<input type="submit"><br>
		<input type="reset"><br>
		<textarea><%response.write(request.queryString("chat"))%></textarea>
	</form>
</body>
</html>
