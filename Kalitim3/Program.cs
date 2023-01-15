namespace Kalitim3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new D();
        }
        class A
        {
            public A()
            {
                Console.WriteLine($" A sınıfının ismi: {nameof(A)}");
            }

        }

        class B:A
        {
            public B()
            {
                Console.WriteLine($" B sınıfının ismi: {nameof(B)}");

            }
        }

        class C:B
        {
            public C()
            {
                Console.WriteLine($" C sınıfının ismi: {nameof(C)}");

            }

        }

        class D:C
        {
            public D()
            {
                Console.WriteLine($" D sınıfının ismi: {nameof(D)}");

            }

        }


    }
}