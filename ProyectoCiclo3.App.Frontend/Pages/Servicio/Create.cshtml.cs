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
    public class FormServicioModel : PageModel
    {
        
        
      private readonly RepositorioServicio _repositorioServicio;
      [BindProperty]
              public Servicio servicios {get;set;}
 
        public FormServicioModel (RepositorioServicio _repositorioServicio)
       {
            
            this._repositorioServicio=_repositorioServicio;
       }
       
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            servicios = _repositorioServicio.Create(servicios);
            
            return RedirectToPage("./List");
        }

    }
}

