using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4CSharpConsoleApplicationUppg2
{
    class Program

    {
        public static ServiceReference1.T4CsharpWebService1Uppg2SoapClient client = new ServiceReference1.T4CsharpWebService1Uppg2SoapClient();
        static void Main(string[] args)
        {
           
            Console.WriteLine("-------------------Information från Grupp 4 Db Restaurants -------->" + "\n" );
            ServiceReference1.Restaurant [] restaurants = client.GetRestaurants(); 
            foreach (var element in restaurants)
            {
                Console.WriteLine(element.restaurantID + "," + element.restaurantName + "," + element.restaurantAdress + "," +
                    element.restaurantCity + "," + element.openHours + "," + element.phoneNumber + "," + element.mailAdress +
                    element.foodType + "," + element.priceClass + "\n");
            }

            Console.WriteLine("-------------------Information från Grupp 4 Db RestaurantRating -------->" + "\n");
            var Ratings = client.GetRestaurantRating();
            foreach (var element in Ratings)
            {
                Console.WriteLine(element.ratingID + "," + element.restaurantID + "," + element.reviewerName + "," +
                    element.ratingScore + "\n");
            }
           
                       Console.WriteLine("-------------------Information från Grupp 4 Db DiningTables -------->" + "\n");
            var diningTables = client.GetDiningTables();
            foreach (var element in diningTables)
            {
                Console.WriteLine(element.dtableID + "," + element.restaurantID + "," + element.seatAmount + "\n");
            }

            
            Console.WriteLine("Information från Grupp 4 Db TableReservations -->");
            var tableReservation = client.GetTableResarvations();
            foreach (var element in tableReservation) {

                Console.WriteLine(element.reservationID + "," + element.dtableID + "," + element.personName + "," +
                element.personMail + "," + element.personPhoneNumber + "," + element.guestAmount + "," + element.reservationDate +
                element.reservationTime);
            }

            Console.Read(); 

        }
    }
}
