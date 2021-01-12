using Microsoft.EntityFrameworkCore;
using WebStore.Domain;
namespace WebStore.Infra
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
