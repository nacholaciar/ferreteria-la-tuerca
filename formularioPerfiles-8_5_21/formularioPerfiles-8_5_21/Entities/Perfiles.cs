using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formularioPerfiles_8_5_21.Entities
{
    class Perfiles
    {
        private string Nombre;
        

        public Perfiles(string nombre)
        {
            this.Nombre= nombre;
        }

        public Perfiles() { }

        public string NombrePerfil
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
