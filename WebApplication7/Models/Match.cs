namespace WebApplication7.Models
{
    public class Match
    {
        public int Id { get; set; }

        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime Date { get; set; }
    }
}
