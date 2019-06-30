using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_2__A_
{
    class Cuadrado : Figuras
    {
        double lado = 10;
        double perimetro;
        double area;
        public double CalcularArea()
        {
            perimetro = lado * 4;
            return perimetro;
        }
        public double CalcularPerimetro()
        {
            area = Math.Pow(lado, 2);
            return area;
        }

    }
}
