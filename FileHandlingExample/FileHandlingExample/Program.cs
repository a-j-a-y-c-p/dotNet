using System.Text;

namespace FileHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //DriveInfo drive = new DriveInfo("C");
            //Console.WriteLine(drive.AvailableFreeSpace);


            //Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()));

            //??????????????????????????????????????????????????????
            ////DirectoryInfo d = new DirectoryInfo(@"D:\Games");
            ////foreach (var file in d.GetFiles())
            ////{
            ////    Console.WriteLine(file.FullName);
            ////}
            //???????????????????????????????????????????????????????


            //File.Create(@"D:\abc.txt");


            //// writing in the file
            //FileStream stream = File.Open("D:\\abc.txt",FileMode.OpenOrCreate);
            //string s = "hello this is the first file";
            //byte[] arr = Encoding.Default.GetBytes(s);

            //stream.Write(arr, 0, arr.Length);
            //stream.Close();


            ////reading from file
            //FileStream stream = File.Open("D:\\abc.txt", FileMode.Open);
            //byte[] arr = new byte[stream.Length];

            //stream.Read(arr, 0, arr.Length);
            //string s = Encoding.UTF8.GetString(arr);
            //Console.WriteLine(s);
            //stream.Close();


            //// Writing with streamWriter (formated data)
            //StreamWriter writer = File.AppendText(@"D:\abc.txt");
            //writer.WriteLine("second line");
            //writer.WriteLine("third line");
            //writer.WriteLine("forth line");
            //writer.Close();

            //// Reading with streamReader (formated data)
            //StreamReader reader = File.OpenText("D:\\abc.txt");
            //string s;
            //while((s = reader.ReadLine()) != null) {
            //    Console.WriteLine(s);
            //}


            // Binary data
            //FileInfo f = new FileInfo("D:\\abc.txt");
            //BinaryWriter binaryWriter = new BinaryWriter(f.OpenWrite());



            //BinaryReader binaryReader = new BinaryReader()


        }
    }
}
