using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_1_E_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;
            int cantidad = -1; //Suponiendo que no cuente el 0 como número para promediar.
            double promedio;
            do
            {
                Console.WriteLine("Ingresar número: ");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
                cantidad++;


            } while (num != 0);

            promedio = suma / cantidad;
            Console.WriteLine("El promedio de los números ingresados es: " + promedio);

            Console.ReadKey();
        }
    }
}
