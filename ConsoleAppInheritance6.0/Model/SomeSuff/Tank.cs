using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance6._0.Model.SomeSuff
{
     class Tank:EngineVehicle
    {
        public override void Drive() 
        {
            this.FuelLeft -= 10;
        }
    }
}
