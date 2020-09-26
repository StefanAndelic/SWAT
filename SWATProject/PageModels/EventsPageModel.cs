using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using SWATProject.Interfaces;
using SWATProject.Models;
using Xamarin.Forms;

namespace SWATProject.PageModels
{
    public class EventsPageModel : FreshBasePageModel
    {


        private bool isBusy = true;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {

                isBusy = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<Event> activity;

        public ObservableCollection<Event> Activity
        {
            get { return activity; }
            set
            {

                activity = value;
            }
        }

        private Event _selectedEvent;

        public Event SelectedEvent

        {
            get { return null; }

            set
            {

                _selectedEvent = value;

                if (_selectedEvent != null)
                {

                    GoToSelectedEvent();

                    RaisePropertyChanged();


                }
            }
        }



        private IRestInterface _restInterface;

        public EventsPageModel(IRestInterface restInterface)
        {
            Activity = new ObservableCollection<Event>();

            _restInterface = restInterface;

            LoadEvents();


        }


        private void GoToSelectedEvent()
        {
            var user = _selectedEvent;
            int result = DateTime.Compare(user.date, DateTime.Now);
            if (result > 0)
            {
                CoreMethods.PushPageModel<SelectedEventPageModel>(user);
            }
            else
            {
                CoreMethods.PushPageModel<OlderSelectedEventPageModel>(user);

            }




        }

        public async void LoadEvents()
        {
            var events = await _restInterface.GetEvents();

            foreach (var inst in events)
            {
                Activity.Add(inst);
            }

            IsBusy = false;

        }





    }
}
