namespace Domain.Model.Model
{
    public class Item
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal BotCost { get; set; }

        public decimal? TopCost { get; set; }
    }
}
