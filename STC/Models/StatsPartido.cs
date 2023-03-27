using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("STATSPARTIDO")]
    public class StatsPartido
    {
        [Column("IDPARTIDO")]
        public int IdPartido { get; set; }
        [Column("TIPO")]
        public string Tipo { get; set; }
        [Column("IDEQUIPO")]
        public int IdEquipo { get; set; }
        [Column("VALOR")]
        public string Valor { get; set; }
    }
}
