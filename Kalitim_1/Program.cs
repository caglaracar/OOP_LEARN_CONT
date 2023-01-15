namespace Kalitim_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseType B1 = new BaseType();
            B1.BaseType1();

            Teacher T1 = new Teacher();
            T1.BaseType1();
            Console.WriteLine("Teacher nesnesi örneklendi");

            //object O1 = T1; // Boxing
            //T1 = (Teacher)O1; // UnBoxing

            // bizim en temel nesnemiz nedir : bu örnek için :::::   BaseType

            BaseType B2; // Ana tipimiz
            // B2  Teacher , Student , Personel nesnesini alabilir ...



            B2 = T1; // Teacher nesnesini BaseType nesnesine atadık
            T1 = (Teacher)B2;



            Personel P1 = new Personel();
            B2 = P1;
            P1 = (Personel)B2;



            Student S1 = new Student();
            B2 = S1;
            S1 = (Student)B2;






        }
    }
}