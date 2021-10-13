using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        private readonly AppContext _appContext = new AppContext();

        public IEnumerable<Encomienda> GetAll()
        {
            return _appContext.Encomiendas;
        }
        public Encomienda Update(Encomienda newEncomienda){
            var encom= _appContext.Encomiendas.SingleOrDefault(b => b.id == newEncomienda.id);
            if(encom != null){
                encom.id= newEncomienda.id;
                encom.descripcion= newEncomienda.descripcion;
                encom.peso= newEncomienda.peso;
                encom.tipo= newEncomienda.tipo;
                encom.presentacion= newEncomienda.presentacion;
                _appContext.SaveChanges();
            }
        return encom;
        }
        public Encomienda Create(Encomienda newEncomienda)
        {
            var addEncomienda = _appContext.Encomiendas.Add(newEncomienda);
            _appContext.SaveChanges();
            return addEncomienda.Entity;
        }
        public void Delete(int id)
        {
        var encom= _appContext.Encomiendas.Find(id);
        if(encom != null){
                return;
            }
        _appContext.Encomiendas.Remove(encom);
        _appContext.SaveChanges();
        }

        public Encomienda GetEncomWithId(int encomiendaid){
            return _appContext.Encomiendas.Find(encomiendaid);
        }
    }

    
}