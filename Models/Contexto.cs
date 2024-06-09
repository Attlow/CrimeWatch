using Microsoft.EntityFrameworkCore;

namespace CrimeWatch.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
        public DbSet<Denuncia> Denuncia { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}