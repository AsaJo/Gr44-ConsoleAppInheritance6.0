using ConsoleAppInheritance6._0.Model.People;
using ConsoleAppInheritance6._0.Model.SomeSuff;

namespace ConsoleAppInheritance6._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.DoStuff(); 
            //Administrator administrator = new Administrator();

            //Person person = new Employee();
            Tank tank = new Tank();
            tank.FuelLeft = 5;
            tank.Drive();
            Console.WriteLine(tank.FuelLeft);




        }
    }
}