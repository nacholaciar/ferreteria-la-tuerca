using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Perfil
    {
        public static Perfil PerfiActual = new Perfil();

        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
    }
}
