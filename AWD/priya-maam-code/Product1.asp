<html>
<form action="Product.asp">
Select Product<select name="list1">
<option>Hi</option>
<option>Hello</option>
<option>Helloooooo</option>
</select><br>
Enter Price:<input type=text name=txtprice><br>
Enter qty:<input type=text name=txtqty><br>
<br>
<input type=submit>
</form>
<%=Request.Querystring("a")%>
</html>