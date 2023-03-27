using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("LINEUPPLAYER")]
    public class LineupPlayer
    {
        [Column("IDPARTIDO")]
        public int IdPartido { get; set; }
        [Column("IDEQUIPO")]
        public int IdEquipo { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("POSICION")]
        public string Posicion { get; set; }
        [Column("GRID")]
        public string Grid { get; set; }
    }
}
