using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    public class Empleado
    {
        public static Empleado EmpleadoActual = new Empleado();

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public int NumeroDoc { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngr { get; set; }
    }
}
