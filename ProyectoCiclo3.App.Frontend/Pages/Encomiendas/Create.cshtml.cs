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
    public class FormEncomiendaModel : PageModel
    {
        
        
      private readonly RepositorioEncomienda _repositorioEncomienda;
      [BindProperty]
              public Encomienda encomiendas {get;set;}
 
        public FormEncomiendaModel (RepositorioEncomienda _repositorioEncomienda)
       {
            
            this._repositorioEncomienda=_repositorioEncomienda;
       }
       
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            encomiendas = _repositorioEncomienda.Create(encomiendas);
            
            return RedirectToPage("./List");
        }

    }
}

