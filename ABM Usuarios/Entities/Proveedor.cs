using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Proveedor
    {
        public string CUITProveedor { get; set; }
        public string RazonSocialProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string ApellidoProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public string CalleProveedor { get; set; }
        public int NumeroProveedor { get; set; }
        public int CodBarrioProveedor { get; set; }
    }
}
