namespace STC.Models
{
    public class ModelCompeticionPartidos
    {
        public Competicion competicion { get; set; }
        public List<Partido> partidos { get; set; }
        public int registros { get; set; }
        //public List<ModelPartidoYEventos> modelopartidos { get; set; }
    }
}
