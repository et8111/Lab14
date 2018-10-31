using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class CountUtil
    {
        public static void AllCounter(ICountable c, int MaxCount)
        {
            string temp = c.GetType().ToString();
            temp = temp.Substring(temp.IndexOf('.')+1);
            for (int i = 0; i < MaxCount; i++)
            {
                c.incrementCount();
                Console.WriteLine(c.getCount()+" " + c.name);
            }
            Console.WriteLine();
        }
    }
}
