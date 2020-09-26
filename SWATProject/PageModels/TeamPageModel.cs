using System;
using System.Collections.ObjectModel;
using FreshMvvm;
using SWATProject.Interfaces;
using SWATProject.Models;

namespace SWATProject.PageModels
{
    public class TeamPageModel : FreshBasePageModel
    {


        private ObservableCollection<SWATLeader> leaders;

        public ObservableCollection<SWATLeader> Leaders
        {
            get { return leaders; }
            set
            {

                leaders = value;
            }
        }

        private SWATLeader _selectedSWATLeader;

        public SWATLeader SelectedSWATLeader

        {
            get { return null; }

            set
            {

                _selectedSWATLeader = value;

                if (_selectedSWATLeader != null)
                {

                    GoToBubbleLeaderProfilePage();


                    RaisePropertyChanged();


                }
            }
        }

        private IRestInterface _restInterface;

        public TeamPageModel(IRestInterface restInterface)
        {
            _restInterface = restInterface;
            AddTeam();
        }



        private void GoToBubbleLeaderProfilePage()
        {
            var user = _selectedSWATLeader;
            CoreMethods.PushPageModel<SWATLeaderProfilePageModel>(user);

        }

        public void AddTeam()
        {
            Leaders = new ObservableCollection<SWATLeader>() {
                new SWATLeader()
                {

                    Name = "N",
                    Language = "Te Reo, English",
                    Education = "Health",
                    Hobbies = "Walking",
                    Position = "Team leader",
                    Image = "profilepicture.png",

                },

                new SWATLeader()
                {

                    Name = "J",
                    Language = "English",
                    Education = "Psychology",
                    Hobbies = "Walking",
                    Position="Assistant",
                    Image = "profilepicture.png",

                },

                new SWATLeader()
                {

                    Name = "S",
                    Language = "English",
                    Education = "Commerce",
                    Hobbies = "Walking",
                    Position = "Assistant",
                    Image = "profilepicture.png",

                },

                new SWATLeader()
                {

                    Name = "K",
                    Language = "English",
                    Education = "Health",
                    Hobbies = "Walking",
                    Position="Volunteer",
                    Image = "profilepicture.png",

                },

            };
        }

    }
}
