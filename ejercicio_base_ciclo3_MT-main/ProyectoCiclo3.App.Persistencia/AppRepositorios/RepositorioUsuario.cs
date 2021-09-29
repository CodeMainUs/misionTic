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
                new Usuario{id=1,nombre="Sofia",apellidos="Pedroza",direccion="calle26b",telefono="3188166247",ciudad="Pasto"},
                new Usuario{id=2,nombre="Alejandro",apellidos="Pedroza",direccion="calle26b",telefono="3112166247",ciudad="Pasto"},
                new Usuario{id=3,nombre="Julian",apellidos="Montufar",direccion="calle26b",telefono="3122166247",ciudad="Pasto"},
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
        public Usuario Update(Usuario newusuario){
            var usuario= usuarios.SingleOrDefault(b => b.id == newusuario.id);
            if(usuario != null){
                usuario.id= newusuario.id;
                usuario.nombre= newusuario.nombre;
                usuario.apellidos=newusuario.apellidos;
                usuario.direccion=newusuario.direccion;
                usuario.telefono= newusuario.telefono;
                usuario.ciudad=newusuario.ciudad;
                
            }
        return usuario;
        }

 
        public Usuario GetUserWithId(int usuarioid){
            return usuarios.SingleOrDefault(u => u.id == usuarioid);
        }
    }

    
}