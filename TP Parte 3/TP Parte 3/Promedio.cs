using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_3
{
    public static class Promedio
    {

        public static double Promedios(this double valores,double cantidad)
        {
            double promedio = valores / cantidad;
            return promedio;
        }
    }
}
