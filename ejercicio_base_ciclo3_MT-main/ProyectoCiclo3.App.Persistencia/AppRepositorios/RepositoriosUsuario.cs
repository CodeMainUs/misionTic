namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public interface RepositoriosUsuario
    {
         List<Usuario> usuarios;
         public RepositoriosUsuario()
         {
             usuarios = new List<Usuario>()
             {
                 new Usuario()

             };

         }
    }
}