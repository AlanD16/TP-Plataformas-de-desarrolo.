using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_2__A_
{
    class Circulo : Figuras
    {
        double radio = 10;
        double perimetro;
        double area;
        public double CalcularArea()
        {
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
        public double CalcularPerimetro()
        {
            perimetro = 2 * Math.PI * radio;
            return perimetro;

        }

    }

}
