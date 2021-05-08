using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    class Localidad
    {
        private int codLocalidad;
        private string nombre;

        public Localidad()
        {

        }
        public string nombreLocalidad
        {
            get => nombre;
            set => nombre = value;
        }
        public int CodLocalidad
        {
            get => codLocalidad;
            set => codLocalidad = value;
        }
    }
}
