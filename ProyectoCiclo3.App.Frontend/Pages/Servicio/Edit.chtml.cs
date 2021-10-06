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
    public class EditServicioModel : PageModel
    {
        
        
      private readonly RepositorioServicio _repositorioServicio;
      [BindProperty]
              public Servicio servicios {get;set;}
 
        public EditServicioModel (RepositorioServicio _repositorioServicio)
       {
            
            this._repositorioServicio=_repositorioServicio;
       }
 
        public IActionResult OnGet(int usuarioid)
        {
                servicios = _repositorioServicio.GetServiWithId(usuarioid);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(servicios.id>0)
            {
            servicios = _repositorioServicio.Update(servicios);
            }
            return Page();
        }

    }
}
