using Biblioteca.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.NET.Context
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :base(options)
        {

        }

        public DbSet<Livro> Livros { get; set; }
       
    }
}
