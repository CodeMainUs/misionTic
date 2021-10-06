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
    public class ListServicioModel : PageModel
    {
       
        private readonly RepositorioServicio _repositorioServicio;
        [BindProperty]
        public Servicio servicio { get; set; }
        public IEnumerable<Servicio> servicios { get; set; }
 
    public ListServicioModel (RepositorioServicio _repositorioServicio)
    {
        
        this._repositorioServicio = _repositorioServicio;
     }
 
    public void OnGet()
    {
        servicios=_repositorioServicio.GetAll();
    }
    public IActionResult OnPost()
    {
        if(servicio.id>0)
        {
        _repositorioServicio.Delete(servicio.id);
        }
        return RedirectToPage("./List");
    }

    }
}

