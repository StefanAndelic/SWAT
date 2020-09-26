using System;
using FreshMvvm;
using SWATProject.Interfaces;
using SWATProject.PageModels;
using SWATProject.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWATProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetUpIOC();

            SetUpMainNavigation();

            SetUpVideoPlayer();
        }

        public void SetUpVideoPlayer()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
        }

        public void SetUpIOC()
        {
            FreshIOC.Container.Register<IRestInterface, ApiService>();
        }

        public void SetUpMainNavigation()
        {

            if (!string.IsNullOrEmpty(Preferences.Get("accesstoken", "")))
            {
                var tabbedNavigation = new FreshTabbedNavigationContainer("secondNavPage");
                tabbedNavigation.AddTab<HomePageModel>("Home", "Home1.png", null);
                tabbedNavigation.AddTab<TeamPageModel>("Team", "Team1.png", null);
                tabbedNavigation.AddTab<EventsPageModel>("Events", "Contact1.png", null);
                tabbedNavigation.AddTab<ResourcesPageModel>("Resources", "Other1.png", null);
                MainPage = tabbedNavigation;
            }

            else if (string.IsNullOrEmpty(Preferences.Get("useremail", "")) && string.IsNullOrEmpty(Preferences.Get("password", "")))
            {
                //StartPageModel
                var mainPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
                var navigationContainer = new FreshNavigationContainer(mainPage, "login");
                MainPage = navigationContainer;
            }

        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
