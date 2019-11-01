using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datetimeconsolapp
{
    class Program
    {
        static void Main(string[] args)
        {

            //var dateToday = new DateTime(1997,10,28);
            //Console.WriteLine(dateToday);
            //var dayOfTheWeek = dateToday.DayOfWeek;
            //Console.WriteLine(dayOfTheWeek);

            //küsi kasutaja käest sünnikuupäeva-programm ütleb mis nädalapäeval ta sündinud on
            string userInput;
            Console.WriteLine("Hello! Enter your birth date(yyyy/mm/dd): ");
            userInput = Console.ReadLine();

            string[] userData = userInput.Split('/');
            int year = int.Parse(userData[0]);
            int month = int.Parse(userData[1]);
            int day = int.Parse(userData[2]);

            var userBirthDay = new DateTime(year, month, day);
            var birthdayOfTheWeek = userBirthDay.DayOfWeek;
            Console.WriteLine($"You were born on {birthdayOfTheWeek}");

            Console.ReadLine();
        }
        
    }
}
