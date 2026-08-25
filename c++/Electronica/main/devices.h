#ifndef DEVICES_H
#define DEVICES_H

#include <Arduino.h>

struct Device {
  String mac;
  int rssi;
  unsigned long lastSeen;
};

#define MAX_DEVICES 50

extern Device devices[MAX_DEVICES];
extern int deviceCount;

void registerDevice(String mac,int rssi);

#endif