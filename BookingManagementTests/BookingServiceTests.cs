using BookingManagement;
using NUnit.Framework;
using System;

namespace BookingManagementTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetOverlappingBookings_OverLap_ReturnsOverLapObject()
        {
            var booking = new Booking()
            {
                BookingID = 1,
                Subject = "Booking 1",
                IsCancelled = false,
                StartDate = DateTime.Parse("2022-04-20"),
                EndDate = DateTime.Parse("2022-04-23")
            };

            BookingService bs = new BookingService();

            var data =bs.GetOverlappingBookings(booking);

            Assert.That(data,Is.TypeOf<Booking>());
        }
    }
}