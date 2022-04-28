using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement
{
    /// <summary>
    /// Contextklass för bokningar. Innehåller en metod
    /// för att hämta alla bokningar. Business Logic är sedan ansvarigt för att filtrera
    /// i datat.
    /// </summary>
    public class DataContext
    {
        private List<Booking> bookings;
        public DataContext()
        {
            bookings= new List<Booking>() { 
                new Booking(){  
                    BookingID=1,
                    Subject="Booking 1",
                    IsCancelled=false,
                    StartDate=DateTime.Parse("2022-04-20"),
                    EndDate=DateTime.Parse("2022-04-23") 
                },
                new Booking(){
                    BookingID=1,
                    Subject="Booking 2",
                    IsCancelled=false,
                    StartDate=DateTime.Parse("2022-04-24"),
                    EndDate=DateTime.Parse("2022-04-30")
                }
                , new Booking(){
                    BookingID=1,
                    Subject="Booking 3",
                    IsCancelled=true,
                    StartDate=DateTime.Parse("2022-04-20"),
                    EndDate=DateTime.Parse("2022-04-27")
                }

            };
           
        }

        public List<Booking> GetBookings()
        {
            return bookings;
        }
    }
}
