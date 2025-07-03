using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateAsync
{
        internal class Program
        {
            static void Main(string[] args)
            {
                //int i=0; 
                //Interlocked.Add(ref i, 10);
                //Console.WriteLine(i);

                Func<string, string> oA = Fun;
            //oA.BeginInvoke("Hello", Fun1, null);
            oA.BeginInvoke("Hello", Fun2, oA);
                Console.ReadLine();

                void Fun1(IAsyncResult aR)
                {
                    Console.WriteLine("Hiii " + oA.EndInvoke(aR));
                }
            }


        static void Fun2(IAsyncResult aR)
        {
            var oA = (Func<string, string>) aR.AsyncState;
            Console.WriteLine("Hiii " + oA.EndInvoke(aR));

        }

        public static string Fun(string a)
            {
                return a.ToUpper();
            }
        }

}
