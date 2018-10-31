using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class CountTestApp
    {
        public void countAlligators()
        {
            CountUtil.AllCounter(new Alligator(), 3);
        }

        public void countSheep()
        {
            Sheep s1 = new Sheep();
            CountUtil.AllCounter(s1, 2);
            Sheep s2 = s1.Clone() as Sheep;
            s2.name = "Arthur";
            s2.resetCount();
            CountUtil.AllCounter(s2, 3);
            s1.resetCount();
            CountUtil.AllCounter(s1, 1);
        }
    }
}
