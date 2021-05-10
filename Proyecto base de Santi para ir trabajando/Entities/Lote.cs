using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    class Lote
    {
        //private string Descripcion;
        private int Borrado;
        private string FechaIngreso;
        private string FechaVencimiento;
        private string CodigoProveedor;
        private string CantidadArticulos;
        


        public Lote(int borrado, string fechaIngreso, string fechaVencimiento,string codigoProveedor, string cantidadArticulos)
        {

            //Descripcion = descripcion;
            Borrado = borrado;
            FechaIngreso = fechaIngreso;
            FechaVencimiento = fechaVencimiento;
            CodigoProveedor = codigoProveedor;
            CantidadArticulos = cantidadArticulos;

        }

        //public string DescripcionLote
        //{
        //    get => Descripcion;
        //    set => Descripcion = value;

        //}

        public int BorradoLote
        {
            get => Borrado;
            set => Borrado = value;
        }

        public string FechaIngresoLote
        {
            get => FechaIngreso;
            set => FechaIngreso= value;
        }
        public string FechaVencimientoLote
        {
            get => FechaVencimiento;
            set => FechaVencimiento = value;
        }
        public string CodigoProveedorLote
        {
            get => CodigoProveedor;
            set => CodigoProveedor = value;
        }
        public string CantidadArticulosLote
        {
            get => CantidadArticulos;
            set => CantidadArticulos = value;
        }
    }   
}
