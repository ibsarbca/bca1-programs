<p>&nbsp;
<a href="view.asp">Show all records</a>
<a href="add.asp">Add a record</a>
<a href="logout.asp">Logout</a>
<br />
<!-- This simply gets which user is logged in from the Session variable -->
Logged in user: &nbsp; <%Response.Write(Session("user"))%>
<p>&nbsp;

