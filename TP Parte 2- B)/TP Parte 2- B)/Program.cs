using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parte_2__B_
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor();
            Ruedas ruedas = new Ruedas();
            Cambios cambios = new Cambios();
            Auto auto = new Auto();
            /*
            List<Motor> motores = new List<Motor>() { new Motor() {Cilindrada=150}};
            foreach (Motor m in motores) {
                Console.WriteLine(m.Cilindrada+"\n");
            }
            List<Ruedas> rueda = new List<Ruedas>() { new Ruedas() {Diametro=30 } };
            foreach (Ruedas r in rueda)
            {
                Console.WriteLine(r.);
            }
            List<Cambios> cambio = new List<Cambios>() { new Cambios() {tipo="Manual",cantidadDeCambios=5  } };
            foreach (Cambios c in cambio)
            {
                Console.WriteLine();
            }
            List<Auto> autos = new List<Auto>() { new Auto() {listaDeRuedas=4,motor="Hidraulico",CajaDeCambios=5  } };
            foreach (Auto a in autos)
            {
                Console.WriteLine();
            }
            */
            
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Cilindrada:");
                motor.Cilindrada =Double.Parse(Console.ReadLine());
                Console.WriteLine("Diametro:");
                ruedas.Diametro = Double.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de cambios:");
                cambios.cantidadDeCambios = int.Parse(Console.ReadLine());
                Console.WriteLine("tipo:");
                cambios.tipo = Console.ReadLine();
                Console.WriteLine("Lista de ruedas:");
                auto.listaDeRuedas = int.Parse(Console.ReadLine());
                Console.WriteLine("Caja de cambios");
                auto.CajaDeCambios= int.Parse(Console.ReadLine());
                Console.WriteLine("motor:");
                auto.motor = Console.ReadLine(); 

                Console.WriteLine("Auto: \n" + "Lista de ruedas: " + auto.listaDeRuedas + "\n Caja de cambios: " + auto.CajaDeCambios + " \nMotor: " + auto.motor + "\n cilindrada: " + motor.Cilindrada +
                "\n diámetro de ruedas: " + ruedas.Diametro + "\n cantidad de cambios: " + cambios.cantidadDeCambios);
            }
            
            Console.ReadKey();
        }
    }
}
