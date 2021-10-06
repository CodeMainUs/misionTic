using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuarios;
        private readonly AppContext _appContext = new AppContext();  
 
    
 
        public IEnumerable<Usuario> GetAll()
        {
            return _appContext.Usuarios;
        }
        public Usuario Update(Usuario newusuario){
            var usuario= _appContext.Usuarios.Find(newusuario.id);
            if(usuario != null){
                usuario.id= newusuario.id;
                usuario.nombre= newusuario.nombre;
                usuario.apellidos=newusuario.apellidos;
                usuario.direccion=newusuario.direccion;
                usuario.telefono= newusuario.telefono;
                usuario.ciudad=newusuario.ciudad;
                _appContext.SaveChanges();
                
            }
        return usuario;
        }
        public Usuario Create(Usuario newusuario)
        {
           var addUsuario = _appContext.Usuarios.Add(newusuario);
            _appContext.SaveChanges();
            return addUsuario.Entity;

        }
        public void Delete(int id)
        {
             var user = _appContext.Usuarios.Find(id);
        if (user == null)
            return;
        _appContext.Usuarios.Remove(user);
        _appContext.SaveChanges();
        }



 
        public Usuario GetUserWithId(int usuarioid){
            return _appContext.Usuarios.Find(usuarioid);
        }
    }

    
}