namespace Practice
{

    public delegate int DelAdd(int a, int b);

    internal class Program
    {
        //public delegate int DelAdd(int a, int b);   - we have to refer with classname to call  it


        static void Main(string[] args)
        {

            //DelAdd objDel = null;
            DelAdd objDel = Add;
            objDel += Add2;
            Class1 class1 = new Class1();

            //objDel = Class1.Fun;
            //Console.WriteLine(objDel(2, 3));
            objDel -= Add;
            objDel -= Add2;
            Console.WriteLine(objDel);




            //Console.WriteLine("Hello, World!");
            //int[] arr  = new int[] { 1, 2, 3 ,4,5,6};
            //Console.WriteLine(arr[^3]);
            //Console.WriteLine(arr[3..]);
            //Console.WriteLine(arr[..3]);
            //Console.WriteLine(arr[^3..]);
            //Console.WriteLine(arr[2..5]);
        }


        static int Add(int a, int b)
        {
            Console.WriteLine("add1 called");
            return a + b;
        }
        static int Add2(int a, int b)
        {
            Console.WriteLine("add2 called");
            return a + b;
        }
    }

    public class Class1
    {
        public static int Fun(int a, int b)
        {
            return a + b;
        }
    }

}
