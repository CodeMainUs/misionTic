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
    public class FormUsuarioModel : PageModel
    {
        
        
      private readonly RepositorioUsuario _repositorioUsuario;
      [BindProperty]
              public Usuario usuarios {get;set;}
 
        public FormUsuarioModel (RepositorioUsuario _repositorioUsuario)
       {
            
            this._repositorioUsuario=_repositorioUsuario;
       }
       
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            usuarios = _repositorioUsuario.Create(usuarios);
            
            return RedirectToPage("./List");
        }

    }
}

