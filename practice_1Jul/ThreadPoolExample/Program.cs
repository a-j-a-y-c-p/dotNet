namespace ThreadPoolExample
{
    internal class Program
    {
        static int i = 0;
        static object lockobject = new object();
        static Lock lockObj = new Lock();
        static void Main(string[] args)
        {
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Func1!),"value");
            Thread t1 = new Thread(Func1);
            t1.Start();
            Thread t2 = new Thread(Func2);
            t2.Start();
            
            Console.ReadLine();
        }

        static void Func1(object o)
        {
            //lock (lockobject)
            using(lockObj.EnterScope() )
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("first " + i);
                }
            }
        }
        static void Func2(object o)
        {
            //Monitor.Enter(lockobject);
            //if (lockObj.TryEnter())
            using (lockObj.EnterScope())
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("second " + i);
                }
            }
            //Monitor.Exit(lockobject);
        }
    }

    }
