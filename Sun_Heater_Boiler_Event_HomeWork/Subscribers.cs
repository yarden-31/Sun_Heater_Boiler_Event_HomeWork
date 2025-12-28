using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class Subscribers
    {
        public void onTemperatureChanged(object sender, TemperatureChangedEventArgs Event)
        {
            Console.WriteLine($"Current Temperature: {Event.CurrentTemperature}°C at {Event.CurrentTimeWhenTakingTemperature1}");
        }

        public void onTargetReached(object sender, double currentTemp)
        {
            TimeSpan timeTaken = DateTime.Now - WaterHeater.startTime;
            Console.WriteLine($"Target temperature of {currentTemp}°C reached in {timeTaken.TotalSeconds} seconds.");
        }
    }
}
