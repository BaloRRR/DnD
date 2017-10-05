using Domain.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.DAL.DbContext
{
    public class DndDbContext: Microsoft.EntityFrameworkCore.DbContext, IDndDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Hero> Heroes { get; set; }
        public virtual DbSet<Backpack> Backpacks { get; set; }
        public virtual DbSet<BackpackType> BackpackTypes { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<PlaceType> PlaceTypes { get; set; }
        public virtual DbSet<Place> Places { get; set; }
    }
}
