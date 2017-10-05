using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Model
{
    public class Hero
    {
        public int HeroId { get; set; }

        public string Nickname { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
