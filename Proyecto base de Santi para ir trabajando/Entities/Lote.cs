using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    //class Lote
    //{
    //    //private string Descripcion;
    //    private int Borrado;
    //    private string FechaIngreso;
    //    private string FechaVencimiento;
    //    private string CodigoProveedor;
    //    private string CantidadArticulos;


    //    public Lote(int borrado, string fechaIngreso, string fechaVencimiento,string codigoProveedor, string cantidadArticulos)
    //    {

    //        //Descripcion = descripcion;
    //        Borrado = borrado;
    //        FechaIngreso = fechaIngreso;
    //        FechaVencimiento = fechaVencimiento;
    //        CodigoProveedor = codigoProveedor;
    //        CantidadArticulos = cantidadArticulos;

    //    }

    //    //public string DescripcionLote
    //    //{
    //    //    get => Descripcion;
    //    //    set => Descripcion = value;

    //    //}

    //    public int BorradoLote
    //    {
    //        get => Borrado;
    //        set => Borrado = value;
    //    }

    //    public string FechaIngresoLote
    //    {
    //        get => FechaIngreso;
    //        set => FechaIngreso= value;
    //    }
    //    public string FechaVencimientoLote
    //    {
    //        get => FechaVencimiento;
    //        set => FechaVencimiento = value;
    //    }
    //    public string CodigoProveedorLote
    //    {
    //        get => CodigoProveedor;
    //        set => CodigoProveedor = value;
    //    }
    //    public string CantidadArticulosLote
    //    {
    //        get => CantidadArticulos;
    //        set => CantidadArticulos = value;
    //    }
    //}   


    public class Lote
    {
        private int CodArticulo;
        private DateTime FechaIngreso;
        private DateTime FechaVencimiento;
        private int CantidadArticulos;
        private int CodProveedor;
        private int Borrado;


        public Lote()
        {

        }

        public int CodArticuloLote
        {
            get => CodArticulo;
            set => CodArticulo = value;
        }

        public DateTime FechaIngresoLote
        {
            get => FechaIngreso;
            set => FechaIngreso = value;
        }

        public DateTime FechaVencimientoLote
        {
            get => FechaVencimiento;
            set => FechaVencimiento = value;
        }

        public int CantidadArticulosLote
        {
            get => CantidadArticulos;
            set => CantidadArticulos = value;
        }

        public int CodProveedorLote
        {
            get => CodProveedor;
            set => CodProveedor = value;
        }

        public int BorradoLote
        {
            get => Borrado;
            set => Borrado = value;
        }

}

}
