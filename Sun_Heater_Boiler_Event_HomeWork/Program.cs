namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterHeater waterHeater = new WaterHeater();
            DisplayUnits displayUnits = new DisplayUnits();

            waterHeater.OnTemperatureChange += displayUnits.DisplayTemperature;
            waterHeater.StartBoiler(45);
            House h = new House();
            AlarmSystem alarmSystem = new AlarmSystem();
            waterHeater.TragetReached += alarmSystem.DisplayAlert;
            h.OnDoorOpened += alarmSystem.DisplayAlert;
            h.OpenDoor();
        }
    }
}
