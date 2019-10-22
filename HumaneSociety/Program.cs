using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            UserEmployee userEmployee = new UserEmployee();
            userEmployee.AddAnimal();
            //Query.AddAnimal(animal);
            //PointOfEntry.Run();
        }
    }
}
