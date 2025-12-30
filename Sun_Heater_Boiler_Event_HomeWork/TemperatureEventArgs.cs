using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class TemperatureEventArgs : EventArgs
    {
        public double currentTemperature { get; }

        public DateTime eventTime{ get; }

        //-----------------------------------------------------------

        public TemperatureEventArgs(double currentTemperature)
        {
            this.currentTemperature = currentTemperature;
            this.eventTime = DateTime.Now;
        }

        //-----------------------------------------------------------
    }
}
