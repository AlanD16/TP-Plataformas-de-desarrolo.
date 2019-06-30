using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Materias materia = new Materias();
            List<Materias> materias = new List<Materias> { new Materias() { Nombre = "Matematica", Año = 2018, Cuatrimestre = 2,Tipo = "TP", Fecha = 22/01/14, Valor = 2 },
                                                           new Materias() { Nombre = "Fisica", Año = 2018, Cuatrimestre = 2,Tipo = "TP", Fecha = 23/02/15, Valor = 5 },
                                                           new Materias() { Nombre = "Quimica", Año = 2018, Cuatrimestre = 1,Tipo = "Parcial", Fecha = 24/03/16, Valor = 8 },
                                                           new Materias() { Nombre = "Matematica", Año = 2018, Cuatrimestre = 1,Tipo = "TP", Fecha = 22/01/14, Valor = 6 }
                                                           };
                                                                                       
            foreach (Materias m in materias)
            {
                Console.WriteLine("Materia: " + m.Nombre + "\n Año: " + m.Año + "\nCuatrimestre: " + m.Cuatrimestre);
            }


            List<Materias> consultaPorCuatrimestre = materias.
               Where(x => x.Cuatrimestre > 1 && x.Cuatrimestre < 3)
               .ToList();
            List<Materias> ordAlf = consultaPorCuatrimestre.OrderBy(x=>x.Nombre)
            .ToList();


            foreach (Materias m in ordAlf)
            {
                Console.WriteLine("Materias: " + m.Nombre);
            }



            /*
             
            Esto está comentado porque me sale un error en la consulta que no pude solucionar. 
            El ejercicio continúa a partir de esos errores si se pudiera solucionar la línea con el error.
            
             List<Materias> tipoNotas = from n in materias
                                       where n.Tipo="TP"
                                       select n;

            foreach (Materias m in tipoNotas)
            {
                Console.WriteLine("Nota de tipo TP: " + m.Valor);
            }
              */

            /*
            List<Materias> materiaMat = from n in materias
                                        where n.Nombre = "Matematica"
                                        select n;
            double acumulador=0;
            double contador=0;
            foreach (Materias m in materiaMat) {
                acumulador =acumulador+ m.Valor;
                contador++;
            }
           
            double promedio = acumulador.Promedios(contador);
            Console.WriteLine("El promedio de la materia "+ materiaMat.Nombre+" es: "+promedio);
            */

            
            

            Console.ReadKey();




        }
    }
}
