namespace AsyncCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread t1 = new Thread(new ThreadStart(Func1));
            //Thread t2 = new Thread(new ThreadStart(Func2));
            //t1.IsBackground = true;
            //t1.Priority = ThreadPriority.BelowNormal;

            //t1.Start();
            //t2.Start();
            ////Func1();
            ////Func2();
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine("main " + i);
            //}



            //AutoResetEvent wh = new AutoResetEvent(false);
            ManualResetEvent wh = new ManualResetEvent(false);
            Thread t = new Thread(delegate ()
            {

                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine(i);
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("t1 waiting");
                        wh.WaitOne();
                    }
                }
            });
            Thread t2 = new Thread(delegate ()
            {

                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine(i);
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("t2 waiting");
                        wh.WaitOne();
                    }
                }
            });
            Thread t3 = new Thread(delegate ()
            {

                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine(i);
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("t3 waiting");
                        wh.WaitOne();
                    }
                }
            });
            Thread t4 = new Thread(delegate ()
            {

                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine(i);
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("t4 waiting");
                        wh.WaitOne();
                    }
                }
            });
            t.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            Console.ReadLine();
            wh.Set();
            wh.Reset();

            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();


            Console.ReadLine();
            wh.Set();
            wh.Reset();



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
