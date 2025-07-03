namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Employee oe1 = new Employee("Amol", 123465, 10);
            Employee oe2 = new Employee("Amol", 123465);
            Employee oe3 = new Employee("Amol");
            Employee oe4 = new Employee();


            Employee empKush = new Employee();
            Employee empAjay = new Employee("Ajay Saini", 987654321, 14);
            Employee empHarshit = new Employee("Harshit Srivastava", 34567899, 17);

            empKush.Name = "Kushagra Srivastava";
            empKush.DeptNo = 6;
            empKush.Basic = 1000000;
            Console.WriteLine("------->Employee details<----------");
            Console.WriteLine("Employee name : " + empKush.Name);
            Console.WriteLine("Employee number : " + empKush.EmpNo);
            Console.WriteLine("Employee department number : " + empKush.DeptNo);
            Console.WriteLine("Employee basic : " + empKush.Basic);
            Console.WriteLine("Employee net salary : " + empKush.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine("Employee name : " + empAjay.Name);
            Console.WriteLine("Employee number : " + empAjay.EmpNo);
            Console.WriteLine("Employee department number : " + empAjay.DeptNo);
            Console.WriteLine("Employee basic : " + empAjay.Basic);
            Console.WriteLine("Employee net salary : " + empAjay.GetNetSalary());
            Console.WriteLine();
            Console.WriteLine("Employee name : " + empHarshit.Name);
            Console.WriteLine("Employee number : " + empHarshit.EmpNo);
            Console.WriteLine("Employee department number : " + empHarshit.DeptNo);
            Console.WriteLine("Employee basic : " + empHarshit.Basic);
            Console.WriteLine("Employee net salary : " + empHarshit.GetNetSalary());
            Console.WriteLine("-----------------------------------");
        }
    }

    public class Employee
    {
        private string? name;

        public string? Name
        {
            set
            {
                if (value!.Length <= 0)
                {
                    throw new InvalidNameException("Name cannot be blank!");
                }
                else
                {
                    this.name = value;
                }
            }
            get
            {
                return this.name;
            }
        }

        static int EmployeeNoGenerator = 1;
        private int? empno;
        public int? EmpNo
        {
            get
            {
                return this.empno;
            }
        }

        private decimal basic;

        public decimal Basic
        {
            set
            {
                if (value >= 1000000 && value <= 10000)
                {
                    throw new InvalidBasicException("Basic must be between 1000000 to 10000!");
                }
                else
                {
                    this.basic = value;
                }
            }
            get
            {
                return this.basic;
            }
        }

        private short deptno;

        public short DeptNo
        {
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDepartmentNumberException("Deptno should be greater than 0");
                }
                else
                {
                    this.deptno = value;
                }
            }
            get
            {
                return this.deptno;
            }
        }

        public Employee()
        {
            this.empno = EmployeeNoGenerator++;
        }

        public Employee(string name="Employee", decimal basic=1000, short deptNo=11)
        {

            this.empno = EmployeeNoGenerator++;

            Name = name;
            
            Basic = basic;
            
            DeptNo = deptNo;
        }

        public decimal GetNetSalary()
        {
            return this.basic * 10 + 500;
        }

    }
}

