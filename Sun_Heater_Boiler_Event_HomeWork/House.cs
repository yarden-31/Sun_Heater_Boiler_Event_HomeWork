using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class House
    {
        bool isDoorLocked = false;

        public event EventHandler OnDoorOpened;

        //-----------------------------------------------------------

        public void OpenDoor()
        {
            if(!isDoorLocked)
            {
                Console.WriteLine("The door is now open.");
                OnDoorOpened?.Invoke(this, new EventArgs());
            }
            else
            {
                Console.WriteLine("The door is locked. Cannot open.");
            }
        }

        //-----------------------------------------------------------


    }
}
