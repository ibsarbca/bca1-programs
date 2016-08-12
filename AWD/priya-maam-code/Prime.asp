<html>
<%
dim n,i,cnt
n=450

For i=250 to n
	cnt=0
	For j=1 to i
		if i mod j=0 then
		cnt=cnt+1
	end if
	Next
	if cnt=2 then
		Response.write(i&",")
	end if
Next
%>
</html>
