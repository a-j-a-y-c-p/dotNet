namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            myclass c = new myclass();
            Console.WriteLine(c.A);
            Console.WriteLine(c.B);
            Console.WriteLine(c.C);
            
        }
    }


    public class myclass
    {
        public int A { set; get; }
        public int B { set; get; }

        public int C { set; get; }
        public myclass(int a = 0, int b = 0, int c = 0) { 
            this.A = a; this.B = b; this.C = c;
            
        }
    }
}
