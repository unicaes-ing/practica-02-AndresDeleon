using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Practica2_1
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Escriba un nombre");
            nombre = Console.ReadLine();
            nombre = nombre.Replace("a", "#");
            nombre = nombre.Replace("e", "%");
            nombre = nombre.Replace("i", "$");
            nombre = nombre.Replace("o", "?");
            nombre = nombre.Replace("u", "*");
            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
