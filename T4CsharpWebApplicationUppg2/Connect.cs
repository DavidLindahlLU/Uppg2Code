using System;

using System.Data.SqlClient;


namespace T4CsharpWebApplicationUppg2
{
    class Connect
    {
        private static readonly string URL = " user id =userid;" +
            "Data Source=DESKTOP-KQQB2SR;" +
            "pwd=validpassword;" +
            "Initial Catalog=T4Csharp;" +
            "Integrated Security=True";

        public static SqlConnection GetConnection()

        {

            try
            {
                SqlConnection conn = new SqlConnection(URL);
                
                return conn;
            }
            catch (SqlException sqle)
            {
                Console.WriteLine(sqle.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
        
            }
            return null;



            
            
        }
    }
}