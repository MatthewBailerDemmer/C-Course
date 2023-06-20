using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Biblioteca.NET.Models
{
    [Table("Livro")]
    public class Livro
    {
        [Column("cdLivro")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("dsTitulo")]
        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Column("dsAutor")]
        [Display(Name = "Autor")]
        public string autor { get; set; }

        [Column("dtPublicacao")]
        [Display(Name = "Data de publicação: ")]
        public DateTime dtPublicacao { get; set; }

        [Column("nrPaginas")]
        [Display(Name = "Número de páginas")]
        public int nrPaginas { get; set; }

        [Column("dsCategoria")]
        [Display(Name = "Categoria")]
        public string categoria { get; set; }


    }
}
