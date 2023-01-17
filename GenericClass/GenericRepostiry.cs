using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class GenericRepostiry<T> where T:class
    {
        public GenericRepostiry()
        {
            // context : EF DBFirst
        }

        public virtual IEnumerable<T> Getir()
        {
            // Gelen T tipine database üzerinden sorgulamak ve elde etmiş oldugum kayıtları generic koleyksiyon olarak bir üst katmana dönmek...
            return null;
        }

        public virtual void newAddRegist(T data)
        {
            // bize gelen T tipi içerisindeki T tipinin işaret etmiş oldugu tabloya ekliyoruz
        }
    }
}
