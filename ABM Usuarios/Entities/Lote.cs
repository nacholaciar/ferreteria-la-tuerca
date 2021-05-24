using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Lote
    {
        public int IdLote { get; set; }
        public int CodArticulo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CantidadArticulos { get; set; }
        public int CodProveedor { get; set; }
        public int Borrado { get; set; }
    }
}
