using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Domain.Model.Model
{
    public class ItemType
    {
        public byte ItemTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte? ParentId { get; set; }
        public virtual ItemType Parent { get; set; }
    }
}
