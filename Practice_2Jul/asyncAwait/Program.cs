using System.Diagnostics;
using System.Threading.Tasks;

namespace asyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string msg = await DoWorkAsync();
            //Console.WriteLine(msg);
            //Console.WriteLine("after");


            //CancellationTokenSource cts = new CancellationTokenSource();
            //CancellationToken token = cts.Token;

            //Task t = new Task(delegate ()
            //{
            //    for (global::System.Int32 i = 0; i < int.MaxValue; i++)
            //    {
            //        Console.WriteLine(i);
            //        if (token.IsCancellationRequested)
            //        {
            //            Console.WriteLine("cancellation called");
            //            Console.WriteLine(token.ToString());
            //            token.ThrowIfCancellationRequested(); // shows status as cancelled
            //            //throw new OperationCanceledException("Task cancelled"); // treat it like any other exception hence shows status as faulty 
            //        }
            //    }
            //}, token);

            //t.Start();

            //Console.ReadLine();
            //cts.Cancel();

            //try
            //{
            //    await t;
            //}
            //catch (OperationCanceledException e)
            //{
            //    Console.WriteLine(t.AsyncState);
            //    Console.WriteLine(t.CreationOptions);
            //    Console.WriteLine(t.Exception);
            //    Console.WriteLine(t.Id);
            //    Console.WriteLine(t.IsCanceled);
            //    Console.WriteLine(t.IsCompleted);
            //    Console.WriteLine(t.IsCompletedSuccessfully);
            //    Console.WriteLine(t.IsFaulted);
            //    Console.WriteLine(t.Status);
            //}

            Stopwatch stopwatch = Stopwatch.StartNew();
            string msg = await DoWorkAsync();
            Console.WriteLine(msg);
            //fun();

            stopwatch.Stop();
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            Console.WriteLine();
            Console.WriteLine();


            stopwatch.Restart();

            Task<Task<string>> t1 = new Task<Task<string>>(DoWorkAsync);
            t1.Start();
            //fun();
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);

            stopwatch.Stop();
            string msg2 =  t1.Result.Result;
            Console.WriteLine(msg2);


            Console.WriteLine(stopwatch.ElapsedMilliseconds);


        }


        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() => // waiting for the lambda function to finish 
            {
                Thread.Sleep(10000);
                return "Work done";
            });
        }

        static void fun()
        {
            for(long i=0; i<1000000; i++) { }
        }
    }

    
}
