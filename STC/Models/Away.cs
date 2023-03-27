using Microsoft.EntityFrameworkCore;
using STC.Models;

namespace STC.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Away
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }//v2
        public string logo { get; set; }
        public bool? winner { get; set; }
    }
    [Keyless]
    public class Extratime
    {
        public int? home { get; set; }
        public int? away { get; set; }
    }

    public class Fixture
    {
        public int id { get; set; }
        public string referee { get; set; }
        public string timezone { get; set; }
        public DateTime date { get; set; }
        public int timestamp { get; set; }
        public Periods periods { get; set; }
        public Venue venue { get; set; }
        public Status status { get; set; }
    }

    public class Fulltime
    {
        public int? home { get; set; }
        public int? away { get; set; }
    }

    public class Goals
    {
        public int? home { get; set; }
        public int? away { get; set; }
    }

    public class Halftime
    {
        public int? home { get; set; }
        public int? away { get; set; }
    }

    public class Home
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }//v2
        public string logo { get; set; }
        public bool? winner { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string logo { get; set; }
        public string flag { get; set; }
        public int season { get; set; }
        public string round { get; set; }
        public string type { get; set; }//v2
    }

    public class Paging
    {
        public int current { get; set; }
        public int total { get; set; }
    }

    public class Parameters
    {
        public string date { get; set; }
        public string league { get; set; }//V53453
        public string season { get; set; }//V53453
    }

    public class Penalty
    {
        public int? home { get; set; }
        public int? away { get; set; }
    }

    public class Periods
    {
        public int? first { get; set; }
        public int? second { get; set; }
    }

    public class Response
    {
        public Fixture fixture { get; set; }
        public League league { get; set; }
        public Teams teams { get; set; }
        public Goals goals { get; set; }
        public Score score { get; set; }
    }

    public class Root
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public List<object> errors { get; set; }
        public int results { get; set; }
        public Paging paging { get; set; }
        public List<Response> response { get; set; }
    }

    public class Score
    {
        public Halftime halftime { get; set; }
        public Fulltime fulltime { get; set; }
        public Extratime extratime { get; set; }
        public Penalty penalty { get; set; }
    }

    public class Status
    {
        public string @long { get; set; }
        public string @short { get; set; }
        public int? elapsed { get; set; }
    }

    public class Teams
    {
        public Home home { get; set; }
        public Away away { get; set; }
       
    }

    public class Venue
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string county { get; set; } //v2
        public int capacity { get; set; }//v2
    }

    public class Season
    {
        public int year { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public bool current { get; set; }
        public Coverage coverage { get; set; }
    }
    public class Country
    {
        public string name { get; set; }
        public object code { get; set; }
        public object flag { get; set; }
    }

    public class Coverage
    {
        public Fixtures fixtures { get; set; }
        public bool standings { get; set; }
        public bool players { get; set; }
        public bool top_scorers { get; set; }
        public bool top_assists { get; set; }
        public bool top_cards { get; set; }
        public bool injuries { get; set; }
        public bool predictions { get; set; }
        public bool odds { get; set; }
    }
    public class Fixtures
    {
        public bool events { get; set; }
        public bool lineups { get; set; }
        public bool statistics_fixtures { get; set; }
        public bool statistics_players { get; set; }
    }
    public class RootLeague
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public List<object> errors { get; set; }
        public int results { get; set; }
        public Paging paging { get; set; }
        public List<ResponseLeague> response { get; set; }
    }
    public class ResponseLeague
    {
        public League league { get; set; }
        public Country country { get; set; }
        public List<Season> seasons { get; set; }
    }
}
        public class TeamResponse
        {
            public Team team { get; set; }
            public Venue venue { get; set; }
        }
        public class TeamRespuesta
        {
            public Equipo equipo { get; set; }
            public VenueB venue { get; set; }
        }

public class Team
        {
            public int id { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string country { get; set; }
            //public int founded { get; set; }
            public bool national { get; set; }
            public string logo { get; set; }
        }

        public class RootTeam
        {
            public string get { get; set; }
            public Parameters parameters { get; set; }
            public List<object> errors { get; set; }
            public int results { get; set; }
            public Paging paging { get; set; }
            public List<TeamResponse> response { get; set; }
        }

            public class RootTeamStats
            {
                public string get { get; set; }
                public Dictionary<string, string> parameters { get; set; }
                public List<object> errors { get; set; }
                public int results { get; set; }
                public Paging paging { get; set; }
                public ResponseTeamStats response { get; set; }
                public Biggest biggest { get; set; }
                public TotalGoals clean_sheet { get; set; }
                public TotalGoals failed_to_score { get; set; }
                public Penalty penalty { get; set; }
                public List<Lineup> lineups{ get; set; }
              
}

            public class ResponseTeamStats
            {
                public League league { get; set; }
                public Team team { get; set; }
                public string form { get; set; }
                public Fixtures fixtures { get; set; }
                public Goals goals { get; set; }
                public Cards cards { get; set; }
}

            public class Lineup
            {
                public string formation { get; set; }
                public int played { get; set; }
            }

            public class Fixtures
            {
                public TotalGoals played { get; set; }
                public TotalGoals wins { get; set; }
                public TotalGoals draws { get; set; }
                public TotalGoals loses { get; set; }
            }

            public class Biggest
            {
                public Streak streak { get; set; }
                public Goals goals { get; set; }
                public HomeAwayResult wins { get; set; }
                public HomeAwayResult loses { get; set; }
            }

            public class Streak
            {
                public int wins { get; set; }
                public int draws { get; set; }
                public int loses { get; set; }
            }

            public class HomeAwayResult
            {
                public string home { get; set; }
                public string away { get; set; }
            }

            public class Cards
            {
                public Dictionary<string, MinuteCards> yellow { get; set; }
                public Dictionary<string, MinuteCards> red { get; set; }
            }

            public class MinuteCards
            {
                public int? total { get; set; }
                public string percentage { get; set; }
            }

            public class Goals
            {   
            public Total @for { get; set; }
            public Total against { get; set; }

            }

            public class Total
            {
                public TotalGoals total { get; set; }
                public AverageGoals average { get; set; }
                public Dictionary<string, MinuteGoals> minute { get; set; }
            }

            public class TotalGoals
            {
                public int home { get; set; }
                public int away { get; set; }
                public int total { get; set; }
            }

            public class AverageGoals
            {
                public string home { get; set; }
                public string away { get; set; }
                public string total { get; set; }
            }

            public class MinuteGoals
            {
                public int? total { get; set; }
                public string percentage { get; set; }
            }


            public class RootStandings
            {
                public string get { get; set; }
                public Parameters parameters { get; set; }
                public List<object> errors { get; set; }
                public int results { get; set; }
                public Paging paging { get; set; }
                public List<ResponseStandings> response { get; set; }
            }      

            public class ResponseStandings
            {
                public LigaStanding league { get; set; }
            }

            public class Standing
            {
                public int rank { get; set; }
                public Team team { get; set; }
                public int points { get; set; }
                public int goalsDiff { get; set; }
                public string group { get; set; }
                public string form { get; set; }
                public string status { get; set; }
                public string description { get; set; }
                public Stat all { get; set; }
                public Stat home { get; set; }
                public Stat away { get; set; }
                public string update { get; set; }
            }
                public class LigaStanding
                {
                    public int id { get; set; }
                    public string name { get; set; }
                    public string country { get; set; }
                    public string logo { get; set; }
                    public string flag { get; set; }
                    public int season { get; set; }
                    public List<List<Standing>> standings { get; set; }
                }
                public class Stat
                {
                    public int played { get; set; }
                    public int win { get; set; }
                    public int draw { get; set; }
                    public int lose { get; set; }
                    public GoalsStandings goals { get; set; }
                }

                    public class GoalsStandings
{
                        public int @for { get; set; }
                        public int against { get; set; }
                    }

public class Time
{
    public int Elapsed { get; set; }
    public int? Extra { get; set; }
}

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? number { get; set; } //PARA LINEUPS
    public string pos { get; set; } //PARA LINEUPS
    public string grid { get; set; } //PARA LINEUPS
}

public class Assist
{
    public int? Id { get; set; }
    public string Name { get; set; }
}

public class ResponseEvent
{
    public Time Time { get; set; }
    public Team Team { get; set; }
    public Player Player { get; set; }
    public Assist Assist { get; set; }
    public string Type { get; set; }
    public string Detail { get; set; }
    public object Comments { get; set; }
}

public class RootEvent
{
    public string Get { get; set; }
    public ParametersEvent Parameters { get; set; }
    public List<object> Errors { get; set; }
    public int Results { get; set; }
    public Paging Paging { get; set; }
    public List<ResponseEvent> Response { get; set; }
}

public class ParametersEvent
{
    public int Fixture { get; set; }
}

public class RootLineUp
{
    public string get { get; set; }
    public ParametersEvent parameters { get; set; }
    public List<object> errors { get; set; }
    public int results { get; set; }
    public Paging paging { get; set; }
    public List<ResponseLineUp> response { get; set; }
}

public class ResponseLineUp
{
    public Team team { get; set; }
    //public Coach coach { get; set; }
    public string formation { get; set; }
    public List<StartXI> startXI { get; set; }
    public List<Substitutes> substitutes { get; set; }
}

public class StartXI
{
    public Player player { get; set; }
}
public class Substitutes
{
    public Player player { get; set; }
}

public class RootMatchStats
{
    public string get { get; set; }
    public ParametersEvent Parameters { get; set; }
    public List<object> errors { get; set; }
    public int results { get; set; }
    public Paging paging { get; set; }
    public List<ResponseMatchStats> response { get; set; }
}


public class ResponseMatchStats
{
    public Team team { get; set; }
    public List<Statistic> statistics { get; set; }
}
public class Statistic
{
    public string type { get; set; }
    public object value { get; set; }
}