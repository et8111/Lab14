using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Alligator a = new Alligator();
            CountTestApp test = new CountTestApp();
            test.countAlligators();
            test.countSheep();
        }
    }
}
