namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter Number of Employees:");
            n = Convert.ToInt32(Console.ReadLine());
            Employee[] arr = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new Employee();
                Console.Write($"Enter Name of {i+1} employee : ");
                arr[i].Name = Console.ReadLine();
                Console.Write($"Enter Salary of {i + 1} employee : ");
                arr[i].Salary = Convert.ToInt64(Console.ReadLine());
            }

            Array.Sort(arr, new Employee2());

            foreach (Employee item in arr) {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter EmpNo");
            int empNo = Convert.ToInt32(Console.ReadLine());

            int idx = Array.BinarySearch<Employee>(arr, new Employee {Id = empNo });

            if(idx < 0 )
            {
                Console.WriteLine("Employee not found.");
            }
            else
            {
                Console.WriteLine("Employee Found!!");
                Console.WriteLine(arr[idx]);
            }


            //2. convert it to list 
            IList<Employee> empList = new List<Employee>();
            empList = arr.ToList();

            //display list of employeees
            Console.WriteLine("____________Employee Details ____________");
            foreach (Employee item in empList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Employee : IComparable<Employee>
    {

        private static int counter = 1;
        public int Id { get; set; }
        public string? Name { get; set; }

        public float Salary {  get; set; }

        public int CompareTo(Employee? e)
        {
            return this.Id.CompareTo(e.Id);
        }

        public override string ToString()
        {
            return $"[ Id:  {Id}, Name: {Name} , Salary: {Salary}]";
        }

        public Employee()
        {
            Id = counter++;
        }
    }

    class Employee2 : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return y.Salary.CompareTo(x.Salary);
        }
    }
}
