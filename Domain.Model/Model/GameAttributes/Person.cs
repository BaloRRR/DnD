using System;

namespace Domain.Model.Model
{
    /// <summary>
    /// Describe any person in DND world
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }

        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int? Age { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? DeathDate { get; set; }

        public string Appearance { get; set; }
        public string Description { get; set; }

        public int? BackpackId { get; set; }
        public virtual Backpack Backpack { get; set; }
    }
}
