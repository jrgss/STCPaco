using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("LINEUP")]
    public class LineupB
    {

        [Column("IDPARTIDO")]
        public int IdPartido { get; set; }
        [Column("IDEQUIPO")]
        public int IdEquipo { get; set; }
        [Column("ESQUEMA")]
        public string Esquema { get; set; }
    }
}
