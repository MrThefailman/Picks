using Picks.core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Picks.core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
