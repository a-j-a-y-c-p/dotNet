using System.Diagnostics;

namespace TPLExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i=0;i<arr.Length; i++)
            {
                Thread.Sleep(1000);
                arr[i] = i * 10;
                Console.WriteLine(arr[i]);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            Console.WriteLine();
            stopwatch.Restart();
            Parallel.For(0, 10, delegate (int i) {
                Thread.Sleep(1000);
                arr[i] = i * 10;
                Console.WriteLine(arr[i]);
            });
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);



            Console.WriteLine();
            stopwatch.Restart();
            //Parallel.ForEach<int>(arr, delegate (int i) {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("element - " + i);
            //});
            Parallel.ForEach<int>(arr, i => {
                Thread.Sleep(1000);
                Console.WriteLine("element - " + i);
            });
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

        }
    }
}
