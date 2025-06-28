namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of batches : ");
            int batches = Convert.ToInt32(Console.ReadLine());

            int[][] cdac = new int[batches][];

            for(int i = 0; i < batches; i++)
            {
                Console.WriteLine("Enter no. of students : ");

                int students = Convert.ToInt32(Console.ReadLine());
                int[] marks = new int[students];
                for (int j = 0; j < students; j++)
                {
                    Console.WriteLine($"Enter marks of Student of batch {i+1} student no {j+1}");
                    int mark = Convert.ToInt32(Console.ReadLine());
                    marks[j] = Convert.ToInt32(mark);
                }

                cdac[i] = marks;
            }

            foreach (int[] students in cdac)
            {
                foreach(int marks in students)
                {
                    Console.Write(marks);
                }
                Console.WriteLine();
            }
        }
    }
}
