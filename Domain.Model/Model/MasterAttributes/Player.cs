using System.Collections.Generic;

namespace Domain.Model.Model
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Nickname { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Hero> Heroes { get; set; }
    }
}
