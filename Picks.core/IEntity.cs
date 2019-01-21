using System;
using System.Collections.Generic;
using System.Text;

namespace Picks.core
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime Created { get; set; }
    }
}
