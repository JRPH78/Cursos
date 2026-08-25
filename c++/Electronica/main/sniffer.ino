extern "C" {
#include "user_interface.h"
}
#include "devices.h"

// #include "devices.ino"

void sniffer(uint8_t *buf, uint16_t len) {

  if(len < 28) return;

  uint8_t *mac = buf + 10;

  char macStr[18];
  sprintf(macStr,"%02X:%02X:%02X:%02X:%02X:%02X",
  mac[0],mac[1],mac[2],mac[3],mac[4],mac[5]);

  int rssi = ((int8_t*)buf)[0];

  registerDevice(String(macStr),rssi);
}

void initSniffer(){

  wifi_promiscuous_enable(0);
  wifi_set_promiscuous_rx_cb(sniffer);
  wifi_promiscuous_enable(1);

  Serial.println("Sniffer activo");
}