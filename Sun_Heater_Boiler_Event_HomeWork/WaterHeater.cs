using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class WaterHeater
    {
        private double currentTemperature;

        public String Location { get; set; }

        public event EventHandler<TemperatureEventArgs> OnTemperatureChange;

        public event EventHandler TragetReached;

        public string TemperatureInFahrenheit
        {
            get
            {
                double fahrenheit = (currentTemperature * 9 / 5) + 32;
                return $"{fahrenheit} °F";
            }
        }

        //-----------------------------------------------------------

        public async Task StartBoilerAsync(double targetTemperature)
        {
            while (currentTemperature < targetTemperature)
            {
                Thread.Sleep(1500); // 1500 = 1.5 seconds
                currentTemperature = currentTemperature + 0.5;
                OnTemperatureChange?.Invoke(this, new TemperatureEventArgs(currentTemperature));
            }

            if (TragetReached != null)
            {
                TragetReached(this, new EventArgs());
            }
        }

        //-----------------------------------------------------------

        public async Task<double> CalculateHeatingCostAsync()
        {
            int currentTemp = (int)currentTemperature;
            Task.Delay(3000).Wait(); // waits for 3 seconds
            Random rnd = new Random();
            int randomNum = rnd.Next(2, 21);
            double total = randomNum * currentTemp + (randomNum * currentTemp * 0.18);
            return total;
        }
    }
}
