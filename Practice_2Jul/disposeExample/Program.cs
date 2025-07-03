namespace disposeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 o = new Class1();
            //o.Id = 1;

            //Console.WriteLine(o.Id);
            //o.Dispose();

            using (Class1 o = new Class1())
            {
                o.Id = 1;

                Console.WriteLine(o.Id);
            } // automatically call dispose method if class1 is implementing IDispasible

        }
      
    }

    public class Class1 : IDisposable
    {
        public int Id { set; get; }

        public string Name { set; get; }

        private Boolean isDisposed = false;

        public void Dispose()
        {
            // free the resources here
            Console.WriteLine("dispose called");
            isDisposed = true;
        }

        private void checkIfDisposed()
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException("Object is already disposed");
            }
        }

    }
}
