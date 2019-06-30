using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_1_A_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingresar nombre: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingresar apellido: ");
            var apellido = Console.ReadLine();

            Console.WriteLine(nombre + " " + apellido);
            Console.ReadKey();
        }
    }
}
