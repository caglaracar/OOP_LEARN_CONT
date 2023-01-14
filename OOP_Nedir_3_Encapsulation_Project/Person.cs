using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nedir_3_Encapsulation_Project
{
    internal class Person
    {
        private string _tcKimlikNumarasi;
        public string TcKimlikNumarasi
        {
            get
            {
                if (_tcKimlikNumarasi.Length == 11)
                {
                    return _tcKimlikNumarasi.Substring(0, 3) + "*********";

                }
                else
                {
                    return "eksik ya da fazla değer girdin kanka";
                }
            }
            set
            {
                if (value.Length == 11)
                {
                    _tcKimlikNumarasi = value;
                }
                else
                {

                    _tcKimlikNumarasi = value;

                }
            }
        }
    }
}
