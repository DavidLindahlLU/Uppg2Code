using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace T4CsharpWebApplicationUppg2
{
    /// <summary>
    /// Summary description for T4CsharpWebService1Uppg2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class T4CsharpWebService1Uppg2 : System.Web.Services.WebService
    {

        public class Restaurant
        {
            public string restaurantID;
            public string restaurantName;
            public string restaurantAdress;
            public string restaurantCity;
            public string openHours;
            public string phoneNumber;
            public string mailAdress;
            public string foodType;
            public int priceClass;

        }
        public class RestaurantRating
        {
            public string ratingID;
            public string restaurantID;
            public string reviewerName;
            public decimal ratingScore;
          
        }

        public class TableReservation
        {
            public string reservationID;
            public string dtableID;
            public string personName;
            public string personMail;
            public string personPhoneNumber;
            public int guestAmount;
            public TimeSpan reservationDate;
            public TimeSpan reservationTime; 

        }

        public class DiningTable
        {
            public string dtableID;
            public string restaurantID;
            public int seatAmount;
        }

        [WebMethod]
        public List<Restaurant> GetRestaurants()
        {
            Dal dal = new Dal();
            SqlCommand sql = dal.GetRestaurants();
            List<Restaurant> restaurants = new List<Restaurant>();
            SqlDataReader oReader = sql.ExecuteReader();
            
            {
                while (oReader.Read())
                {
                    Restaurant rest = new Restaurant();
                    rest.restaurantID = oReader.GetString(0);
                    rest.restaurantName = oReader.GetString(1);
                    rest.restaurantAdress = oReader.GetString(2);
                    rest.restaurantCity = oReader.GetString(3);
                    rest.openHours = oReader.GetString(4);
                    rest.phoneNumber = oReader.GetString(5);
                    rest.mailAdress = oReader.GetString(6);
                    rest.foodType= oReader.GetString(7);
                    rest.priceClass = oReader.GetInt32(8);
                    restaurants.Add(rest);

                }
                return restaurants;

                
            }
        }

        [WebMethod]
        public List<TableReservation> GetTableResarvations()
        {
            Dal dal = new Dal();
            SqlCommand sql = dal.GetTableReservations();
            List<TableReservation> TableReservations = new List<TableReservation>();
            SqlDataReader oReader = sql.ExecuteReader();
            {
                while (oReader.Read())
                {
                    TableReservation rest = new TableReservation
                    {
                        reservationID = oReader.GetString(0),
                        dtableID = oReader.GetString(1),
                        personName = oReader.GetString(2),
                        personMail = oReader.GetString(3),
                        personPhoneNumber = oReader.GetString(4),
                        guestAmount = oReader.GetInt32(5),
                        reservationDate = oReader.GetTimeSpan(6),
                        reservationTime = oReader.GetTimeSpan(7)
                    };
                    TableReservations.Add(rest);
                }
                return TableReservations;
            }
        }

        [WebMethod]
        public List<DiningTable> GetDiningTables()
        {
            Dal dal = new Dal();
            SqlCommand sql = dal.GetDiningTables();
            List<DiningTable> DiningTables = new List<DiningTable>();
            SqlDataReader oReader = sql.ExecuteReader();
            {
                while (oReader.Read())
                {
                    DiningTable rest = new DiningTable();
                    rest.dtableID = oReader.GetString(0);
                    rest.restaurantID = oReader.GetString(1);
                    rest.seatAmount = oReader.GetInt32(2);
                    DiningTables.Add(rest);
                }
                return DiningTables;
            }
        }

        [WebMethod]
        public List<RestaurantRating> GetRestaurantRating()
        {
            Dal dal = new Dal();
            SqlCommand sql = dal.GetRestaurantRatings();
            List<RestaurantRating> RestaurantRatings = new List<RestaurantRating>();
            SqlDataReader oReader = sql.ExecuteReader();
            {
                while (oReader.Read())
                {
                    RestaurantRating rest = new RestaurantRating();
                    rest.ratingID = oReader.GetString(0);
                    rest.restaurantID = oReader.GetString(1);
                    rest.reviewerName = oReader.GetString(2);
                    rest.ratingScore = oReader.GetDecimal(3);
                    RestaurantRatings.Add(rest);
                }
                return RestaurantRatings;
            }
        }


        /*
                        [WebMethod]
                public SqlCommand SelectFromCronus()
                {
                    Dal dal = new Dal();
                    SqlCommand sql = dal.SelectFromCronus();

                    return sql;


                }

                [WebMethod]
                public SqlCommand DeleteFromCronus()
                {
                    Dal dal = new Dal();
                    SqlCommand sql = dal.SelectFromCronus();

                    return sql;


                }


                 [WebMethod] 
                  public List<Restaurant> GetRestaurants()
                 {
                     DataSet ds = new DataSet();
                     DAL dal = new DAL();
                     ds = dal.GetRestaurants();
                 List<Restaurant> restList = new List<Restaurant>();

                     foreach (DataRow dr in ds.Tables[0].Rows)

                         restList.Add(new Restaurant
                         {
                             restaurantName = Convert.ToString(dr["restaurantName"]),
                             restaurantAdress = Convert.ToString(dr["restaurantAdress"]),
                             openHours = Convert.ToString(dr["openHours"]),
                             phoneNumber = Convert.ToString(dr[" phoneNumber"]),
                             mailAdress = Convert.ToString(dr["mailAdress"]),
                             foodType = Convert.ToString(dr["mailAdress"])
                         });

                          return restList;
                 }


                 [WebMethod]
                 public List<TableReservation> GetTableReservations()
                 {
                     DataSet ds = new DataSet();
                     DAL dal = new DAL();
                     ds = dal.GetTableReservations();
                     List<TableReservation> reservationList = new List<TableReservation>();

                     foreach (DataRow dr in ds.Tables[0].Rows)

                         reservationList.Add(new TableReservation
                         {
                             reservationID = Convert.ToString(dr["reservationID"]),
                             dtableID = Convert.ToString(dr["dtableID"]),
                             personName = Convert.ToString(dr["personName"]),
                             personMail = Convert.ToString(dr["personMail "]),
                             personPhoneNumber = Convert.ToString(dr["personPhoneNumber"]),
                             guestAmount = Convert.ToInt32(dr["guestAmount"]),
                             reservationDate = Convert.ToDateTime(dr["reservationDate"])
                         });

                     return reservationList;
                 }

                 [WebMethod]
                 public List<RestaurantRating> GetRestaurantRatings()
                 {
                     DataSet ds = new DataSet();
                     DAL dal = new DAL();
                     ds = dal.GetRestaurantRatings();
                     List<RestaurantRating> rateList = new List<RestaurantRating>();

                     foreach (DataRow dr in ds.Tables[0].Rows)

                         rateList.Add(new RestaurantRating
                         {
                             restaurantName = Convert.ToString(dr["restaurantName"]),
                             ratingID = Convert.ToString(dr["ratingID"]),
                             reviewerName = Convert.ToString(dr["reviewerName"]),
                             reviewText = Convert.ToString(dr["reviewText"]),
                             ratingScore = Convert.ToInt32(dr["ratingScore"]),

                         });

                     return rateList;
                 }

                 [WebMethod]
                 public List<DiningTable> GetTables()
                 {
                     DataSet ds = new DataSet();
                     DAL dal = new DAL();
                     ds = dal.GetTables();
                     List<DiningTable> tabList = new List<DiningTable>();
                     foreach (DataRow dr in ds.Tables[0].Rows)

                        tabList.Add(new DiningTable
                         {
                             restaurantName = Convert.ToString(dr["restaurantName"]),
                             dtableID = Convert.ToString(dr["dtableID"]),
                             seatAmounte = Convert.ToInt32(dr["seatAmounte"])
                         });

                     return tabList;
                 }  */
    }
}
