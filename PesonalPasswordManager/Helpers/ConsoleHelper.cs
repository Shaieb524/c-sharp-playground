using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PesonalPasswordManager.Helpers
{
    internal class ConsoleHelper
    {
        public void CheckOldPassword(SqlConnection connectionsString)
        {
            Console.WriteLine("Enter which service password you want to change : ");
            string service = Console.ReadLine();

            string sql = $"SELECT * FROM passwords WHERE Service = \'{service}\'";
            using (SqlCommand command = new SqlCommand(sql, connectionsString))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Service : {0} , Password : {1}", reader.GetString(0), reader.GetString(1));
                    }
                }
            }
        }

        public void AddNewServicePassword(SqlConnection connectionsString)
        {
            Console.WriteLine("Enter which service you want to add : ");
            string Service = Console.ReadLine();
            Console.WriteLine("Enter service password : ");
            string password = Console.ReadLine();

            using (connectionsString)
            {
                Console.WriteLine("=========================================\n");

                string sql = "INSERT INTO passwords(Service, Password, CreatedOn) VALUES(@Service, @Password, @CreatedOn)";
                using (SqlCommand cmd = new SqlCommand(sql, connectionsString))
                {
                    cmd.Parameters.AddWithValue("@Service", Service);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }

                Console.WriteLine("Data inserted Successfully!\n");

            }


        }
    }
}
