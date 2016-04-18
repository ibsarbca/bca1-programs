<html>
<head>
<meta charset="utf-8">
</head>
<body>

<form action="running-clock.asp" method="post">
	<input type="text" id="clock">
	<input type="button" onclick="start()" value="START">
	<input type="button" onclick="stop_timer()" value="STOP">
</form>

<script>
var interval = 0;
function start() {
	interval = window.setInterval(function(){tick()}, 1000);
}
function tick() {
	document.getElementById("clock").value = new Date().toLocaleTimeString();
}
function stop_timer() {
	clearInterval(interval);
}
</script>

</body>
</html>
