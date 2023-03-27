using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("PARTIDO")]
    public class Partido
    {
        
        [Column("IDPARTIDO")]
        public int IdPartido { get; set; }
        [Column("IDCOMPETICION")]
        public int IdCompeticion { get; set; }
        [Column("IDTEMPORADA")]
        public int IdTemporada { get; set; }

        [Column("ARBITRO")]
        public string Arbitro { get; set; }
        [Column("STARTDATE")]
        public DateTime FechaInicio { get; set; }
        [Column("TIMEZONE")]
        public string Timezone { get;set; }
        [Column("IDLOCAL")]
        public int IdLocal { get; set; }
        [Column("IDVISITANTE")]
        public int IdVisitante { get; set; }
        [Column("NOMBRELOCAL")]
        public string NombreLocal { get; set; }
        [Column("NOMBREVISITANTE")]
        public string NombreVisitante { get; set; }
        [Column("IDVENUE")]
        public int IdVenue { get; set; }
        [Column("GOLESLOCALHF")]
        public int GolesLocalHf { get; set; }
         [Column("GOLESVISITANTEHF")]
        public int GolesVisitanteHf { get; set; }
        [Column("GOLESLOCALFT")]
        public int GolesLocalFt { get; set; }
        [Column("GOLESVISITANTEFT")]
        public int GolesVisitanteFt { get; set; }
        [Column("GOLESLOCALET")]
        public int GolesLocalEt { get; set; }
        [Column("GOLESVISITANTEET")]
        public int GolesVisitanteEt { get; set; }
        [Column("GOLESLOCALPENALTY")]
        public int GolesLocalPenalty { get; set; }
        [Column("GOLESVISITANTEPENALTY")]
        public int GolesVisitantePenalty { get; set; }
        [Column("RONDA")]
        public string Ronda { get; set; }
        [Column("ESTADO")]
        public string Estado { get; set; }
        [Column("ESTADOFINAL")]
        public string EstadoFinal { get; set; }
        [Column("ELAPSED")]
        public int Elapsed { get; set; }
        [Column("LOGOLOCAL")]
        public string LogoLocal { get; set; }
        [Column("LOGOVISITANTE")]
        public string LogoVisitante{ get; set; }
        [Column("PAIS")]
        public string Pais { get; set; }
        [Column("PAISIMAGEN")]
        public string PaisImagen { get; set; }
        [Column("NOMBRECOMPETICION")]
        public string NombreCompeticion { get; set; }
        [Column("NOMBREVENUE")]
        public string NombreVenue { get; set; }
    }
}
