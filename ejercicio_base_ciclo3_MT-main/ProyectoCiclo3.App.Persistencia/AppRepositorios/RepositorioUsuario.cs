using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuario()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Sofia",apellidos="Pedroza",direccion="calle26b",telefono="3188166247"},
                new Usuario{id=2,nombre="Alejandro",apellidos="Pedroza",direccion="calle26b",telefono="3112166247"},
                new Usuario{id=3,nombre="Julian",apellidos="Montufar",direccion="calle26b",telefono="3122166247"},
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetUserWithId(int usuarioid){
            return usuarios.SingleOrDefault(u => u.id == usuarioid);
        }
    }

    
}