using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim2
{
    internal class VirtualDB
    {
       private static ArrayList VirtualDb;

        static VirtualDB()
        {
            VirtualDb = new ArrayList();
        }
        public static void AddNewProduct(BaseClass data)
        {
            if(data!=null && !string.IsNullOrEmpty(data.Barcode))
            {
                VirtualDb.Add(data);
            }
        }

    }
}
