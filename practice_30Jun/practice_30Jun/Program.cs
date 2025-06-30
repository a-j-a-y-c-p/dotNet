namespace practice_30Jun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Class1 c = new Class1();
            c.i = 1;
            c.j = 2;

            Console.WriteLine(c.i.isEven());
            Console.WriteLine(c.j);

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { Id = 1, Name = "abc", DeptId = 1});
            empList.Add(new Employee { Id = 2, Name = "bc", DeptId = 2});
            empList.Add(new Employee { Id = 3, Name = "cd", DeptId = 1});
            empList.Add(new Employee { Id = 4, Name = "asdc", DeptId = 3});
            empList.Add(new Employee { Id = 5, Name = "wefd", DeptId = 3});
            empList.Add(new Employee { Id = 6, Name = "xvsd", DeptId = 2});
            empList.Add(new Employee { Id = 7, Name = "pods", DeptId = 1});

            List<Department> deptList = new List<Department>();
            deptList.Add(new Department { Id = 1, Name = "dept1" });
            deptList.Add(new Department { Id = 2, Name = "dept2" });
            deptList.Add(new Department { Id = 3, Name = "dept3" });


            var emps = from emp in empList where emp.Name.Contains("b") select emp;
            var emps1 = from emp in empList join dept in deptList on emp.DeptId equals dept.Id select new { emp.Name, Department_Name = dept.Name };

            foreach(var emp in emps1)
            {
                Console.WriteLine(emp);
            }
        }
    }

    public partial class Class1
    {
        public int i { set; get; }

        partial void Fun(int i);
    }

    public partial class Class1
    {
        public int j { set; get; }

        partial void Fun(int i)
        {
            
        }


    }

    static class Class2
    {
        public static bool isEven(this int i)
        {
            return i % 2 == 0;
        }
    }

    public class Employee
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public int DeptId { set; get; }

        public override string ToString()
        {
            return $"[Id :{Id} , Name: {Name}, DeptId: {DeptId}]"; 
        }

    }

    public class Department
    {
        public int Id {  get; set; }

        public string Name {  get; set; }

        public override string ToString()
        {
            return $"[DeptId: {Id}, DeptName: {Name}]";
        }
    }
}
