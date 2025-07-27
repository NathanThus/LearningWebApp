#include <Arduino.h>
#include <Wire.h>
#include "AHT20.h"
#include <WiFi.h>
#include <HTTPClient.h>

#define DELAY_RECONNECTION_MILLISECONDS 100
#define RECONNECTION_ATTEMPTS 5

char SSID[] = "WiFi";
char password[] = "PassWord";
String dbAddress = "http://localhost:3000/weather";

AHT20 aht20;
float humidity, temperature;
HTTPClient httpClient;

void setup()
{
  aht20.begin();
  WiFi.begin(SSID,password);

  while(WiFi.isConnected() == false)
  {
    delay(DELAY_RECONNECTION_MILLISECONDS);
    WiFi.begin();
  }


}

void loop()
{
  if(!GetSensorData()) return;
  httpClient.begin(dbAddress);

  httpClient.addHeader("Content-Type", "application/json");
  int temp = (int) temperature;
  int humi = (int) humidity;
  String payload = "{\"temperature\": \"" + temp;
  payload += ", \"humidity\": \""+ humi;
  payload += "\"}";

  httpClient.POST(payload);

  httpClient.end();
}

/// @brief Grabs the sensor data and allocates it to @b humidity and @b temperature.
/// @return Returns true if data was succesfully collected. 
bool GetSensorData()
{
  return aht20.getSensor(&humidity,&temperature) == 0;
}
