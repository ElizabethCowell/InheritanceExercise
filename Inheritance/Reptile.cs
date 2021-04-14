using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool RegenerateLimbs { get; set; }
        public int NumberOfLimbs { get; set; }

        public string Diet { get; set; }

        public bool HaveHardShell { get; set; }
    }
}
