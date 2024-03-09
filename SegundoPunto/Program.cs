using System;

namespace SegundoPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable
            int velocidadtren1 = 80;
            int velocidadtren2 = 100;
            int horasalidatren1 = 10;
            int horasalidatren2 = 11;

            //Calculo del tiempo transcurrido entre la salida del primer y segundo tren
            double tiempotranscurrido = horasalidatren2 - horasalidatren1;

            //Calculo de la distancia recorrida por el primer tren durante este tiempo en KM
            double distanciarecorridatren1 = velocidadtren1 * velocidadtren2;

            // Cálculo del tiempo necesario para que el segundo tren alcance al primero
            double tiempoalcanzar = distanciarecorridatren1 / (velocidadtren2 - velocidadtren1);

            // Cálculo de la hora a la que el segundo tren alcanza al primero
            double horaalcanzar = horasalidatren2 + tiempoalcanzar;

            //Mostrar resultado en pantalla
            Console.WriteLine("El segundo tren alcanzará al primer tren a las {0:0.00} horas.", horaalcanzar);


        }
    }
}
