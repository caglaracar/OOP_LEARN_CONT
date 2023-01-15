using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class BaseClass
    {
        public virtual void PrintScreen(string data)
        {
            Console.WriteLine(data);
        }
    }
}
