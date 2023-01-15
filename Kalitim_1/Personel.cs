using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_1
{
    internal class Personel:BaseType
    {
        public DateTime WorkStartDate { get; set; }
        public DateTime IsDoneTime { get; set; }
        public int OffDayCount { get; set; }

    }
}
