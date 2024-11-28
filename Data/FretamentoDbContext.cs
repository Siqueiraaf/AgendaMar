using FretamentoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FretamentoApi.Data
{
    public class FretamentoDbContext : DbContext
    {
        public required DbSet<Usuario> Usuarios { get; set; }
        public required DbSet<Embarcacao> Embarcacoes { get; set; }
        public required DbSet<Fretamento> Fretamentos { get; set; }

        public FretamentoDbContext(
            DbContextOptions<FretamentoDbContext> options) : base(options) { }
    }
}
