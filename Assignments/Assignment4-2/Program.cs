namespace Assignment4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = new Employee[5];

            arr[0] = new Employee { Id = 1 , Name="abc",Salary=532};
            arr[1] = new Employee { Id = 2 , Name="abc",Salary=5332};
            arr[2] = new Employee { Id = 3 , Name="abc",Salary=22};
            arr[3] = new Employee { Id = 4 , Name="abc",Salary=252};
            arr[4] = new Employee { Id = 5 , Name="abc",Salary=32};

            Array.Sort(arr, new Employee2());

            foreach (Employee item in arr) {
                Console.WriteLine(item.ToString());
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
                Console.WriteLine($"Employee found at idx {idx}");
            }
            
        }
    }

    class Employee : IComparable<Employee>
    {
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
    }

    class Employee2 : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return y.Salary.CompareTo(x.Salary);
        }
    }
}
