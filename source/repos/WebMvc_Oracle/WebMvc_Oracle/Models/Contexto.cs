using Microsoft.EntityFrameworkCore;

namespace WebMvc_Oracle.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :base(options)
        {

        }


        public DbSet<Produto> Produtos { get; set; }
    }
}
