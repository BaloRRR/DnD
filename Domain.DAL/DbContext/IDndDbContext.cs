using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.DAL.DbContext
{
    public interface IDndDbContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Note> Notes { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Hero> Heroes { get; set; }
        DbSet<Backpack> Backpacks { get; set; }
        DbSet<BackpackType> BackpackTypes { get; set; }
        DbSet<ItemType> ItemTypes { get; set; }
        DbSet<PlaceType> PlaceTypes { get; set; }
        DbSet<Place> Places { get; set; }
    }
}
