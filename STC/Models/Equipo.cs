using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace STC.Models
{
    [Table("EQUIPO")]
    public class Equipo
    {
        [Key]
        [Column("IDEQUIPO")]
        public int IdEquipo { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("ABREVIATURA")]
        public string Abreviatura { get; set; }
        [Column("LOGO")]
        public string Logo { get; set; }
        [Column("IDVENUE")]
        public int IdVenue { get; set; }
        [Column("PAIS")]
        public string Pais { get; set; }
    }
}
