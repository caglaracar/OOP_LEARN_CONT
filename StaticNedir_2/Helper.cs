using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir_2
{
    internal static class Helper
    {
        public static void SendEmail(string aliciEmailAdres, string konu, string content)
        {
            Console.WriteLine("Mail gönderim işlemi başarılı");
        }

        //public void test()
        //{
        //    normal (standart) metotlar kullanılamaz
        //}

        static Helper()
        {
            Console.WriteLine("Helper static class cagrıldı");
        }

        //public Helper()
        //{
                //Her nesne örneği alındıgında yapıcı metot calısır fakat static classlardaki static ctor 1 kez calısır
        //}
    }
}
