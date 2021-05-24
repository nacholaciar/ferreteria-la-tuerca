using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Articulo
    {
        public int codProdArticulo { get; set; }
        public string descripcionArticulo { get; set; }
        public int codigoUnidadArticulo { get; set; }
        public float precioUnitarioArticulo { get; set; }
        public int marcaArticulo { get; set; }
        public int categoriaArticulo { get; set; }
    }
}
