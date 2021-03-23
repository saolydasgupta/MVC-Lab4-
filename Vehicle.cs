using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Models
{
    public enum EngineType { Petrol, Diesel, Hybqrid, Electric,
        Hybrid
    }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int EngineSize { get; set; }
        public EngineType Engine { get; set; }

    }
}
