using System;
using Implementacion;
using Implementacion2;
using ImplementacionA;
using Juego.Interfaces;
using Ninject.Bindings;
using Ninject;
namespace Juego_rol
{
    class Program
    {
        static void Main(string[] args)
        {
            var module = new Bindings();
            var kernel = new StandardKernel(module);
            Personaje_Servicio instantiatedService = null;
            Arma_Servicio instantiatedWeapon = null;
            Console.WriteLine("Selecciona un personaje:");
            Console.WriteLine("1. Mago");
            Console.WriteLine("2. Elfo");
            Console.WriteLine("4. Default");
            var valor_Personaje = Console.ReadLine();
            switch (valor_Personaje)
            {
                case "1":
                    var elfo = new Personaje_Servicio(new Elfo());
                    instantiatedService = elfo;
                    break;
                case "2":
                    var mago = new Personaje_Servicio(new Mago());
                    instantiatedService = mago;
                    break;
                default:
                    var servicio = kernel.Get<Personaje_Servicio>();
                    var arma = kernel.Get<Arma_Servicio>();
                    instantiatedService = servicio;
                    instantiatedWeapon = arma;
                    break;

            }
            Console.Clear();
            if (valor_Personaje != "")
            {
                Console.WriteLine("Selecciona un arma:");
                Console.WriteLine("1. Hechizo");
                Console.WriteLine("2. Espada");
            }
            var valor_Arma = Console.ReadLine();
            switch (valor_Arma)
            {
                case "1":
                    var espada = new Arma_Servicio(new Hechizo());
                    instantiatedWeapon = hechizo;
                    break;
                case "2":
                    var arco = new Arma_Servicio(new Espada());
                    instantiatedWeapon = espada;
                    break;
                
                default:
                    var arma = kernel.Get<Arma_Servicio>();
                    instantiatedWeapon = arma;
                    break;

            }
            Console.Clear();
            Console.WriteLine(instantiatedService.GetPersonaje() + instantiatedWeapon.Usar());
            Console.ReadKey();
        }
    }
}
}
