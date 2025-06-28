namespace eventsApp
{



    internal class Program
    {


        static void Main(string[] args)
        {
            Employee employeeObj = new Employee();
            //employeeObj.InvalidId += EmployeeObj_InvalidId;

            employeeObj.InvalidId += EmployeeObj_InvalidId; 
            employeeObj.Id = 14;
        }

        static void EmployeeObj_InvalidId(int InvalidValue)
        {
            Console.WriteLine("Event handled" + InvalidValue);

        }
    }

    //public delegate void InvalidIdEventHandler();

    public delegate void InvalidIdEventHandler(int InvalidValue);


    public class Employee
    {
        public event InvalidIdEventHandler? InvalidId;


        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if(value < 100)
                {
                    if(InvalidId != null)
                        InvalidId!(value);
                        //InvalidId!();

                }
                else
                {
                    id = value;
                }
            }
        }
    }
}
