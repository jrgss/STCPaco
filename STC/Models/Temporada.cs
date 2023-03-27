using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("TEMPORADA")]
    public class Temporada
    {
        [Key]
        [Column("IDTEMPORADA")]
        public int IdTemporada { get; set; }
        [Column("FECHAINICIO")]
        public DateTime FechaInicio { get; set; }
        [Column("FECHAFINAL")]
        public DateTime FechaFinal { get; set; }
    }
}
