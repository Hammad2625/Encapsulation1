using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeterSeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();
            name.Firstname = "Hammad";
            name.Lastname = "Khalid";
            name.Age = 23;
            Console.WriteLine(name.Naam());
        }
    }
}
