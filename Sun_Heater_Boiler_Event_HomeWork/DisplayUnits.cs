using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class DisplayUnits
    {
        public void DisplayTemperature(object sender, TemperatureEventArgs Event)
        {
            Console.Write($"\rCurrent Temperature: {Event.currentTemperature}°C at {Event.eventTime}       ");
            Console.WriteLine($"The Location of the Water Heater is: {(sender as WaterHeater)?.Location}");

        }
    }
}
