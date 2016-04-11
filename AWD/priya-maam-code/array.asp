<html>
<head></head>
<body>
<%
Response.write("hi"&"<br>")
dim arr(5)
arr(0)="Mouse"
arr(1)="Kb"
arr(2)="Printer"
arr(3)="Printer"
arr(4)="Printer"
for i=0 to 4
Response.write(arr(i)&"<br>")
Next
%>
</body>
</html>