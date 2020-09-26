using System;
using FreshMvvm;
using SWATProject.Models;
using Xamarin.Forms;

namespace SWATProject.PageModels
{
    public class SelectedEventPageModel : FreshBasePageModel
    {

        Event _selectedEvent;

        public Command MoreDetails { get; set; }

        public string name { get; set; }

        public string Name
        {
            get { return name; }
            set
            {

                name = value;
            }
        }

        public string description { get; set; }

        public string Description
        {
            get { return description; }
            set
            {

                description = value;
            }
        }

        public string duration { get; set; }

        public string Duration
        {
            get { return duration; }
            set
            {

                duration = value;
            }
        }

        public DateTime date { get; set; }

        public DateTime Date
        {
            get { return date; }
            set
            {

                date = value;
            }
        }


        public SelectedEventPageModel(Event selectedEvent)
        {
            _selectedEvent = selectedEvent;

            MoreDetails = new Command(GoToMoreDetails);
        }

        private void GoToMoreDetails()
        {
            CoreMethods.PushPageModel<MoreDetailsPageModel>();
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            _selectedEvent = (Event)initData;
            Name = _selectedEvent.Name;
            Duration = _selectedEvent.Duration;
            Description = _selectedEvent.Description;
            Date = _selectedEvent.date;
        }

    }
}