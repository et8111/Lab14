using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Alligator : ICountable
    {
        public string name { get; set; }
        private int count;

        public Alligator()
        {
            name = "Alligator";
            count = 0;
        }

        public void incrementCount() => count++;
        public void resetCount() => count = 0;
        public int getCount() => count;
        public string getCountString() => count.ToString();

        public void formattedCount()
        {
            Console.WriteLine("I Count " + getCountString() + " Alligators.");
        }
    }
}
