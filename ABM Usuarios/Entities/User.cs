using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class User
    {
        public static User UsuarioActual = new User();

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int Perfil { get; set; }
        public int Empleado { get; set; }
    }
}
