namespace Domain.Model.Model
{
    public class Place
    {
        public short PlaceId { get; set; }

        public string Name { get; set; }

        public byte PlaceTypeId { get; set; }
        public virtual PlaceType PlaceType { get; set; }

        public int? ParentId { get; set; }
        public virtual Place Parent{ get; set; }
    }
}
