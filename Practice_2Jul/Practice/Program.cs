namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task t1 = new Task(new Action(Fun1));
            //Task t1 = new Task(Fun1);

            //t1.Start();
            //Task t1 = Task.Run(Fun1);
            //Task t2 = Task.Factory.StartNew(Fun1);

            /*
                        Task t1 = new Task(new Action<object>(Fun2), "abc");
                        t1.Start();
                        //Task t2 = Task.Run(); // Cannot run a function with parameter
                        Task t3 = Task.Factory.StartNew(Fun2, "abc");
            */


            //Task<string> t1 = new Task<string>(new Func<string>(Fun3));
            Task<string> t1 = new Task<string>(Fun3);
            t1.Start();
            Task<string> t2 = new Task<string>(Fun4, "abc");
            t2.Start(); 
            Console.WriteLine("after t1 started");
            Task<string> t3 = Task.Factory.StartNew(Fun3);
            Task<string> t4 = Task.Factory.StartNew(Fun4,"abcd");

            Task<string> t5 = Task<string>.Run(Fun3);
            Task<string> t5a = Task.Run<string>(Fun3);
            Task<string> t5b = Task.Run(Fun3);
            //Task<string> t6 = Task.Run(Fun4); // it doesn't work with  parameter


            //if (!t1.IsCompleted)
            //{
            //    t1.Wait();
            //}
            //string returnedValue = t1.Result;
            //string returnedValue2 = t2.Result;

            //Console.WriteLine(returnedValue);
            //Console.WriteLine(returnedValue2);
            //Console.WriteLine(t3.Result);
            //Console.WriteLine(t4.Result);
            Console.WriteLine(t5.Result);
            Console.WriteLine(t5a.Result);
            Console.WriteLine(t5b.Result);
            Console.ReadLine();


        }


        public static void callBackFunc()
        {

        }

        public static string Fun(object a)
        {
            return a.ToString().ToUpper();
        }

        public static void Fun1()
        {
            //Console.WriteLine(a.ToUpper());
            Console.WriteLine("here");
        }

        public static void Fun2(object a)
        {
            Console.WriteLine( a.ToString().ToUpper());

        }
        public static string Fun3()
        {
            //Console.WriteLine(a.ToUpper());
            //Console.WriteLine("here");
            return "Fun3";
        }

        public static string Fun4(object a)
        {
            //Console.WriteLine( a.ToString().ToUpper());
            return a.ToString().ToUpper();

        }
    }
}
