using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace practiceASP.Models
{

    // this is to show that all the of this class is written in EmployeeMetadata class
    // This is required if we regerate this Employee class as VS will remove all the  annotations that we add

    // To do the same with fields we use partial class
    //[ModelMetadataType(typeof(EmployeeMetadata))]

    public class Employee
    {
        [Key]
        [Display(Name ="Employee Number")]
        [Required(ErrorMessage ="Employee Number cannot be empty")]
        
        public int EmpNo { get; set; }

        [Required(ErrorMessage ="Name cannot be empty")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Basic cannot be empty")]

        public decimal Basic { get; set; }

        [Display(Name="Department Number")]
        [Required(ErrorMessage = "Department Number cannot be empty")]

        public int DeptNo { get; set; }


        public static void Insert(Employee emp)
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
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static List<Employee> GetAllEmployes()
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
                throw;
            }
            finally
            {
                cn.Close();
            }

            return employees;
        }
        public static Employee getSingleEmployee(int EmpNo)
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
                throw;
            }
            finally
            {
                cn.Close();
            }

            return emp;
        }
        public static void update(Employee emp)
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
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static void delete(int EmpNo)
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
                throw;
            }
            finally
            {
                cn.Close();
            }

        }




        /*
         some other Validation attributes =>
            [ScaffoldColumn(false)] --> so that VS do not generate its code in views
            [Range(1,300)]
            [Compare("Password",ErrorMessage = "")]  --> compare confirm password with  password
                           --> only work if the confirm password is marked required
            [MinLength(2),MaxLength(20)]  --> min, max length of string 
            [AllowedValues(a,b,c ...)]
            [DeniedValues(a,b,c, ...  )]
         
         */
    }
}
