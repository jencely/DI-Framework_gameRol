using Implementacion2;
using Implementacion;
using ImplementacionA;
using Juego.Interfaces;
using Ninject.Modules;

namespace Ninject.Bindings
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonaje>().To<Hechizo>();
            Bind<IArmas>().To<Espada>();
        }
    }
}
