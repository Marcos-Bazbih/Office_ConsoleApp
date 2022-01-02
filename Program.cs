using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringConnection = "Data Source=LENOVO-MARCOS;Initial Catalog=OfficeDb;Integrated Security=True;Pooling=False";
            
            //   employee
            //List<Employee> employees = new List<Employee>();
            //ShowAllEmpployees(stringConnection);
            //AddEmployeeToTable(stringConnection);
            //EditEmployee(stringConnection);
            //DeleteEmployee(stringConnection);



            //   manager
            List<Manager> managers = new List<Manager>();
            //ShowAllManagers(stringConnection);
            //AddManagerToTable(stringConnection);
            //EditManager(stringConnection);
            //DeleteManager(stringConnection);

        }







        //    manager
        static void ShowAllManagers(string stringConn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();
                    string query = "SELECT * FROM Manager";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    var dataFromDb = cmd.ExecuteReader();

                    if (dataFromDb.HasRows)
                    {
                        while (dataFromDb.Read())
                        {
                            Console.WriteLine(dataFromDb.GetInt32(0));
                            Console.WriteLine(dataFromDb.GetString(1));
                            Console.WriteLine(dataFromDb.GetString(2));
                            Console.WriteLine(dataFromDb.GetDateTime(3));
                            Console.WriteLine(dataFromDb.GetString(4));
                            Console.WriteLine(dataFromDb.GetString(5));
                        }
                    }
                    else
                    {
                        Console.WriteLine("no rows found");
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("error with Database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void AddManagerToTable(string stringConn)
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter birthday");
            string birthday = Console.ReadLine();

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter department");
            string department = Console.ReadLine();

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();


                    string query = $@"INSERT INTO Manager(FirstName, LastName, Birthday, Email, Department)
                                     VALUES('{firstName}', '{lastName}', '{birthday}', '{email}', '{department}')";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    int rowsEffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsEffected);
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Error occurred");
            }
        }
        static void EditManager(string stringConn)
        {
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter birthday");
            string birthday = Console.ReadLine();

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter department");
            string department = Console.ReadLine();

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();

                    string query = $@"UPDATE Manager 
                                    SET FirstName = '{firstName}',  LastName = '{lastName}',
                                    Birthday = '{birthday}', 
                                    Email = '{email}', Department = '{department}'
                                    WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    int rowsEffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsEffected);
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Error occurred");
            }
        }
        static void DeleteManager(string stringConn)
        {
            Console.WriteLine("Enter id number");
            int id = int.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();

                    string query = $@"DELETE FROM Manager WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    int rowsEffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsEffected);
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Error occurred");
            }
        }




        //    employee
        static void DeleteEmployee(string stringConn)
        {
            Console.WriteLine("Enter id number");
            int id = int.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();

                    string query = $@"DELETE FROM Employee WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    int rowsEffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsEffected);
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Error occurred");
            }
        }
        static void EditEmployee(string stringConn)
        {
            Console.WriteLine("Enter id number");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter new birthday");
            string birthday = Console.ReadLine();

            Console.WriteLine("Enter new email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter new salary");
            int salary = int.Parse(Console.ReadLine());



            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();

                    string query = $@"UPDATE Employee 
                                    SET Name = '{name}', Birthday = '{birthday}', 
                                    Email = '{email}', Salary = {salary}
                                    WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    int rowsEffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsEffected);
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Error occurred");
            }
        }
        static void AddEmployeeToTable(string stringConn)
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter birthday");
            string birthday = Console.ReadLine();

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter salary");
            int salary = int.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();


                    string query = $@"INSERT INTO Employee(Name, Birthday, Email, Salary)
                                     VALUES('{name}', '{birthday}', '{email}', {salary})";


                    SqlCommand cmd = new SqlCommand(query, connection);

                    int rowsEffected = cmd.ExecuteNonQuery();

                    Console.WriteLine(rowsEffected);
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Error occurred");
            }
        }
        static void ShowAllEmpployees(string stringConn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConn))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employee";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    var dataFromDb = cmd.ExecuteReader();

                    if (dataFromDb.HasRows)
                    {
                        while (dataFromDb.Read())
                        {
                            Console.WriteLine(dataFromDb.GetInt32(0));
                            Console.WriteLine(dataFromDb.GetString(1));
                            Console.WriteLine(dataFromDb.GetDateTime(2));
                            Console.WriteLine(dataFromDb.GetString(3));
                            Console.WriteLine(dataFromDb.GetInt32(4));
                        }
                    }
                    else
                    {
                        Console.WriteLine("no rows found");
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("error with Database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
