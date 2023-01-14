namespace StaticNedir_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static : nesne örneği alınmadan ulaşabildiğimiz alanlardır !!! metot , field , sınıf
            // Tip M1= new Tip();
            // Tip.id=123;

            Student student1 = new Student();
            student1.Test1();
            Student.Test2();
        }
    }
}