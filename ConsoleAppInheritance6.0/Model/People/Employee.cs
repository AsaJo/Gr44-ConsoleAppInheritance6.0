using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance6._0.Model.People
{
    class Employee :Person
    {
        public string Department { get; set; }

        public override void DoStuff()
        {
            Console.WriteLine("Happy Hacking Coders");
        }
    }


}
