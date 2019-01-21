using System;
using System.Collections.Generic;
using System.Text;

namespace Picks.core.Base
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
