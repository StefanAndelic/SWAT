using System;
using FreshMvvm;
using SWATProject.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SWATProject.PageModels
{
    public class LoginPageModel : FreshBasePageModel
    {

        public Command HomePage { get; set; }

        public Command SignUp { get; set; }

        private IRestInterface _restInterface;

        private string password { get; set; }

        public string Password
        {
            get { return password; }
            set
            {

                password = value;
            }
        }

        private string email { get; set; }

        public string Email
        {
            get { return email; }
            set
            {

                email = value;
            }
        }



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

        public LoginPageModel(IRestInterface restInterface)
        {
            _restInterface = restInterface;

            HomePage = new Command(GoToHomePage);

            SignUp = new Command(GoToSingUpPage);
        }

        private void GoToSingUpPage()
        {
            CoreMethods.PushPageModel<SignUpPageModel>();
        }

        private async void GoToHomePage()
        {

            var email_entry = Email;
            var password_entry = Password;

            var response_token = await _restInterface.GetToken(email_entry, password_entry);

            if (string.IsNullOrEmpty(response_token.access_token))
            {
                await CoreMethods.DisplayAlert("Error", "Wrong password or username", "Try again");
            }
            else
            {
                Preferences.Set("useremail", email_entry);
                Preferences.Set("password", password_entry);
                Preferences.Set("accesstoken", response_token.access_token);

                SwitchNavigation();

            }



        }


        public void SwitchNavigation()
        {
            var tabbedNavigation = new FreshTabbedNavigationContainer("secondNavPage");
            tabbedNavigation.AddTab<HomePageModel>("Home", "Home1.png", null);
            tabbedNavigation.AddTab<TeamPageModel>("Team", "Team1.png", null);
            tabbedNavigation.AddTab<EventsPageModel>("Events", "Contact1.png", null);
            tabbedNavigation.AddTab<ResourcesPageModel>("Resources", "Other1.png", null);

            CoreMethods.SwitchOutRootNavigation("secondNavPage");
        }


    }
}
