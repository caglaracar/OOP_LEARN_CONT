using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_s
{
    internal class VirtualDB
    {
        ArrayList virtualDb = new ArrayList();
        public CustomerReturnValue NewRegistCustomer (Customer C)
        {
            virtualDb.Add(C);
            return CustomerReturnValue.registrationSuccessful;
        }
    }
}
