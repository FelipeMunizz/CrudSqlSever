using Microsoft.EntityFrameworkCore;

namespace CrudSqlSever.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
