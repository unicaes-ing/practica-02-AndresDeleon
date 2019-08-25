using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Practica2_4
    {
          static void Main(string[] args)
        {
            float alquiler;
            double precio;
            string fec1, fec2;          
            DateTime fechaI, fechaF;
            Console.WriteLine("Fecha de inicio del alquiler");
            fec1 = Console.ReadLine();
            Console.WriteLine("Fecha de devolucion del alquiler");
            fec2 = Console.ReadLine();
            fechaI = Convert.ToDateTime(fec1);
            fechaF = Convert.ToDateTime(fec2);
            Console.WriteLine("Valor de alquiler por dia");
            alquiler = float.Parse(Console.ReadLine());
            TimeSpan dias = fechaF - fechaI;
            precio = alquiler * dias.Days;
            Console.WriteLine("Días de alquiler: " + dias.Days);
            Console.WriteLine("Precio a pagar: " + precio.ToString("C2"));
            Console.ReadKey();
            //Console.WriteLine("Fecha de devolucion del alquiler");
            //fechaD = Console.ReadLine(); 
            //string.Format("{0:00-00-0000}", fechaI)
        }
    }
}
