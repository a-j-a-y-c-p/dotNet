using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;

namespace serializationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.Id = 11;
            o.Name = "abbc";
            //BinaryFormatter bf = new BinaryFormatter();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Class1));
            Stream s = new FileStream("D:\\pqr.dat",FileMode.Create);
            js.WriteObject(s, o);
            s.Close();

            //Stream s1 = new FileStream("D:\\pqr.dat", FileMode.Open);
            //Class1 o = (Class1)js.ReadObject(s1);
            //Console.WriteLine(o);
            //s1.Close();


        }
    }

    [Serializable]
    public class Class1
    {
        public int Id {  get; set; }
        public string Name { get; set; }
    }
}
