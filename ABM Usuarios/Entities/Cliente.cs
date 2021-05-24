using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Cliente
    {
        public int TipoDniCliente { get; set; }
        public int DniCliente { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cuit { get; set; }
        public string Mail { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int CodBarrio { get; set; }
    }
}
