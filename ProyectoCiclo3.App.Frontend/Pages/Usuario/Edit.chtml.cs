using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace ProyectoCiclo3.App.Frontend.Pages
{
    [Authorize]
    public class EditUsuarioModel : PageModel
    {
        
        
      private readonly RepositorioUsuario _repositorioUsuario;
      [BindProperty]
              public Usuario usuarios {get;set;}
 
        public EditUsuarioModel (RepositorioUsuario _repositorioUsuario)
       {
            
            this._repositorioUsuario=_repositorioUsuario;
       }
 
        public IActionResult OnGet(int usuarioid)
        {
                usuarios = _repositorioUsuario.GetUserWithId(usuarioid);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(usuarios.id>0)
            {
            usuarios = _repositorioUsuario.Update(usuarios);
            }
            return  RedirectToPage("./List");
        }

    }
}
