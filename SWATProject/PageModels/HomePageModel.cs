using System;
using FreshMvvm;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SWATProject.PageModels
{
    public class HomePageModel : FreshBasePageModel
    {
        public Command PlayVideo { get; set; }


        public HomePageModel()
        {
            PlayVideo = new Command(GoToVideoPage);
        }


        private void GoToVideoPage()
        {
            CoreMethods.PushPageModel<VideoPageModel>();
        }
    }
}
