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
                // open connection 
                    conn.Open();
                    string Query = "INSERT INTO emp(Phone,Email,place,Department,Company) VALUES(@phone,@email,@place,@depart,@Company)";// this queery 
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        //link @ with variables  
                        cmd.Parameters.AddWithValue("@phone", e1.Emp_phone);
                        cmd.Parameters.AddWithValue("@email", e1.Emp_mail);
                        cmd.Parameters.AddWithValue("@place", e1.Emp_location);
                        cmd.Parameters.AddWithValue("@depart", e1.Emp_Department);
                        cmd.Parameters.AddWithValue("@Company", comp);


                        cmd.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
