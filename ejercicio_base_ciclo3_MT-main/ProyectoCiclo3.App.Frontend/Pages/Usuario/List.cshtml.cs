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
    public class ListUsuarioModel : PageModel
    {
       
        private readonly RepositorioUsuario _repositorioUsuario;
        [BindProperty]
        public Usuario usuario { get; set; }
        public IEnumerable<Usuario> usuarios {get;set;}
 
    public ListUsuarioModel (RepositorioUsuario _repositorioUsuario)
    {
        
        this._repositorioUsuario=_repositorioUsuario;
     }
 
    public void OnGet()
    {
        usuarios=_repositorioUsuario.GetAll();
    }
    public IActionResult OnPost()
    {
        if(usuario.id>0)
        {
        _repositorioUsuario.Delete(usuario.id);
        }
        return RedirectToPage("./List");
    }

    }
}

