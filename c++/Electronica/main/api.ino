AsyncWebServer server(80);
#include "devices.h"
// extern Device devices[];
extern int deviceCount;

String devicesJSON(){

  String json="[";

  for(int i=0;i<deviceCount;i++){

    if(i>0) json+=",";

    json+="{";
    json+="\"mac\":\""+devices[i].mac+"\",";
    json+="\"rssi\":"+String(devices[i].rssi);
    json+="}";
  }

  json+="]";
  return json;
}

void initAPI(){

  server.on("/api/devices",HTTP_GET,
  [](AsyncWebServerRequest *req){
      req->send(200,"application/json",devicesJSON());
  });

  server.on("/",HTTP_GET,
  [](AsyncWebServerRequest *req){

    req->send(200,"text/html",dashboardHTML());
  });

  server.begin();
}