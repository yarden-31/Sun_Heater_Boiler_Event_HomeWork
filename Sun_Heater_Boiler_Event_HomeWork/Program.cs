using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*
            WaterHeater waterHeater = new WaterHeater();
            DisplayUnits displayUnits = new DisplayUnits();

            waterHeater.OnTemperatureChange += displayUnits.DisplayTemperature;
            waterHeater.StartBoilerAsync(3);
            Console.WriteLine();
            House h = new House();
            AlarmSystem alarmSystem = new AlarmSystem();
            waterHeater.TragetReached += alarmSystem.DisplayAlert;
            h.OnDoorOpened += alarmSystem.DisplayAlert;
            h.OpenDoor();*/

            //-------------------------------------------------------

            List<WaterHeater> heaters = new List<WaterHeater>();
            WaterHeater heater1 = new WaterHeater() { Location = "Living Room" };
            heaters.Add(heater1);
            WaterHeater heater2 = new WaterHeater() { Location = "Bedroom" };
            heaters.Add(heater2);
            WaterHeater heater3 = new WaterHeater() { Location = "Bathroom" };
            heaters.Add(heater3);

            DisplayUnits displayUnits = new DisplayUnits();
            AlarmSystem alarmSystem = new AlarmSystem();
            Random rnd = new Random();
            foreach (var heater in heaters)
            {
                heater.OnTemperatureChange += displayUnits.DisplayTemperature;
                heater.TragetReached += alarmSystem.DisplayAlert;
                double targetTemp = rnd.Next(5, 10);
                _ = heater.StartBoilerAsync(targetTemp);
            }
            var oneFinished =Task.WhenAny(heaters.Select(h => h.StartBoilerAsync(rnd.Next(5, 10))));
            await oneFinished;
            var allFinished = Task.WhenAll(heaters.Select(h => h.CalculateHeatingCostAsync()));
            await allFinished;
            int totalCost = 0;
            foreach (var cost in allFinished.Result)
            {
                totalCost += (int)cost;
            }
            Console.WriteLine($"\nTotal Heating Cost for all Water Heaters: {totalCost} $");
        }
    }
}
