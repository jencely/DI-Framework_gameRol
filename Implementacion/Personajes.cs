using System;
using Juego.Interfaces;

namespace Implementacion
    {
     public class Mago : IPersonaje
        {
            public string GetPersonaje()
            {
                return "Merlin";
            }
        }
    }
     public class Elfo : IPersonaje
     {
        public string GetPersonaje()
        {
            return "Elfo de la noche";
        }
}

