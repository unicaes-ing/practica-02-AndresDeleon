using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Practica2_6
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            DateTime hora = DateTime.Now;
            Console.WriteLine("Today is {0} {1} of the month {2} of {3} and it is {4}", hoy.DayOfWeek, hoy.Day, hoy.Month, hoy.Year, hora.ToString("hh:mm"));
            Console.ReadKey();
        }
    }
}
