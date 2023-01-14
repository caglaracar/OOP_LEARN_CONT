namespace StaticNedir_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            p1.Name = "Gilfoyle";
            p1.Surname = "Bertram";
            p1.EmailAdress = "Gilfoyle.Bertram";
            p1.Cinsiyet = 717770001;
            Console.WriteLine(p1.EmailAdress);

            Helper.SendEmail(p1.EmailAdress, "Yeni personel", p1.Name + " " + p1.Surname);
            Helper.SendEmail(p1.EmailAdress, "Yeni personel", p1.Name + " " + p1.Surname);
            // static ctor   1 kez çağrıldı



            //Helper helper = new Helper(); // nesne örneği alınamaz
        }
    }
}