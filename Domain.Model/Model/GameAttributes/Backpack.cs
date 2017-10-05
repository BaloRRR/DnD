using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Model
{
    public class Backpack
    {
        public int BackpackId { get; set; }

        public byte BackpackTypeId { get; set; }
        public BackpackType BackpackType { get; set; }

        public virtual IEnumerable<Item> Items { get; set; }
    }
}
