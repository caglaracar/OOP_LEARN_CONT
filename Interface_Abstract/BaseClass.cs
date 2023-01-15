using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract
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
    }
}
