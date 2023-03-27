using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("V_EQUIPOS_COMP")]
    public class VistaEquiposCompeticion
    {
        [Key]
        [Column("IDCOMPTEMP")]
        public int IdComptemp { get; set; }
        [Key]
        [Column("IDEQUIPO")]
        public int IdEquipo { get; set; }
        [Column("PUNTOS")]
        public int Puntos { get; set; }
        [Column("PARTIDOSJUGADOS")]
        public int PartidosJugados { get; set; }
        [Column("VICTORIAS")]
        public int Victorias { get; set; }
        [Column("EMPATES")]
        public int Empates { get; set; }
        [Column("DERROTAS")]
        public int Derrotas { get; set; }
        [Column("GOLESMARCADOS")]
        public int GolesMarcados { get; set; }
        [Column("GOLESENCAJADOS")]
        public int GolesEncajados { get; set; }
        [Column("TARJETASAMARILLAS")]
        public int TarjetasAmarillas { get; set; }
        [Column("TARJETASROJAS")]
        public int TarjetasRojas { get; set; }
        [Column("NOMBREEQUIPO")]
        public string Nombre { get; set; }
    }
}
