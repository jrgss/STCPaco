using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("COMPETICION")]
    public class Competicion
    {
        [Key]
        [Column("IDCOMPETICION")]
        public int IdCompeticion { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("TIPOCOMPE")]
        public string Type { get; set; }
        [Column("LOGO")]
        public string Logo { get; set; }
        [Column("PAIS")]
        public string Pais { get; set; }
        [Column("BANDERAPAIS")]
        public string BanderaPais { get; set; }
    }
}
