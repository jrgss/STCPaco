using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace STC.Models
{
    [Table("VENUE")]
    public class VenueB
    {
        [Key]
        [Column("IDVENUE")]
        public int IdVenue { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("CIUDAD")]
        public string Ciudad { get; set; }
        [Column("CAPACIDAD")]
        public int Capacidad { get; set; }
        [Column("PAIS")]
        public string Pais { get; set; }
    }
}
