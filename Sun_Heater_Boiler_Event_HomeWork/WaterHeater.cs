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

        public virtual void StartBoiler(double targetTemp)
        {
            double goalTemperature = targetTemp;
            while (currentTemperature < goalTemperature)
            {
                currentTemperature = currentTemperature + 2;
                TemperatureChangedEventArgs args = new TemperatureChangedEventArgs();
                Thread.Sleep(500);
            }
            if (currentTemperature >= goalTemperature)
            {
                TargetReached?.Invoke(this, currentTemperature);
            }
        }
    }
}