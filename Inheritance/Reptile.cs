using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal 
    {
        public bool HasScales { get; set; }

        public bool ForkedTongue { get; set; }

        public bool HasNest { get; set; }

        public bool HasFangs { get; set; }
    }
}
