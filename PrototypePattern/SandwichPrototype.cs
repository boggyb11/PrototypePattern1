using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }
}
