using System.Security.Cryptography.X509Certificates;

namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Console = 0;

            //string System = "hello";

            //Console.WriteLine(Console);

            //Console.WriteLine(System);

            //System.Console.WriteLine(Console);

            impl t = new impl();

            t.Func1();

            t.Func2();

            t.Func3();

            t.Func4();


        }
}

    public interface I1
    {


        public void Func1();

        public void Func2()
        {
            Console.WriteLine("interface function");
        }

    }

    public interface I2
    {
         void Func3();

         void Func4();
    }


    public class impl : I1, I2
    {
        //private int prop1 = 10;
        //public int Prop1 { get
        //    {
        //        return prop1;
        //    }
        //}
        public void Func1()
        {
            Console.WriteLine("impl function1");
        }

        public void Func3()
        {
            Console.WriteLine("impl function3");
        }

        public void Func4()
        {
            Console.WriteLine("impl function4");
        }

        public void Func2()
        {
            Console.WriteLine("impl function2");

        }
    }
}
