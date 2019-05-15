using System;
using System.Collections.Generic;
using System.Text;

namespace Crafted.Data.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }

        string Description { get; set; }
    }
}
