using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Connection string to the database
        string connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabase;User ID=YourUsername;Password=YourPassword";

        // Create a SqlConnection object
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Open the connection
                connection.Open();
                Console.WriteLine("Connection opened successfully.");

                // Perform database operations here

                // Close the connection
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
