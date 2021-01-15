using Juego.Interfaces;
using Ninject;

namespace Implementacion2
{
   public class Personaje_Servicio
    {
        private readonly IPersonaje Repositorio;

        [Inject]
        public Personaje_Servicio(IPersonaje repositorio)
        {
            Repositorio = repositorio;
        }

        public string GetPersonaje()
        {
            return Repositorio.GetPersonaje();
        }
    }
}
