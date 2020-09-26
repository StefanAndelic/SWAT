using System;
namespace SWATProject.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime bookingtime { get; set; }

        public int EventId { get; set; }

        public int UserId { get; set; }



    }
}
