using Picks.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Picks.infrastructure.ViewModels
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
