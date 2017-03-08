using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    public class Alarm
    {
        public string DateTime;
        public string currentAlarm;
        public Alarm()
        {

        }
        public void setAlarmTime()
        {
            Console.WriteLine("Enter your time for an alarm. \n Example: 12:30");
            Console.ReadLine();
        }
        public void alarmSetFor()
        {
            Console.WriteLine("Your alarm is set for {setAlarmTime}");
            Console.ReadLine();
        }
       // public string AMorPM()
        //{
          //  Console.WriteLine("Enter 'AM' or 'PM' for your alarm to go off.");
            //string morningAfternoon = Console.ReadLine();
            //return morningAfternoon;
        //}
        //public void alarmSet(double setAlarmTime, string AMorPM)
        //{
          //  Console.WriteLine($"Your alarm is set for {setAlarmTime} {AMorPM}");
        //}
        //public void ExecuteSettingAlarm()
        //{
          //  Double time = setAlarmTime();
            //string MorningorAfternoon = AMorPM();
            //alarmSet(time, MorningorAfternoon);
        //}
        //public string alarmAlert(string DateTime, alarmSet)
        //{
          //  if (DateTime == alarmSet)
            //{
              //  return Console.WriteLine($"Alarm!");
            //}
        //}
    }
}
