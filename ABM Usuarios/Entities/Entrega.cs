using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Entrega
    {
        public static Entrega EntregaActual = new Entrega();

        public int CodEntrega { get; set; }
        public int NroFactura { get; set; }
        public string EmpleadoACargo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEntregaReal { get; set; }
        public string EstadoEntrega { get; set; }
        public int DniCliente { get; set; }
        public string DomicilioCliente { get; set; }

        public string tipoFactura { get; set; }
    }
}

