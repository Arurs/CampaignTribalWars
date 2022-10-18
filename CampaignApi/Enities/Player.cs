namespace CampaignApi.Enities
{
    public class Player
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public int EstablishmentYear { get; set; }
        public List<Command> Commands { get; set; }
    }
}
