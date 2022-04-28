using System;

namespace BookingManagement
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Subject { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
      
    }
}
