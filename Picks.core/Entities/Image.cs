using Picks.core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Picks.core.Entities
{
    public class Image : BaseEntity
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public virtual int CategoryId { get; set; }
    }
}
