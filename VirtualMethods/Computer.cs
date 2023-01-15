using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Computer:Customer
    {
        public override void PrintScreen(string data)
        {
            base.PrintScreen(data);
        }
    }
}
