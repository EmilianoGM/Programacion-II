using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            System.Console.Title = "Ejercicio Nro 01";
            Int32 numeros;
            Int32 maximo = 0;
            Int32 minimo = 0;
            Int32 suma = 0;
            Single promedio;
            Console.WriteLine("Introduzca 5 numeros");
            for(Int32 i = 0; i < 5; i++)
            {
                numeros = Int32.Parse(Console.ReadLine());
                suma += numeros;
                if (i == 0)
                {
                    maximo = numeros;
                    minimo = numeros;
                } else
                {
                    if(maximo < numeros)
                    {
                        maximo = numeros;
                    } else if(minimo > numeros)
                    {
                        minimo = numeros;
                    }
                }
            }
            promedio = (float)(suma / 5.0);
            Console.WriteLine("Maximo = {0} - Minimo = {1} - Promedio = {2}", maximo, minimo, promedio);
            Console.ReadKey();
        }
    }
}
