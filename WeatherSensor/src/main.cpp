#include <Arduino.h>
#include <Adafruit_AHTX0.h>
#include <WiFi.h>
#include <HTTPClient.h>

#define DELAY_RECONNECTION_MILLISECONDS 100
#define RECONNECTION_ATTEMPTS 5
#define CONVERT_HOURS_TO_MILLISECONDS * 3600000
#define DELAY_WEATHER_PULSE_MILLISECONDS 1 CONVERT_HOURS_TO_MILLISECONDS

char SSID[] = "WiFi";
char password[] = "PassWord";
String dbAddress = "http://localhost:3000/weather";

Adafruit_AHTX0 aht20;
sensors_event_t humidity, temperature;
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

/// @brief Grabs the sensor data and allocates it to @b humidity and @b temperature.
/// @return Returns true if data was succesfully collected. 
bool GetSensorData()
{
  return aht20.getEvent(&humidity,&temperature);
}

void loop()
{
  if(!GetSensorData()) return;
  httpClient.begin(dbAddress);

  httpClient.addHeader("Content-Type", "application/json");

  // The adafruit library does have some wierd practices, but it is what it is.
  int temp = (int) temperature.temperature;
  int humi = (int) humidity.relative_humidity;

  // Apparently string REALLY doesn't like value injection, hence the multiline approach.
  String payload = "{\"temperature\": \"" + temp;
  payload += ", \"humidity\": \""+ humi;
  payload += "\"}";

  httpClient.POST(payload);

  httpClient.end();
  delay(DELAY_WEATHER_PULSE_MILLISECONDS);
}
