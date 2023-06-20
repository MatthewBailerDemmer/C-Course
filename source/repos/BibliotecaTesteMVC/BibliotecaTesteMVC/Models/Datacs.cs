using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaTesteMVC.Models
{
    [Table("Datas")]
    public class Datacs
    {
        [Column("cdDatas")]
        public int Id { get; set; }

        [Column("dsData")]
        public DateTime data { get; set; }
    }
}
