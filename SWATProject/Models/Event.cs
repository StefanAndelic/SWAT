using System;
namespace SWATProject.Models
{
    public class Event
    {


        public int Id { get; set; }

        //type of the event(e.g. Meeting, Booth etc.)
        public string Name { get; set; }

        //description
        public string Description { get; set; }

        public string Duration { get; set; }

        public DateTime date { get; set; }

        public string MeetingNotes { get; set; }

        public string Image { get; set; }



    }
}
