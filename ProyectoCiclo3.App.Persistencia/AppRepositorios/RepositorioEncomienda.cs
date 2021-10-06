using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> encomiendas;
 
    public RepositorioEncomienda()
        {
            encomiendas= new List<Encomienda>()
            {
                new Encomienda{id=1,descripcion="Alexa echodot",peso=2.3,tipo="Electrodomestico",presentacion="Amazon"},
                new Encomienda{id=2,descripcion="Iphone",peso=2.3,tipo="Electrodomestico",presentacion="Amazon"},
                new Encomienda{id=3,descripcion="Ultrawide",peso=2.3,tipo="Electrodomestico",presentacion="Amazon"},
 
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return encomiendas;
        }
        public Encomienda Update(Encomienda newEncomienda){
            var encom= encomiendas.SingleOrDefault(b => b.id == newEncomienda.id);
            if(encom != null){
                encom.id= newEncomienda.id;
                encom.descripcion= newEncomienda.descripcion;
                encom.peso= newEncomienda.peso;
                encom.tipo= newEncomienda.tipo;
                encom.presentacion= newEncomienda.presentacion;
            }
        return encom;
        }
        public Encomienda Create(Encomienda newEncomienda)
        {
           if(encomiendas.Count > 0){
           newEncomienda.id=encomiendas.Max(r => r.id) +1; 
            }else{
               newEncomienda.id = 1; 
            }
           encomiendas.Add(newEncomienda);
           return newEncomienda;
        }
        public Encomienda Delete(int id)
        {
        var encom= encomiendas.SingleOrDefault(b => b.id == id);
        encomiendas.Remove(encom);
        return encom;
        }

        public Encomienda GetEncomWithId(int encomiendaid){
            return encomiendas.SingleOrDefault(u => u.id == encomiendaid);
        }
    }

    
}