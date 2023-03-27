using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STC.Models
{
    [Table("Equipo_Participa_Competicion")]
    public class EquipoCompStats
    {
        //[Key]
        [Column("IDCOMPETICION")]
        public int IdCompeticion { get; set; }
        //[Key] 
        [Column("IDEQUIPO")]
        public int IdEquipo { get; set; }
        //[Key]
        [Column("IDTEMPORADA")]
        public int IdTemporada { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("PUNTOS")]
        public int Puntos { get; set; }
        [Column("PARTIDOSJUGADOS")]
        public int PartidosJugados { get; set; }
         [Column("PARTIDOSJUGADOSLOCAL")]
        public int PartidosJugadosLocal { get; set; }
         [Column("PARTIDOSJUGADOSVISITANTE")]
        public int PartidosJugadosVisitante { get; set; }
         [Column("VICTORIAS")]
        public int Victorias { get; set; }
          [Column("VICTORIASLOCAL")]
        public int VictoriasLocal { get; set; }
          [Column("VICTORIASVISITANTE")]
        public int VictoriasVisitante { get; set; }

         [Column("EMPATES")]
        public int Empates { get; set; }
         [Column("EMPATESLOCAL")]
        public int EmpatesLocal { get; set; }
         [Column("EMPATESVISITANTE")]
        public int EmpatesVisitante { get; set; }
        
         [Column("DERROTAS")]
        public int Derrotas { get; set; }
          [Column("DERROTASLOCAL")]
        public int DerrotasLocal { get; set; }
          [Column("DERROTASVISITANTE")]
        public int DerrotasVisitante { get; set; }

         [Column("GOLESMARCADOS")]
        public int GolesMarcados { get; set; }
         [Column("GOLESMARCADOSLOCAL")]
        public int GolesMarcadosLocal { get; set; }
         [Column("GOLESMARCADOSVISITANTE")]
        public int GolesMarcadosVisitante { get; set; }

         [Column("GOLESENCAJADOS")]
        public int GolesEncajados { get; set; }
         [Column("GOLESENCAJADOSLOCAL")]
        public int GolesEncajadosLocal { get; set; }
         [Column("GOLESENCAJADOSVISITANTE")]
        public int GolesEncajadosVisitante { get; set; }

         [Column("TARJETASAMARILLAS")]
        public int TarjetasAmarillas { get; set; }
         [Column("TARJETASAMARILLASLOCAL")]
        public int TarjetasAmarillasLocal { get; set; }
         [Column("TARJETASAMARILLASVISITANTE")]
        public int TarjetasAmarillasVisitante { get; set; }

         [Column("TARJETASROJAS")]
        public int TarjetasRojas { get; set; }
         [Column("TARJETASROJASLOCAL")]
        public int TarjetasRojasLocal { get; set; }
         [Column("TARJETASROJASVISITANTE")]
        public int TarjetasRojasVisitante { get; set; }

        [Column("GOLESFAVOR0_15")]
        public int GolesFavor0_15 { get; set; }
        [Column("GOLESFAVOR16_30")]
        public int GolesFavor16_30 { get; set; }
        [Column("GOLESFAVOR31_45")]
        public int GolesFavor31_45 { get; set; }
        [Column("GOLESFAVOR46_60")]
        public int GolesFavor46_60 { get; set; }
        [Column("GOLESFAVOR61_75")]
        public int GolesFavor61_75 { get; set; }
        [Column("GOLESFAVOR76_90")]
        public int GolesFavor76_90 { get; set; }
        [Column("GOLESFAVOR91_105")]
        public int GolesFavor91_105 { get; set; }
        [Column("GOLESFAVOR106_120")]
        public int GolesFavor106_120 { get; set; }


           [Column("GOLESCONTRA0_15")]
        public int GolesContra0_15 { get; set; }
        [Column("GOLESCONTRA16_30")]
        public int GolesContra16_30 { get; set; }
        [Column("GOLESCONTRA31_45")]
        public int GolesContra31_45 { get; set; }
        [Column("GOLESCONTRA46_60")]
        public int GolesContra46_60 { get; set; }
        [Column("GOLESCONTRA61_75")]
        public int GolesContra61_75 { get; set; }
        [Column("GOLESCONTRA76_90")]
        public int GolesContra76_90 { get; set; }
        [Column("GOLESCONTRA91_105")]
        public int GolesContra91_105 { get; set; }
        [Column("GOLESCONTRA106_120")]
        public int GolesContra106_120 { get; set; }



        [Column("TARJETASAMARILLAS0_15")]
        public int TarjetasAmarillas0_15 { get; set; }
        [Column("TARJETASAMARILLAS16_30")]
        public int TarjetasAmarillas16_30 { get; set; }
        [Column("TARJETASAMARILLAS31_45")]
        public int TarjetasAmarillas31_45 { get; set; }
        [Column("TARJETASAMARILLAS46_60")]
        public int TarjetasAmarillas46_60 { get; set; }
        [Column("TARJETASAMARILLAS61_75")]
        public int TarjetasAmarillas61_75 { get; set; }
        [Column("TARJETASAMARILLAS76_90")]
        public int TarjetasAmarillas76_90 { get; set; }
        [Column("TARJETASAMARILLAS91_105")]
        public int TarjetasAmarillas91_105 { get; set; }
        [Column("TARJETASAMARILLAS106_120")]
        public int TarjetasAmarillas106_120 { get; set; }


        [Column("TARJETASROJAS0_15")]
        public int TarjetasRojas0_15 { get; set; }
        [Column("TARJETASROJAS16_30")]
        public int TarjetasRojas16_30 { get; set; }
        [Column("TARJETASROJAS31_45")]
        public int TarjetasRojas31_45 { get; set; }
        [Column("TARJETASROJAS46_60")]
        public int TarjetasRojas46_60 { get; set; }
        [Column("TARJETASROJAS61_75")]
        public int TarjetasRojas61_75 { get; set; }
        [Column("TARJETASROJAS76_90")]
        public int TarjetasRojas76_90 { get; set; }
        [Column("TARJETASROJAS91_105")]
        public int TarjetasRojas91_105 { get; set; }
        [Column("TARJETASROJAS106_120")]
        public int TarjetasRojas106_120 { get; set; }

        [Column("POSICION")]
        public int Posicion { get; set; }
        [Column("LOGO")]
        public string logo { get; set; }
        [Column("FORM")]
        public string forma { get; set; }
    }
}
