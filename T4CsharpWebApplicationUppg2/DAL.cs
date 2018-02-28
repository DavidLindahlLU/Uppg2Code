using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace T4CsharpWebApplicationUppg2
{
    public class Dal
    {

        private SqlConnection sqlConn = new SqlConnection();

        public SqlCommand GetRestaurants()
        {
            try
            {
                string sql = "SELECT * FROM Restaurant";
                sqlConn = Connect.GetConnection();
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                return cmd;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                Environment.Exit(0);
                return null;
            }

        }

        public SqlCommand GetDiningTables()
        {

            try
            {
                string sql = "SELECT * FROM DiningTable";
                sqlConn = Connect.GetConnection();
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                return cmd;
            }
            catch (SqlException e)
            {

                Console.WriteLine(e.StackTrace);
                Environment.Exit(0);
                return null;

            }


        }
        public SqlCommand GetTableReservations()
        {

            try
            {
                string sql = "SELECT * FROM TableReservation";
                sqlConn = Connect.GetConnection();
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                return cmd;
            }
            catch (SqlException e)
            {

                Console.WriteLine(e.StackTrace);
                Environment.Exit(0);
                return null;

            }

        }
        public SqlCommand GetRestaurantRatings()
        {
            try
            {
                string sql = "SELECT * FROM RestaurantRating";
                sqlConn = Connect.GetConnection();
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                return cmd;
            }
            catch (SqlException e)
            {

                Console.WriteLine(e.StackTrace);
                Environment.Exit(0);
                return null;

            }

        }

        /* public SqlCommand SelectFromCronus()
         {
             try
             {
                 string sql = "SELECT * FROM TableXX";
                 sqlConn = Connect.GetConnection();
                 sqlConn.Open();
                 SqlCommand cmd = new SqlCommand(sql, sqlConn);

                 return cmd;
             }
             catch (SqlException e)
             {

                 Console.WriteLine(e.StackTrace);
                 Environment.Exit(0);
                 return null;

             }
         }
         public SqlCommand DelteFromCronus()
         {
             try
             {
                 sqlConn = Connect.GetConnection();
                 sqlConn.Open();
                 SqlCommand cmd = new SqlCommand(sql, sqlConn);

                 return cmd;
             }
             catch (SqlException e)
             {

                 Console.WriteLine(e.StackTrace);
                 Environment.Exit(0);
                 return null;

             }
         }*/
    }

}

