using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    interface ICountable
    {
        string name { get; set; }
        void incrementCount();
        void resetCount();
        int getCount();
        string getCountString();
    }
}
