using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    class Barrio
    {

        private int codBarrio;
        private string nombre;
        private int codLocalidad;

        public Barrio()
        {

        }
        public int CodBarrio
        {
            get => codBarrio;
            set => codBarrio = value;
        }
        public string nombreBarrio
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
