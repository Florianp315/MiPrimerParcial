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
            double totalcomisiones = 0;
            double mayorcomision =0;

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
            double comision = venta1 * 0.1;
            totalcomisiones += comision;
            mayorcomision = comision;

            comision = venta2 * 0.1;
            totalcomisiones += comision;
            if (comision > mayorcomision)
            {
                mayorcomision = comision;
            }

            comision = venta3 * 0.1;
            totalcomisiones += comision;
            if (comision > mayorcomision)
            {
                mayorcomision = comision;
            }


            //Calculando total del mes 
            double totalmes = sueldobase + totalcomisiones;

            //Verificar si se alcanza el objetivo del mes
            double objetivo = 1000000;
            bool alcanzoobjetivo = venta1 + venta2 + venta3 >= objetivo;
            double bonificacion = alcanzoobjetivo ? 100000 : 0;

            //Mostrar Resultado en pantalla

            Console.WriteLine("Dinero por comisiones: " + totalcomisiones);
            Console.WriteLine("Total Dinero recibido en el mes: " + (totalmes + bonificacion));
            Console.WriteLine("La venta que genero la mayor comision fue de: " + mayorcomision);
            Console.WriteLine("Promedio de comisiones por venta: " + (totalcomisiones / 3));

            if (alcanzoobjetivo)
            {
                Console.WriteLine("Ganaste la bonificacion por un valor de: " + bonificacion);
            }
            else
            {
                Console.WriteLine("No ganaste la bonificacion, trabaja duro para adquirir la bonificacion el proximo mes");
            }

        }
    }
}
