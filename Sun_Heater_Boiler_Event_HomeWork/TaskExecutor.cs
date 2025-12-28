using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_Heater_Boiler_Event_HomeWork
{
    internal class TaskExecutor
    {
        // תכונות
        private int timeInMiliSec;
        
        //-----------------------------------------------------------

        public event EventHandler<int> OnProgress;

        //-----------------------------------------------------------

        //בנאי
        public TaskExecutor(string name, int ms)
        {
            this.timeInMiliSec = ms;
        }

        //-----------------------------------------------------------

        //מחקה זמן ביצוע פעולה
        public void Start()
        {
            for (int i = 1; i <= 10; i++)
            {

                Thread.Sleep(500);
                if (OnProgress != null)
                {
                    OnProgress(this, i = i + 2);
                }
            }
        }

        class WaterHeater : TaskExecutor
        {
            public WaterHeater(string name) : base(name, 7000)
            {

            }
        }
    }
}