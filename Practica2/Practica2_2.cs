using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Practica2_2
    {
          static void Main(string[] args)
        {
            string producto;
            uint cant;
            double iva, total, subtotal;
            float precio;
            Console.WriteLine("Ingrese el nombre del producto");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de producto");
            cant = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            precio = float.Parse(Console.ReadLine());
            subtotal = precio * cant;
            iva = subtotal * 0.13;
            total = subtotal - iva;
            Console.WriteLine("Subtotal: " + subtotal.ToString("c2"));
            Console.WriteLine("IVA: " + iva.ToString("c2"));
            Console.WriteLine("Total a pagar: " + total.ToString("c2"));
            Console.ReadKey();
        }
    }
}
