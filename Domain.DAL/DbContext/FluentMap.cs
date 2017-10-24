using Domain.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.DAL.DbContext
{
    public partial class DndDbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dnd");

            #region Person

            modelBuilder.Entity<Person>()
                .Property(p => p.FirstName)
                .HasMaxLength(15);

            modelBuilder.Entity<Person>()
                .Property(p => p.LastName)
                .HasMaxLength(15)
                .IsRequired();

            modelBuilder.Entity<Person>()
                .Property(p => p.SecondName)
                .HasMaxLength(15);

            modelBuilder.Entity<Person>()
                .Property(p => p.Description)
                .HasMaxLength(4000);

            modelBuilder.Entity<Person>()
                .Property(p => p.Appearance)
                .HasMaxLength(1000);
            #endregion

            #region Place

            modelBuilder.Entity<Place>()
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Place>()
                .Property(p => p.Name)
                .HasMaxLength(100);

            #endregion

            #region PlaceType

            modelBuilder.Entity<PlaceType>()
                .Property(p => p.Name)
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<PlaceType>()
                .Property(p => p.Description)
                .HasMaxLength(200);

            #endregion

            #region Item

            modelBuilder.Entity<Item>()
                .Property(p => p.Name)
                .HasMaxLength(40)
                .IsRequired();

            modelBuilder.Entity<Item>()
                .Property(p => p.Description)
                .HasMaxLength(200);

            #endregion

            #region ItemType


            modelBuilder.Entity<ItemType>()
                .Property(p => p.Name)
                .HasMaxLength(15)
                .IsRequired();

            modelBuilder.Entity<ItemType>()
                .Property(p => p.Description)
                .HasMaxLength(200);

            #endregion

            #region BackpackType

            modelBuilder.Entity<BackpackType>()
                .Property(p => p.Name)
                .HasMaxLength(15);

            #endregion

            #region Hero

            modelBuilder.Entity<Hero>()
                .Property(p => p.Nickname)
                .HasMaxLength(20);

            #endregion

            #region Note

            modelBuilder.Entity<Note>()
                .Property(p => p.Name)
                .HasMaxLength(40)
                .IsRequired();

            modelBuilder.Entity<Note>()
                .Property(p => p.Text)
                .HasMaxLength(8000)
                .IsRequired();

            modelBuilder.Entity<Note>()
                .Property(p => p.Description)
                .HasMaxLength(200);

            #endregion

            #region Player

            modelBuilder.Entity<Player>()
                .Property(p => p.Nickname)
                .HasMaxLength(40)
                .IsRequired();

            modelBuilder.Entity<Player>()
                .Property(p => p.Description)
                .HasMaxLength(200);

            #endregion
        }
    }
}
