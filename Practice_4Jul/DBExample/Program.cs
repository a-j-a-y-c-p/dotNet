using System.Data;

namespace DBExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        static void Insert(Employee emp)
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

        static void Update(Employee emp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateEmployee";
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

        static void Delete(int EmpNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActsJune25;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteEmployee";
                cmd.Parameters.AddWithValue("@EmpNO", EmpNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("deleted successfully");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        static Employee GetSingleEmployee(int EmpNo)
        {
            Employee emp = null;

            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source = (localdb)\\ProjectModels; Initial Catalog = master; Integrated Security = True";
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
                    emp.EmpNo = (int)dr[0];
                    emp.Name = (string)dr["name"];
                    emp.Basic = (decimal)dr["basic"];
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


    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string? Name { get; set; }

        public decimal Basic { get; set; }

        public int DeptNo { get; set; }


        public override string ToString()
        {
            return $"[EmpNo: {EmpNo}, Name: {Name}, Basic: {Basic}, DeptNo: {DeptNo}]";
        }
    }
}
