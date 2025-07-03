using System.Reflection;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assembly asm = Assembly.GetExecutingAssembly();
            //Assembly asm1 = Assembly.GetEntryAssembly();
            //Assembly asm2 = Assembly.GetExecutingAssembly();
            //Assembly asm3 = Assembly.GetAssembly(typeof(int));
            Assembly asm4 = Assembly.LoadFile(@"E:\CDAC\ms.net\FileHandlingExample\FileHandlingExample\bin\Debug\net9.0\FileHandlingExample.dll");

            Console.WriteLine(asm4.GetName().Name);

            Type[] arrTypes = asm4.GetTypes();
            foreach (Type t in arrTypes)
            {
                Console.WriteLine("   " + t.Name);
                MethodInfo[] methodArr = t.GetMethods();
                foreach (MethodInfo m in methodArr)
                {
                    Console.WriteLine("      " + m.Name);
                    ParameterInfo[] paramArr = m.GetParameters();
                    foreach (var p in paramArr)
                    {
                        Console.WriteLine("         " + p.Name);
                    }
                }
            }

        }
    }
}
