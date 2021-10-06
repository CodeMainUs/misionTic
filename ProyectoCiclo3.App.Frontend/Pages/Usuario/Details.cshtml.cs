using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;


namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class DetailsUsuarioModel : PageModel
    {
      private readonly RepositorioUsuario _repositorioUsuario;
              public Usuario usuarios {get;set;}
 
        public DetailsUsuarioModel (RepositorioUsuario _repositorioUsuario)
       {
            
            this._repositorioUsuario=_repositorioUsuario;
       }
 
        public IActionResult OnGet(int usuarioid)
        {
                usuarios = _repositorioUsuario.GetUserWithId(usuarioid);
                return Page();
 
        }
    }
}

    

