epositorioBuses.cs
using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public interface RepositoriosUsuario
    {
         List<Usuario> usuarios;
         public RepositoriosUsuario()
         {
             usuarios = new List<Usuario>()
             {
                 new Usuario(1,"Sofia","Pedroza","calle 26b","3188166247"),
                 new Usuario(2,"Julian","Montufar","calle 26b","3188166247"),
                 new Usuario(2,"Nohora","Narvaez","calle 2b","3148166247")

             };

         }
    }
}