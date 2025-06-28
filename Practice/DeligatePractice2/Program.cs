namespace DeligatePractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Action action = delegate ()
            {
                Console.WriteLine("Anonymous method is called");
            };
            
            action();

            Func<string> MakeDouble = () => DateTime.Now.ToLongTimeString();

            Func<int, int, int> Add = (a, b) => a + b;

            Predicate<int> IsEven = a => a % 2 == 0;

            Console.WriteLine(MakeDouble());
            Console.WriteLine(Add(10,20));
            Console.WriteLine(IsEven(7));

            //try
            //{
            //    throw new Exception();
            //}
            //finally
            //{
            //    try
            //    {

            //    }
            //    catch(Exception ex){

            //    }
            //}

            Console.WriteLine("hehe");
        }


    }
}
