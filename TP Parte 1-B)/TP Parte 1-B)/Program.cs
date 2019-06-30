using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_1_B_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ingresar edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine(nombre + " es mayor de edad");
            }
            else
            {
                Console.WriteLine(nombre + " no es mayor de edad");
            }
            Console.ReadKey();
        }
    }
}
