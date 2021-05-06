using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entities
{

    public class Perfil
    {
        private int IdPerfil;
        private string Nombre;
    }

    public Perfil()
    {

    }

    public Perfil (int idPerfil, string nombre)
    {
        this.IdPerfil = idPerfil;
        this.Nombre = nombre;
    }

    public int IdPerfilUsuario
    {
        get => IdPerfil;
        set => IdPerfil = Value;
    }
    
    public string NombreDeUsuario
    {
        get => Nombre;
        set => Nombre = value;
    }
}
