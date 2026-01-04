using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class AlarmSystem
    {
        public void DisplayAlert(object sender, EventArgs Event)
        {
            if (sender is WaterHeater heater)
            {
                Console.WriteLine("Target Temperature Reached! Alarm Activated!");
                Console.WriteLine($"Current Tempertature in Fahrenheit: {heater.TemperatureInFahrenheit}");
                Console.WriteLine($"The Location of the Water Heater is: {heater.Location}");
            }

            if (sender is House h)
            {

            }

        }
    }
}
