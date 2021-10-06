using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        List<Servicio> servicios;
 
    public RepositorioServicio()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen=2,destino=2,encomienda=1,hora="10:00",fecha=new DateTime(2015, 12, 31)},
                new Servicio{id=2,origen=2,destino=2,encomienda=1,hora="10:00",fecha=new DateTime(2015, 12, 31)},
                new Servicio{id=3,origen=2,destino=2,encomienda=1,hora="10:00",fecha=new DateTime(2015, 12, 31)},
 
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
        public Servicio Update(Servicio newServicio){
            var serv= servicios.SingleOrDefault(b => b.id == newServicio.id);
            if(serv != null){
                serv.id= newServicio.id;
                serv.origen= newServicio.origen;
                serv.destino= newServicio.destino;
                serv.encomienda= newServicio.encomienda;
                serv.hora= newServicio.hora;
                serv.fecha= newServicio.fecha;
                
            }
        return serv;
        }
        public Servicio Create(Servicio newServicio)
        {
           if(servicios.Count > 0){
           newServicio.id=servicios.Max(r => r.id) +1; 
            }else{
               newServicio.id = 1; 
            }
           servicios.Add(newServicio);
           return newServicio;
        }
        public Servicio Delete(int id)
        {
        var servi= servicios.SingleOrDefault(b => b.id == id);
        servicios.Remove(servi);
        return servi;
        }



 
        public Servicio GetServiWithId(int servicioid){
            return servicios.SingleOrDefault(u => u.id == servicioid);
        }
    }

    
}