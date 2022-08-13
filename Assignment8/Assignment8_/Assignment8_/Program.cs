using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class ClassExample1
    {
        public string FullName;
        public string GetMyName(string first, string last)
        {
            this.FullName = first + " " + last;
            return this.FullName;
        }

    }
}
