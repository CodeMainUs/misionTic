using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        private readonly AppContext _appContext = new AppContext();
 
    
 
        public IEnumerable<Servicio> GetAll()
        {
            return _appContext.Servicios;
        }
        public Servicio Update(Servicio newServicio){
            var serv= _appContext.Servicios.SingleOrDefault(b => b.id == newServicio.id);
            if(serv != null){
                serv.id= newServicio.id;
                serv.origen= newServicio.origen;
                serv.destino= newServicio.destino;
                serv.encomienda= newServicio.encomienda;
                serv.hora= newServicio.hora;
                serv.fecha= newServicio.fecha;
                _appContext.SaveChanges();
                
            }
        return serv;
        }
        public Servicio Create(Servicio newServicio)
        {
          var addServicio = _appContext.Servicios.Add(newServicio);
            _appContext.SaveChanges();
            return addServicio.Entity;
        }
        public void Delete(int id)
        {
        var serv = _appContext.Servicios.Find(id);
        if (serv == null)
            return;
        _appContext.Servicios.Remove(serv);
        _appContext.SaveChanges();

        }
        public Servicio GetServiWithId(int servicioid){
            return _appContext.Servicios.Find(servicioid);
        }
    }

    
}