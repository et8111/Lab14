using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Sheep: ICountable, ICloneable
    {
        private int count;
        public string name { get; set; }

        public Sheep()
        {
            name = "Nathan";
            count = 0;
        }

        public void incrementCount() => count++;
        public void resetCount() => count = 0;
        public int getCount() => count;
        public string getCountString() => count.ToString();

        public object Clone()
        {
            Sheep temp = new Sheep();
            temp.name = name;
            temp.count = count;
            return temp;
        }
    }
}
