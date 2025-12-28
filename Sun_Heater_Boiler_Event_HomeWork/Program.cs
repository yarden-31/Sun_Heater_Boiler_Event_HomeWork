namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscribers subscribers = new Subscribers();
            WaterHeater waterHeater = new WaterHeater();
            waterHeater.TemperatureChanged += subscribers.onTemperatureChanged;
            waterHeater.TargetReached += subscribers.onTargetReached;
            Console.WriteLine("Starting the water heater...");
            WaterHeater.startTime = DateTime.Now;
            waterHeater.StartBoiler(20);
            Console.WriteLine("Water heater process completed.");
        }
    }
}
