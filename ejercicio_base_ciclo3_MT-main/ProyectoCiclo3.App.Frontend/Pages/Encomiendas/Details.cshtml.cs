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
    public class DetailsEncomiendaModel : PageModel
    {
      private readonly RepositorioEncomienda _repositorioEncomienda;
              public Encomienda encomiendas {get;set;}
 
        public  DetailsEncomiendaModel (RepositorioEncomienda _repositorioEncomienda)
       {
            
            this._repositorioEncomienda=_repositorioEncomienda;
       }
 
        public IActionResult OnGet(int encomiendaid)
        {
               encomiendas = _repositorioEncomienda.GetEncomWithId(encomiendaid);
                return Page();
 
        }
    }
}

    

