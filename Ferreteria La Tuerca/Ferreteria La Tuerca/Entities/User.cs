using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_La_Tuerca.Entities
{
    public class User
    {
      
        
            private string codUsu;
            private string nombreUsuario;
            private string password;
            private int perfil;
            private string dniEmpleado;
            private int TipodniEmpleado;

            public User()
            {

            }
            public User(string NameUser, string Pass)
            {
                this.nombreUsuario = NameUser;
                this.password = Pass;

            }
            public string CodUsu
            {
                get => codUsu;
                set => codUsu = value;
            }
            public string nameUser
            {
                get => nombreUsuario;
                set => nombreUsuario = value;
            }
            public string Password
            {
                get => password;
                set => password = value;
            }
            public int Perfil
            {
                get => perfil;
                set => perfil = value;
            }
            public int TipoDniEmpleado
            {
                get => TipodniEmpleado;
                set => TipodniEmpleado = value;

            }
            public string DniEmpleado
            {
                get => dniEmpleado;
                set => dniEmpleado = value;
            }
    }
    
}
