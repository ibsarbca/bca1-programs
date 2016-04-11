<html>
<head></head>
<body>
<%
dim u,p,c
c = 0
dim arr(4,4)
u=Request.Querystring("txtuname")
p=Request.Querystring("txtpass")
arr(0,0)="admin111"
arr(0,1)="admin123"
arr(1,0)="admin245"
arr(1,1)="admin1234"
arr(2,0)="admin24"
arr(2,1)="admin1236"
arr(3,0)="admin343"
arr(3,1)="admin124653"
arr(4,0)="admin23"
arr(4,1)="admin15423"


For i=0 to 4

if arr(i,0)=u and arr(i,1)=p then
Response.write("Success")
c=0
exit for
else
c=1
end if



Next

if c=1 then
Response.write("Invalid Uname/Pwd")
end if


%>
</body>
</html>