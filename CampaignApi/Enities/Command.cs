namespace CampaignApi.Enities
{
    public class Command
    {
        public int Id { get; set; }
        public DateTime MinimalTime { get; set; }
        public int PlayerID { get; set; }
        public virtual Player Player { get; set; }
    }
}
