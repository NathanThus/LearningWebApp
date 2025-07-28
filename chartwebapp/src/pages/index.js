import Head from "next/head";
import { Geist, Geist_Mono } from "next/font/google";
import styles from "@/styles/Home.module.css";
import 'chart.js/auto';
import { Chart } from 'react-chartjs-2';
import { useState, useEffect } from 'react';


const geistSans = Geist({
  variable: "--font-geist-sans",
  subsets: ["latin"],
});

const geistMono = Geist_Mono({
  variable: "--font-geist-mono",
  subsets: ["latin"],
});

export default function Home() {
  const [temperature, setTemperature] = useState([]);
  const [humidity, setHumidity] = useState([]);
  const [timestamps, setTimestamps] = useState(['01', '02', '03', '04', '05', '06', '07']);

  useEffect(() => {
    GrabWeatherData();
  }, []);

  function GrabWeatherData() {
    fetch('http://localhost:3000/weather')
      .then(response => {
        if (response.ok) {
          return response.json();
        } else {
          throw new Error('API request failed');
        }
      })
      .then(parsedData => {
        setTemperature(parsedData.map(data => data.temperature));
        setHumidity(parsedData.map(data => data.humidity));
        setTimestamps(parsedData.map(entry => String(new Date(entry.timestamp).getHours())));
      })
      .catch(error => {
        console.error(error);
      });
  }

  const chartData = {
    labels: timestamps,
    datasets: [
      {
        label: 'Temperature',
        data: temperature,
        fill: false,
        borderColor: 'rgba(255, 0, 64, 1)',
        tension: 0.1,
      },
      {
        label: 'Humidity',
        data: humidity,
        fill: false,
        borderColor: 'rgba(0, 174, 255, 1)',
        tension: 0.1,
      },
    ],
  };

  return (
    <>
      <Head>
        <title>ChartWebApp</title>
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <div
        className={`${styles.page} ${geistSans.variable} ${geistMono.variable}`}
      >
        <main className={styles.main}>
          LocalWeather
          <div className={styles.chartContainer}>
            <Chart type='line' data={chartData}/>
          </div>
        </main>
        <footer className={styles.footer}>
        </footer>
      </div>
    </>
  );
}


