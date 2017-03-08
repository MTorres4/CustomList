using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    public class ClockRadio
    {
        public bool isOn;
        public int volumeMax;
        public string currentStation;
       // public string frequency;
        public DateTime time = DateTime.Now;
        public string alarmTime;
       // public string FM;
       // public string AM;
        public ClockRadio(bool isOn, int volumeMax)
        {
            this.isOn = isOn;
            this.volumeMax = volumeMax;
            currentStation = "106.1";
            DateTime time = DateTime.Now;
        }
        public void On()
        {
            isOn = true;
        }
        public int TurnDown()
        {
            return volumeMax -= 5;
        }
        public int TurnUp()
        {
            return volumeMax += 5;
        }
       // public string stationFrequency(double currentStation)
        //{
          //  if (currentStation <= 999)
            //{
              //  return FM;
            //} else
            //{
              //  return AM;
            //}
        //}
        public string changeStation()
        {
            Console.WriteLine($"Enter the station you would like to change to \n example: 102.1");
            string currentStation = Console.ReadLine();
            return currentStation;
        }
        public string convertTime(DateTime DateTime)
        {
            string time = DateTime.Now.ToString();
            return time;
        }
        public void displayCurrentTime(DateTime time)
        {
            Console.WriteLine(time);
            Console.ReadLine();
        }
        public void displayCurrentStation(string currentStation)
        {
            Console.WriteLine($"You are currently jamming out to {currentStation}");
        }
        public string setAlarmTime()
        {
            Console.WriteLine($"Enter your time for an alarm. \n Example: 12:30");
            string alarmTime = Console.ReadLine();
            return alarmTime;
        }
        public void alarmSetFor(string alarmTime)
        {
            Console.WriteLine($"Your alarm is set for {alarmTime}");
            Console.ReadLine();
        }
        public void MainMenu()
        {
            Console.Write($"What would you like to do:"
            + "\n type 'current time', 'current station', 'change station', 'volume up', 'volume down', 'set alarm', or 'change alarm'.");
            string radio = Console.ReadLine();

            switch (radio)
            {
                case "current time":
                    displayCurrentTime(time);
                    MainMenu();
                    break;
                case "current station":
                    displayCurrentStation(currentStation);
                    MainMenu();
                    break;
                case "change station":
                    changeStation();
                    MainMenu();
                    break;
                case "volume up":
                    TurnUp();
                    break;
                case "volume down":
                    TurnDown();
                    break;
                case "set alarm":
                    setAlarmTime();
                    alarmSetFor(alarmTime);
                    MainMenu();
                    break;
                case "change alarm":
                    alarmSetFor(alarmTime);
                    setAlarmTime();
                    alarmSetFor(alarmTime);
                    MainMenu();
                    break;
                default:
                    Console.Write($"Please type one of the valid options");
                    Console.ReadLine();
                    MainMenu();
                    break;
            }
        }
    }
}
