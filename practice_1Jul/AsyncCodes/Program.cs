namespace AsyncCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(new ThreadStart(Func2));
            t1.IsBackground = true;
            t1.Priority = ThreadPriority.BelowNormal;`x

            t1.Start();
            t2.Start();
            //Func1();
            //Func2();
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("main " + i);
            }



            AutoResetEvent wh = new AutoResetEvent(false);
            {
                for(int i=0; i< 200; i++)
                {
                    if(i%50 == 0)
                    {
                        Console.WriteLine("waiting");
                        wh.WaitOne();
                    }
                }
            })
            

        }

        static void Func1()
        {
            for(int i = 0; i < 200; i++)
            {
                Console.WriteLine("first " + i);
            }
        }
        static void Func2()
        {
            for(int i = 0; i < 200; i++)
            {
                Console.WriteLine("second " + i);
            }
        }
    }
}
