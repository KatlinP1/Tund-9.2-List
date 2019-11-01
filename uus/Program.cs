using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uus
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDate = DateTime.Now;
            var dateObjects = new DateTime(2019, 11, 1);
            Console.WriteLine(currentDate);

            var currentDayOfTheWeek = currentDate.DayOfWeek;
            Console.WriteLine(currentDayOfTheWeek);

            var ticks = dateObjects.Ticks;
            Console.WriteLine($"Ticks {ticks}");

            Console.WriteLine($"Print current date: {currentDate}");
            Console.WriteLine($"Print long date string: {currentDate.ToLongDateString()}");
            Console.WriteLine($"Print short date string: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Print long time string: {currentDate.ToLongTimeString()}");
            Console.WriteLine($"Print short time string: {currentDate.ToShortTimeString()}");
            Console.WriteLine($"Print date format: {currentDate.ToString("dd-MM-yyyy HH:mm")}");

            //kodutöö-arvutada kui vana sa oled sekundites 


            Console.ReadLine();





        }
    }
}
