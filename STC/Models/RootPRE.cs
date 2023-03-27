//namespace STC.Models
//{
//    public class Fixture
//    {
//        public int Id { get; set; }
//        public object Referee { get; set; }
//        public string Timezone { get; set; }
//        public DateTime Date { get; set; }
//        public int Timestamp { get; set; }
//        public Dictionary<string, object> Periods { get; set; }
//        public Venue Venue { get; set; }
//        public Status Status { get; set; }
//    }

//    public class Venue
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string City { get; set; }
//    }

//    public class Status
//    {
//        public string Long { get; set; }
//        public string Short { get; set; }
//        public object Elapsed { get; set; }
//    }

//    public class League
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Country { get; set; }
//        public string Logo { get; set; }
//        public string Flag { get; set; }
//        public int Season { get; set; }
//        public string Round { get; set; }
//    }

//    public class Teams
//    {
//        public HomeTeam Home { get; set; }
//        public AwayTeam Away { get; set; }
//    }

//    public class HomeTeam
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Logo { get; set; }
//        public object Winner { get; set; }
//    }

//    public class AwayTeam
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Logo { get; set; }
//        public object Winner { get; set; }
//    }

//    public class Goals
//    {
//        public int? Home { get; set; }
//        public int? Away { get; set; }
//    }

//    public class Score
//    {
//        public Goals Halftime { get; set; }
//        public Goals Fulltime { get; set; }
//        public Goals Extratime { get; set; }
//        public Goals Penalty { get; set; }
//    }

//    public class Root
//    {
//        public Fixture Fixture { get; set; }
//        public League League { get; set; }
//        public Teams Teams { get; set; }
//        public Goals Goals { get; set; }
//        public Score Score { get; set; }
//    }
//    public class Roots
//    {
//        public Root[] roots { get; set; }
//    }
//}
