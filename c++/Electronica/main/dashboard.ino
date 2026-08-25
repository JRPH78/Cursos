String dashboardHTML(){

return R"rawliteral(

<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width">
<style>
body{background:#0f172a;color:#fff;font-family:monospace}
.card{background:#111;padding:10px;margin:8px;border-radius:8px}
</style>
</head>

<body>

<h2>🐬 FLIPPER WIFI OS</h2>

<div id="devices"></div>

<script>

function load(){

fetch('/api/devices')
.then(r=>r.json())
.then(data=>{

let html="";

data.forEach(d=>{
html+=`<div class="card">
📡 ${d.mac} | ${d.rssi} dBm
</div>`;
});

document.getElementById("devices").innerHTML=html;
});
}

setInterval(load,2000);
load();

</script>

</body>
</html>

)rawliteral";
}