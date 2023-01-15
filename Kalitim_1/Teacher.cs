using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_1
{
    internal sealed class Teacher : Personel
    {
        public string Branch { get; set; }
        public int BranchLevel { get; set; }

        public Teacher()
        {
            Console.WriteLine("Teacher Instance's CTOR invoked and ran! ");
        }

    }
}
