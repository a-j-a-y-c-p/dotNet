namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            
            Myclass o = new Myclass();

            //o.func3();

            (o as InterefaceClasss).func3();

            (o as InterefaceClasss).func4();



        }

  
    }


    public interface InterefaceClasss
    {
        void func1();

        void func2();

        void func3() { Console.WriteLine("interface func3"); }

        void func4() { Console.WriteLine("func4"); }
    }

    public class Myclass : InterefaceClasss
    {
        public void func1()
        {
            Console.WriteLine("func1");
        }

        public void func2()
        {
            Console.WriteLine("func2");
        }

        //void InterefaceClasss.func3()
        //{
        //    Console.WriteLine("func3");
        //}
    }
}

