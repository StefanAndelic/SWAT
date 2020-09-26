using System;
using FreshMvvm;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SWATProject.PageModels
{
    public class ResourcesPageModel : FreshBasePageModel
    {

        public Command BubblePage { get; set; }

        public Command WellbeingResources { get; set; }

        public Command Identity { get; set; }

        public Command StudentLife { get; set; }

        public Command Workshops { get; set; }

        public Command Pressure { get; set; }

        public Command Mind { get; set; }

        public Command Money { get; set; }


        public ResourcesPageModel()
        {
            BubblePage = new Command(Bubble_Page);

            WellbeingResources = new Command(WellbeingResources_Page);

            Identity = new Command(Identity_Page);

            StudentLife = new Command(Student_Life_Page);

            Workshops = new Command(Workshops_Page);

            Mind = new Command(Mind_Page);

            Money = new Command(Money_Page);

            Pressure = new Command(Pressure_Page);


        }

        private void Bubble_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/the-bubble");
        }

        private void Pressure_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/pressure");
        }

        private void Money_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/money");
        }

        private void Mind_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/fuel");
        }

        private void Workshops_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/programmes-and-workshops");
        }

        private void Student_Life_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/managing-your-wellbeing");
        }

        private void Identity_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/identity");
        }

        private void WellbeingResources_Page()
        {
            Launcher.OpenAsync("https://www.wgtn.ac.nz/students/campus/health/wellbeing/online-wellbeing-resources");
        }
    }
}
