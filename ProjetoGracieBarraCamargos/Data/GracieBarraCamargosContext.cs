using ProjetoGracieBarraCamargos.Models;

namespace ProjetoGracieBarraCamargos.Data
{
    public class GracieBarraCamargosContext : DbContext
    {
        public GracieBarraCamargosContext(DbContextOptions<GracieBarraCamargosContext> option) : base(options) { }

        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Presenca> Presencas { get; set; }
    }
}
