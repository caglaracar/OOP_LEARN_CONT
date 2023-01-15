using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class BaseClass
    {
        public DateTime RegisterTime { get; set; }
        public DateTime UpdatedTime { get; set; }

        public BaseClass(DateTime registerTime, DateTime updatedTime)
        {
            RegisterTime = registerTime;
            UpdatedTime = updatedTime;
        }

        public BaseClass()
        {

        }

        public void Test()
        {
            Console.WriteLine("BaseClass inside Test Method");
        }

        public abstract void TestAbstract(); // abstract metotların metot body'si yoktur
     
    }
}
