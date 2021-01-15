using Juego.Interfaces;
using Ninject;


namespace Implementacion2
{
    public class Arma_Servicio
    {
        private readonly IArmas Repositorio;

        [Inject]
        public Arma_Servicio(IArmas repositorio)
        {
            Repositorio = repositorio;
        }

        public string Usar()
        {
            return Repositorio.Usar();
        }
    }
}
