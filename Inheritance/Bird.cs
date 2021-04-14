using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool Migrates { get; set; }
        public string FeatherColors { get; set; }

        public bool IsNocturnal { get; set; }
        public int RunSpeed { get; set; }
    }
}
