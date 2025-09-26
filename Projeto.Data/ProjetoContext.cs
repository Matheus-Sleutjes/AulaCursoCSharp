using Microsoft.EntityFrameworkCore;
using Projeto.Data.Model;

namespace Projeto.Data
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
