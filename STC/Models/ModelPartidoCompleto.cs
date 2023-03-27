namespace STC.Models
{
    public class ModelPartidoCompleto
    {
        public Partido partido { get; set; }
        public List<Evento> eventos { get; set; }
        public List<ModelLineUp> LineUps { get; set; }
        public ModelStatsPartido EstadisticasPartido { get; set; }
    }
}
