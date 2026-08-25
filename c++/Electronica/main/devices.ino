#include "devices.h"

Device devices[MAX_DEVICES];
int deviceCount = 0;

void registerDevice(String mac,int rssi){

  for(int i=0;i<deviceCount;i++){
    if(devices[i].mac == mac){
      devices[i].rssi = rssi;
      devices[i].lastSeen = millis();
      return;
    }
  }

  if(deviceCount < MAX_DEVICES){
    devices[deviceCount++] = {mac,rssi,millis()};
  }
}