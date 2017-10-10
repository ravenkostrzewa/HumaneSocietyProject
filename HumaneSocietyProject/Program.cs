using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Program 
    {
        static void Main(string[] args)
        {
            HumaneSociety humaneSociety = new HumaneSociety();
            Employee employee = new Employee();
            Adopter adopter = new Adopter();
            humaneSociety.DetermineUser(adopter);
        }
    }
}
