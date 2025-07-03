using System.Diagnostics;

namespace practice_1Jul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { Id = 1, Name = "abc", DeptId = 1 });
            empList.Add(new Employee { Id = 2, Name = "xbc", DeptId = 2 });
            empList.Add(new Employee { Id = 3, Name = "cd", DeptId = 1 });
            empList.Add(new Employee { Id = 4, Name = "asdc", DeptId = 3 });
            empList.Add(new Employee { Id = 5, Name = "wefd", DeptId = 3 });
            empList.Add(new Employee { Id = 6, Name = "bxvsd", DeptId = 2 });
            empList.Add(new Employee { Id = 7, Name = "pods", DeptId = 1 });

            List<Department> deptList = new List<Department>();
            deptList.Add(new Department { Id = 1, Name = "dept1" });
            deptList.Add(new Department { Id = 2, Name = "dept2" });
            deptList.Add(new Department { Id = 3, Name = "dept3" });


            var emps = from emp in empList where emp.Name.Contains("b") select emp;
            var emps1 = from emp in empList join dept in deptList on emp.DeptId equals dept.Id select new { emp.Name, Department_Name = dept.Name };
            var emps2 = empList.Select(emp => emp.Name);
            var emps3 = empList.Where(emp => emp.Name.Contains("b"));
            var emps4 = empList.Where(emp => emp.Name.Contains("b")).Select(emp => emp.Name);
            var emps5 = empList.OrderBy(emp => emp.DeptId);
            var emps6 = empList.OrderBy(emp => emp.DeptId).ThenBy(emp => emp.Name);
            var emps7 = empList.Join(deptList, emp => emp.DeptId, dept => dept.Id,( emp, dept) => new {emp,dept});
            var emp1 = empList.Single(e => e.Id == 2);
            var emp2 = empList.SingleOrDefault(e => e.Id == 20);

            //Console.WriteLine(emp2);
            //foreach (var item in emps7)
            //{
            //    Console.WriteLine(item);
            //}

            var emps8 = from emp in empList group emp by emp.DeptId;
            var emps9 = from emp in empList group emp by emp.DeptId into group1 select group1;
            var emps10 = from emp in empList group emp by emp.DeptId into group1 select  new { group1 ,Count = group1.Count()};
            var emps11 = empList.GroupBy(emp => emp.DeptId);

            //foreach(var item in emps11)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine();
            //}

            //Error
            //Console.WriteLine(empList.Single(emp => emp.DeptId == 1 ));

            //foreach (var item in emps10)
            //{
            //    Console.WriteLine(item.Count);
            //    foreach (var e in item.group1)
            //    {
            //        Console.WriteLine(e);
            //    }
            //    Console.WriteLine();
            //}

            //Stopwatch stopwatch = Stopwatch.StartNew();
            //Console.WriteLine(emp2);
            //foreach (var item in emps7)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine(item);
            //}
            //stopwatch.Stop();

            //Console.WriteLine(stopwatch.ElapsedMilliseconds);




            //var t = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(2));

            //(int, int) v = (1, 2);
            //var vt1 = (2, "234");
            //var v2 = (Num1: 2, Num2: 9);

            //Console.WriteLine(v);
            //Console.WriteLine(vt1);
            //Console.WriteLine(v2.Num1);
            //Console.WriteLine(v2.Num2);


            //?????????????????????????????????????????????????????????????????????????????????????
            //var t1 = (1, "abc");
            //fun(t1);

        }


        public static void fun(int a, string b)
        {
            Console.WriteLine(a + b);
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
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"[DeptId: {Id}, DeptName: {Name}]";
        }
    }
}
