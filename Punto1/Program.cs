﻿using System;
using System.Security.Cryptography;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX.Además, recibe una comisión del 10 % sobre el valor total de cada venta querealiza.El vendedor desea saber

            //Declaracion de Variables
            double sueldobase = 800000;
            double venta1, venta2, venta3;
            double totalcomisiones;
            double mayorcomision;

            //Entrada de datos
            Console.Write("Ingresa el valor de la primera venta del mes:");
            venta1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Ingresa el valor de la segunda venta del mes:");
            venta2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Ingresa el valor de la tercera venta del mes:");
            venta3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            //Calculo de comisiones y total de ventas
            for (int i = 0; i < venta1; i++);
            for (int i = 0; i < venta2; i++);
            for (int i = 0; i < venta3; i++);
            {
                double comision = venta1 * 0.1;
                double comision = venta2 * 0.1;
                double comision = venta3 * 0.1;
                totalcomisiones += comision;
                if (comision > mayorcomision);
                {
                    mayorcomision = comision;
                }
            }







        }
    }
}
