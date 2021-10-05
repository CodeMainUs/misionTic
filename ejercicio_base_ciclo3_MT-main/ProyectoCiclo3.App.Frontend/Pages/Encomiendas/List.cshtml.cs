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
    public class ListEncomiendaModel : PageModel
    {
       
        private readonly RepositorioEncomienda _repositorioEncomienda;
        [BindProperty]
        public Encomienda encomienda { get; set; }
        public IEnumerable<Encomienda> encomiendas {get;set;}
 
    public ListEncomiendaModel (RepositorioEncomienda _repositorioEncomienda)
    {
        
        this._repositorioEncomienda=_repositorioEncomienda;
     }
 
    public void OnGet()
    {
        encomiendas=_repositorioEncomienda.GetAll();
    }
    public IActionResult OnPost()
    {
        if(encomienda.id>0)
        {
        _repositorioEncomienda.Delete(encomienda.id);
        }
        return RedirectToPage("./List");
    }

    }
}

