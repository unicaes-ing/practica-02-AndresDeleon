using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Practica2_5

    {
        static void Main(string[] args)
        {
            string tel;
            double dif;
            decimal valor, precio;
            Console.Write("Número de teléfono: ");
            tel = Console.ReadLine();
            Console.Write("Hora de inicio de la llamada: ");
            TimeSpan hI = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Hora de finalización de la llamada: ");
            TimeSpan hF = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Valor de por minuto: ");
            valor = Convert.ToDecimal(Console.ReadLine());
            dif = hF.TotalMinutes - hI.TotalMinutes;
            precio = Convert.ToDecimal(dif) * valor;
            Console.WriteLine("Minutos trascurridos de la llamada: " + dif);
            Console.WriteLine("Monto a cobrar: " + precio.ToString("C2"));
            Console.ReadKey();
        }
    }
}
