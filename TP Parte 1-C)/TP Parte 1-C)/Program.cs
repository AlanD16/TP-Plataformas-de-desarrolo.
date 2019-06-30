using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_1_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar número: ");
            int num = int.Parse(Console.ReadLine());

            int acumulador = 0;

            for (int i = 0; i < num; i++)
            {
                acumulador = acumulador + i;
            }
            Console.WriteLine("La suma de los números enteros hasta el " + num + " es " + acumulador);
            Console.ReadKey();

        }
    }
}
