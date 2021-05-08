using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{
    class Cliente
    {

        private int dniCliente;
        private int TipodniCliente;
        private string apellido;
        private string nombre;
        private string telefono;
        private string cuit;
        private string mail;
        private string calle;
        private int nroCalle;
        private int codBarrio;

        public Cliente()
        { }
        public Cliente(string Name, string Surname, string Phone, string Cuit, string Mail, int typeDocument, int NumberDocument, string Address, int NumberAdrress, int District)
        {
            this.nombre = Name;
            this.apellido = Surname;
            this.telefono = Phone;
            this.cuit = Cuit;
            this.Mail = Mail;
            this.TipodniCliente = typeDocument;
            this.dniCliente = NumberDocument;
            this.calle = Address;
            this.nroCalle = NumberAdrress;
            this.codBarrio = District;
        }
        public int TipoDniCliente
        {
            get => TipodniCliente;
            set => TipodniCliente = value;

        }
        public int DniCliente
        {
            get => dniCliente;
            set => dniCliente = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string Cuit
        {
            get => cuit;
            set => cuit = value;
        }
        public string Mail
        {
            get => mail;
            set => mail = value;
        }
        public string Calle
        {
            get => calle;
            set => calle = value;
        }
        public int NroCalle
        {
            get => nroCalle;
            set => nroCalle = value;
        }
        public int CodBarrio
        {
            get => codBarrio;
            set => codBarrio = value;
        }

    }
}

