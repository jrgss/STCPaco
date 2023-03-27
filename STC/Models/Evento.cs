using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    //[Keyless]
    [Table("EVENTO")]
    public class Evento
    {
        [Key]
        [Column("IDEVENTO")]
        public int IdEvento { get; set; }
        [Column("IDPARTIDO")]
        public int IdPartido { get; set; }
        [Column("ELAPSED")]
        public int Elapsed { get; set; } 
        [Column("EXTRA")]
        public int Extra { get; set; }
        [Column("IDEQUIPO")]
        public int IdEquipo { get; set; }
        [Column("NOMBREJUGADOR")]
        public string NombreJugador { get; set; }
        [Column("NOMBREASISTENCIA")]
        public string NombreAsistencia { get; set; }
        [Column("TIPO")]
        public string Tipo { get; set; }
        [Column("DETALLES")]
        public string Detalles { get; set; }
        [Column("COMMENTS")]
        public string Comentarios { get; set; }


    }
}
