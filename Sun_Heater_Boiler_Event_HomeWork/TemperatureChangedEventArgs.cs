using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class TemperatureChangedEventArgs : EventArgs
    {
        double currentTemperature;

        DateTime CurrentTimeWhenTakingTemperature;

        //-----------------------------------------------------------

        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        //-----------------------------------------------------------

        public DateTime CurrentTimeWhenTakingTemperature1
        {
            get { return CurrentTimeWhenTakingTemperature; }
            set { CurrentTimeWhenTakingTemperature = value; }
        }
    }
}
