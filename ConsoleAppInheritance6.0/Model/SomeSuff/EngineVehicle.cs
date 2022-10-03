using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance6._0.Model.SomeSuff
{
     abstract class EngineVehicle
    {
        public int? FuelLeft { get; set; }
        public abstract void Drive();
    }
}
