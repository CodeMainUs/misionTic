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
    public class EditServicioModel : PageModel
    {
        
      private readonly RepositorioUsuario _repositorioUsuario;
      private readonly RepositorioEncomienda _repositorioEncomienda;
      private readonly RepositorioServicio _repositorioServicio;
      [BindProperty]
              public Servicio servicios {get;set;}
              public IEnumerable<Usuario> Usuarios{get;set;}
              public IEnumerable<Encomienda> Encomiendas{get;set;}
 
        public EditServicioModel (RepositorioServicio _repositorioServicio,RepositorioUsuario _repositorioUsuario,RepositorioEncomienda _repositorioEncomienda)
       {
            
            this._repositorioServicio=_repositorioServicio;
            this._repositorioUsuario=_repositorioUsuario;
            this._repositorioEncomienda=_repositorioEncomienda;
       }
 
        public IActionResult OnGet(int servicioid)
        {
                servicios = _repositorioServicio.GetServiWithId(servicioid);
                Usuarios = _repositorioUsuario.GetAll();
                Encomiendas = _repositorioEncomienda.GetAll();
                return Page();
 
        }
        public IActionResult OnPost(int Id,int origen,int destino,string fecha,string hora, int encomienda)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(servicios.id>0)
            {
                servicios = _repositorioServicio.Update(Id,origen, destino, fecha, hora, encomienda);
            }
            return RedirectToPage("./List");
        }

    }
}
