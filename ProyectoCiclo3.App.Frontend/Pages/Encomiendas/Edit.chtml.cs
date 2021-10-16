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
    public class EditEncomiendaModel : PageModel
    {
        
        
      private readonly RepositorioEncomienda _repositorioEncomienda;
            [BindProperty]
              public Encomienda encomiendas {get;set;}
 
        public EditEncomiendaModel (RepositorioEncomienda _repositorioEncomienda)
       {
            
            this._repositorioEncomienda=_repositorioEncomienda;
       }
 
        public IActionResult OnGet(int encomiendaid)
        {
                encomiendas = _repositorioEncomienda.GetEncomWithId(encomiendaid);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(encomiendas.id>0)
            {
            encomiendas =  _repositorioEncomienda.Update(encomiendas);
            }
            return RedirectToPage("./List");
        }

    }
}
