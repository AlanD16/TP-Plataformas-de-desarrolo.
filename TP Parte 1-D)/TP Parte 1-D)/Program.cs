using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_1_D_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            int menor = 0;
            int mayor = 0;
            int resto;

            if (num1 < num2)
            {
                menor = num1;
                mayor = num2;
            }
            if (num2 < num1)
            {

                menor = num2;
                mayor = num1;
            }
            do
            {
                resto = menor;
                menor = mayor % menor;
                mayor = resto;
            } while (menor != 0);

            Console.WriteLine(resto);

            
            Console.ReadKey();
        }
    }
}
