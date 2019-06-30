using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_2__B_
{
    interface InterfazDeRueda
    {
        void Iniciar();
        void Frenar();
        
         double Diametro { get; set; }

    }
}
