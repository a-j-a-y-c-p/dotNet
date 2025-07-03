namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BaseClass o = new BaseClass();
            o.Func();
            o.Func2();
            o.Func3();
            Console.WriteLine();

            o = new DerivedClass();
            o.Func();
            o.Func2();
            o.Func3();

            Console.WriteLine();

            DerivedClass o1 = new DerivedClass();
            o1.Func();
            o1.Func2();
            o1.Func3();
            Console.WriteLine();

            //o1 = (DerivedClass) new BaseClass();
            //o1.Func();
            //o1.Func2();
            //o1.Func3();

        }
    }


    public class BaseClass
    {
        public void Func()
        {
            Console.WriteLine("base class function 1");
        }

        public virtual void Func2()
        {
            Console.WriteLine("base class function 2");
        }

        public virtual void Func3()
        {
            Console.WriteLine("base class function 3");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void Func()
        {
            Console.WriteLine("derived class function 2");
        }

        public new void Func2()
        {
            Console.WriteLine("derived class function 2");
        }


        public override void Func3()
        {
            Console.WriteLine("derived class function 3");

        }
    }
}
