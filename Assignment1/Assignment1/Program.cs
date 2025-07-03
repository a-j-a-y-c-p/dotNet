namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNo = 0;
            emp.Name = "";
            emp.DeptNo = 6;
            emp.Basic = 100;
            Console.WriteLine("------->Employee details<----------");
            Console.WriteLine("Employee name : " + emp.Name);
            Console.WriteLine("Employee number : " + emp.EmpNo);
            Console.WriteLine("Employee department number : " + emp.DeptNo);
            Console.WriteLine("Employee basic : " + emp.Basic);
            Console.WriteLine("Employee net salary : " + emp.GetNetSalary());
            Console.WriteLine("-----------------------------------");
        }
    }

    public class Employee
    {
        private string name;

        public string Name
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new InvalidNameException("Name is invalid");
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

        private int empno;
        public int EmpNo
        {
            set
            {
                if (value <= 0)
                {
                    throw new InvalidEmployeeNumberException("Employee Number is not valid. It should be greater than 0");
                }
                else
                {
                    this.empno = value;
                }
            }
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
                if(value >= 1000000 && value <= 10000)
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
                if(value <= 0)
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

        public decimal GetNetSalary()
        {
            return this.basic * 10 + 500;
        }
    }
}
