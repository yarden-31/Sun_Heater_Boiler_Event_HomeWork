using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class WaterHeater
    {
        double currentTemperature;

        public static DateTime startTime;

        WaterHeater(double targetTemp)
        {
            double currentTemperature = targetTemp;
        }

        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        public event EventHandler<double> TargetReached;

        public static void StartBoiling()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            DateTime currentTime = DateTime.Now;
            // prepare to boil water
            startTime = DateTime.Now;
            Console.WriteLine($"Start preparing the water at {startTime.ToString()}");
            WaterHeater waterHeater = new WaterHeater(100);
            for (double temp = 0; temp <= 100; temp += 5)
            {
                Thread.Sleep(500);
                TemperatureChangedEventArgs args = new TemperatureChangedEventArgs
                {
                    CurrentTemperature = temp,
                    CurrentTimeWhenTakingTemperature1 = DateTime.Now
                };
                waterHeater.TemperatureChanged?.Invoke(waterHeater, args);
                if (temp >= 100)
                {
                    waterHeater.TargetReached?.Invoke(waterHeater, temp);
                }
            }
        }
    }
}