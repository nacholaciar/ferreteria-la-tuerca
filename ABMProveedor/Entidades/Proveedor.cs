using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMProveedor.Entidades
{
    public class Proveedor
    {
        // atributos
        private string CUIT;
        private string RazonSocial;
        private string Nombre;
        private string Apellido;
        private string Telefono;
        private string Calle;
        private int Numero;
        private int CodBarrio;
        //private int Borrado;

        public Proveedor()
        {
        }

        public string CUITProveedor
        {
            get => CUIT;
            set => CUIT = value;
        }

        public string RazonSocialProveedor
        {
            get => RazonSocial;
            set => RazonSocial = value;
        }

        public string NombreProveedor
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string ApellidoProveedor
        {
            get => Apellido;
            set => Apellido = value;
        }

        public string TelefonoProveedor
        {
            get => Telefono;
            set => Telefono = value;
        }

        public string CalleProveedor
        {
            get => Calle;
            set => Calle = value;
        }

        public int NumeroProveedor
        {
            get => Numero;
            set => Numero = value;
        }


        public int CodBarrioProveedor
        {
            get => CodBarrio;
            set => CodBarrio = value;
        }

        //public int BorradoProveedor
        //{
        //    get => Borrado;
        //    set => Borrado = value;
        //}

    }
}
