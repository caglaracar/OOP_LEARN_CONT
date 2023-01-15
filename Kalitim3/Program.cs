namespace Kalitim3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new D();
            new MyClass2();
        }
        class MyClass
        {
            public int id { get; set; }
            public MyClass(int id)
            {
                this.id = id;
            }
        }

        class MyClass2 : MyClass
        {
            public MyClass2() : base(5)
            {

            }
            public MyClass2(int c) : base(c)
            {

            }
    }
    class A
    {
        public A()
        {
            Console.WriteLine($" A sınıfının ismi: {nameof(A)}");
        }

    }

    class B : A
    {
        public B()
        {
            Console.WriteLine($" B sınıfının ismi: {nameof(B)}");

        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine($" C sınıfının ismi: {nameof(C)}");

        }

    }

    class D : C
    {
        public D()
        {
            Console.WriteLine($" D sınıfının ismi: {nameof(D)}");

        }

    }


}
}