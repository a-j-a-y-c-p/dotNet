using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Connect();
            //Insert();
            //Employee emp = new Employee { EmpNo = 6, Name = "Sumit", Basic = 90000, DeptNo = 30 };
            //Employee emp1 = new Employee { EmpNo = 7, Name = "oj'v", Basic = 9000, DeptNo = 20 };
            //Employee emp2 = new Employee { EmpNo = 9, Name = "nilay", Basic = 60000, DeptNo = 10 };
            //Insert2(emp1);
            //InsertWithStoredProcedure(emp2);
            //GetData();

            //List<Employee> empList = GetAllEmployes();
            //foreach(Employee emp in empList)
            //{
            //    Console.WriteLine(emp.Name);
            //}

            Console.WriteLine(getSingleEmployee(9));
        }
        

        static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                Console.WriteLine("connection opened");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void Insert()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employees values(8,'Ajay',1150000,10)";
                cmd.ExecuteNonQuery(); // returns int -> no. of rows updated (affected)
                Console.WriteLine("success");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void Insert2(Employee emp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn; 
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }



        static void InsertWithStoredProcedure(Employee emp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void update()
        {

        }

        static void delete()
        {

        }



        static void GetData()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select name from Employees where empno=8";
                //object res = cmd.ExecuteScalar();  --> only gives first row, first column
                //Console.WriteLine(res);

                //cmd.CommandText = "select * from employees";
                cmd.CommandText = "select * from employees; select * from departments";
                SqlDataReader dr = cmd.ExecuteReader();

                //dr.Read(); // return true/false weather the data is read or not
                //dr[0] <=> dr["empno"]
                //dr.HasRows(); // gives if any row is available

                while(dr.Read())
                {
                    Console.WriteLine("EmpNo: " + dr[0]);
                    Console.WriteLine("Name: " + dr["name"]);
                    Console.WriteLine("Basic: " + dr["basic"]);
                    Console.WriteLine("DeptNo: " + dr["deptno"]);
                    Console.WriteLine("\n");
                }

                dr.NextResult(); // return true if there is next result available
                Console.WriteLine("Department table  data ---");
                while (dr.Read())
                {
                    Console.WriteLine("DeptNo : " + dr["deptno"]);
                    Console.WriteLine("DeptName: " + dr["deptname"]);
                    Console.WriteLine();
                }

                dr.Close();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static List<Employee> GetAllEmployes()
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from employees";
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpNo = (int) dr[0];
                    emp.Name = (string) dr["name"];
                    emp.Basic = (decimal) dr["basic"];
                    emp.DeptNo = (int)dr["deptno"];
                    employees.Add(emp);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return employees;
        }

        static Employee getSingleEmployee(int EmpNo)
        {
            Employee emp = null;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from employees where empNo = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    emp = new Employee();
                    emp.EmpNo = (int)dr[0];
                    emp.Name = (string)dr["name"];
                    emp.Basic = (decimal)dr["basic"];
                    emp.DeptNo = (int)dr["deptno"];
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return emp;
        }

        static Employee getDataFromMultipleTable(int EmpNo)
        {
            Employee emp = null;

            SqlConnection cn = new SqlConnection();
            //specific To sql server ====>
            //MultipleActiveResultSet=true (MARS) ---->  to open multiple connecions (read from multiple tables at the same time)
            // without MARS therse is default property that if a reader is using the cn
            // then no one other can open the cn until the first reader is finished.
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;MultipleActiveResultSet=true"; try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from employees where empNo = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                //Automatically close the connection when reader is closed.
                //(usefull if wer are passing the reader
                //or
                //if there is a lock on database that can only connect to one table at a time
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                if (dr.Read())
                {
                    emp = new Employee();
                    emp.EmpNo = (int)dr[0];
                    emp.Name = (string)dr["name"];
                    emp.Basic = (decimal)dr["basic"];
                    emp.DeptNo = (int)dr["deptno"];
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return emp;
        }


        static void transectionsFunction()
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;MultipleActiveResultSet=true";
            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();

            cmd1.Transaction = t;  // if we had done cn.beginTransection then this line is compulsory
            cmd2.Transaction = t;

            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                t.Commit();
            }
            catch (Exception e)
            {
                t.Rollback();
                Console.WriteLine("Rollback");
                Console.WriteLine(e.Message);
            }

        }




        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }

            public decimal Basic {  get; set; }

            public int DeptNo { get; set; }


            public override string ToString()
            {
                return $"[EmpNo: {EmpNo}, Name: {Name}, Basic: {Basic}, DeptNo: {DeptNo}]";
            }
        }



    }
}
