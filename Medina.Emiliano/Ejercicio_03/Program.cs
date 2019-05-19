using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string usuario;
            int flag;
            Console.WriteLine("Ingrese el numero:");
            usuario = Console.ReadLine();
            numero = Int32.Parse(usuario);
            Console.WriteLine("Numeros primos:");
            for(int i = numero; i > 0; i--)
            {
                flag = 0;
                for (int j = i - 1; j > 1; j--)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
