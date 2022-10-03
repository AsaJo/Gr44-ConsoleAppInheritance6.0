using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance6._0.Model.People
{
    class Person
    {
        public string Name { get; set; }

        public virtual void DoStuff()
        {
            Console.WriteLine(" Hello coders");
        }
    }

}
