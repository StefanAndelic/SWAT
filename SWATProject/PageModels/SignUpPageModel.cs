using System;
using FreshMvvm;
using SWATProject.Interfaces;
using Xamarin.Forms;

namespace SWATProject.PageModels
{
    public class SignUpPageModel : FreshBasePageModel
    {
        public Command CreateAccount { get; set; }

        private string entPassword { get; set; }

        public string EntPassword
        {
            get { return entPassword; }
            set
            {

                entPassword = value;
            }
        }

        private string entEmail { get; set; }

        public string EntEmail
        {
            get { return entEmail; }
            set
            {

                entEmail = value;
            }
        }

        private string confirmPassword { get; set; }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {

                confirmPassword = value;
            }
        }

        private IRestInterface _restInterface;


        public SignUpPageModel(IRestInterface restInterface)
        {
            CreateAccount = new Command(GoToLoginPage);

            _restInterface = restInterface;
        }

        private async void GoToLoginPage()
        {
            var email = EntEmail;
            var pass = EntPassword;
            var confirmpass = ConfirmPassword;

            if (pass != confirmpass)
            {

                await CoreMethods.DisplayAlert("Passwords do not match", "Please enter again", "Ok");
            }

            bool response = await _restInterface.RegisterUser(email, pass, confirmpass);
            if (!response)
            {

                await CoreMethods.DisplayAlert("Oops", "Please try again", "Cancel");
            }
            else
            {
                await CoreMethods.DisplayAlert("Welcome to the application", "Your account has been created", "Ok");
                await CoreMethods.PushPageModel<LoginPageModel>();


            }


        }
    }
}
