namespace STC.Models
{
    public class ModelLineUp
    {
        public LineupB Lineup {get;set;}
        public List<LineupPlayer> Titulares { get;set;}
        public List<LineupPlayer> Suplentes { get;set;}
    }
}
