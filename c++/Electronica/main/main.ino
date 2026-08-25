#include <ESP8266WiFi.h>
#include <ESPAsyncTCP.h>
#include <ESPAsyncWebServer.h>

extern void initWiFi();
extern void initAPI();
extern void initSniffer();

void setup() {
  Serial.begin(115200);

  initWiFi();
  initSniffer();
  initAPI();

  Serial.println("FLIPPER WIFI OS READY");
}

void loop() {}