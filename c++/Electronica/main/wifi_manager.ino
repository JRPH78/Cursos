#include <DNSServer.h>

DNSServer dnsServer;

void initWiFi() {

  WiFi.mode(WIFI_AP_STA);
  WiFi.softAP("WIFI","12345678");

  IPAddress ip = WiFi.softAPIP();

  dnsServer.start(53, "*", ip);

  Serial.print("AP IP: ");
  Serial.println(ip);
}