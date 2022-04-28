using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement
{
    /// <summary>
    /// Business Logicklass som har metod för att hämta ev dubbelbokningar
    /// mot en angiven bokning
    /// </summary>
    public class BookingService
    {
        
        /// <summary>
        /// Returnerar ev bokningskonflikter mot "booking" i datakällan. 
        /// </summary>
        /// <param name="booking">Den bokning som skall testas</param>
        /// <returns>null om konflikter saknas, i annat fall den första funna bokningen som skulle skapa konflikt</returns>
        public Booking GetOverlappingBookings(Booking booking)
        {
            var dsource = new DataContext();
            var activeBookings=dsource.GetBookings().Where(b=>b.IsCancelled==false).ToList();

            var overlap = activeBookings.FirstOrDefault(b=>booking.StartDate<=b.StartDate && booking.EndDate>b.StartDate || booking.StartDate>b.StartDate && booking.StartDate<=b.EndDate);
            return overlap!=null ? overlap : null;
        }
    }
}
