using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ceo = new CEO();
            ceo.Name = "Kushagra Srivastava";
            ceo.DeptNo = 97;
            ceo.Basic = 800000;
            ceo.CalcNetSalary();
            Console.WriteLine(ceo);
            Console.WriteLine("Net Salary : " + ceo.CalcNetSalary());


            Employee manager = new Manager();
            manager.Name = "Ajay Saini";
            manager.DeptNo = 18;
            manager.Basic = 600000;
            manager.CalcNetSalary();
            Console.WriteLine(manager);
            Console.WriteLine("Net Salary : " + manager.CalcNetSalary());

            Employee genManager = new GeneralManager();
            genManager.Name = "Harshit Srivastava";
            genManager.DeptNo = 77;
            genManager.Basic = 700000;
            genManager.CalcNetSalary();
            Console.WriteLine(genManager);
            Console.WriteLine("Net Salary : " + genManager.CalcNetSalary());


        }
    }



    abstract class Employee : IDbFunctions
    {

        private string? name;
        public string Name
        {

            set
            {
                if (value == null)
                {
                    throw new Exception("Name must not be blank.");
                }
                this.name = value;
            }
            get { return this.name ?? ""; }
        }

        private static int counter = 1;

        private int empNo;
        public int EmpNo { get; }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Dept no must be a positive value");
                }
                deptNo = value;

            }
            get
            {
                return deptNo;
            }

        }
       
        public abstract decimal Basic { get; set; }

        public Employee()
        {
            empNo = counter++;
        }

        public Employee(string name, short deptNo, decimal basic)
        {
            empNo = counter++;
            Name = name;
            DeptNo = deptNo;
            Basic = basic;
        }

        public abstract decimal CalcNetSalary();

        public virtual void test()
        {
            Console.WriteLine("test method from Employee class");
        }

        public override string ToString()
        {
            return "Employee Details : [Empno : " + empNo 
                + " Name : " + name
                + " Dept no : " + deptNo
                + " Basic : " + Basic 
                + " ]";
        }

    }

    class Manager : Employee, IDbFunctions
    {

        private string? designation;

        private decimal basic;

        public string Designation
        {

            set
            {
                if (value == null)
                {
                    throw new Exception("Designation must not be blank.");
                }
                this.designation = value;
            }
            get { return this.designation ?? ""; }
        }

        public override decimal Basic {
            set {
                if (value < 1000)
                    throw new Exception("Manager Basic should be greater than 1000");
                else
                    basic = value;
            }
            get { return basic; }
        }

        public Manager()
        {
        }

        public Manager(string designation, decimal basic, string name, short deptNo) : base(name,deptNo,basic)
        { 
            Designation = designation;
        }

        public override decimal CalcNetSalary()
        {
            return basic *10-400;
        }

        public override void test()
        {
            Console.WriteLine("test method from manager class");

        }
        public override string ToString()
        {
            return base.ToString() 
                + " Designation : " + designation;
        }

    }







    class GeneralManager : Manager, IDbFunctions
    {
        public string? Perks { set; get; }

        public GeneralManager()
        {

        }

        public GeneralManager(string? perks, string designation, decimal basic, string name, short deptNo) : base(designation, basic, name, deptNo)
        {
            Perks = perks;
        }

        public override decimal CalcNetSalary()
        {
            return Basic * 10 - 400;
        }
    }







    class CEO : Employee, IDbFunctions
    {
        private decimal basic;
        public override decimal Basic {
            set
            {
                if (value < 2000)
                    throw new Exception("Ceo Basic should be greater than 2000");
                else
                    basic = value;
            }
            get { return basic; }
        }

        public override sealed decimal CalcNetSalary()
        {
            return basic*10-900;
        }

        public CEO()
        {

        }

        public CEO(decimal basic , string name, short deptNo) : base(name,deptNo,basic)
        {

        }

    }

    interface IDbFunctions
    {

        void test();

    }
}
