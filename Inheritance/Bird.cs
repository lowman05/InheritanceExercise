using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool HasFeathers { get; set; }
        public bool HasWings { get; set; }

        public bool HasNest { get; set; }

        public bool LaysEggs { get; set; }

        public bool HasCage { get; set; }
    }
}
