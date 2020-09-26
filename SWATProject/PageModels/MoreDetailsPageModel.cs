using System;
using FreshMvvm;
using Xamarin.Forms;

namespace SWATProject.PageModels
{
    public class MoreDetailsPageModel : FreshBasePageModel
    {
        public Command Apply { get; set; }

        private string name { get; set; }

        public string Name
        {
            get { return name; }
            set
            {

                name = value;
            }
        }

        private string editorText { get; set; }

        public string EditorText
        {
            get { return editorText; }
            set
            {

                editorText = value;
            }
        }



        public MoreDetailsPageModel()
        {
            Apply = new Command(SaveAndSubmit);
        }

        private void SaveAndSubmit()
        {
            var enter_name = Name;

            var text_editor = EditorText;

            CoreMethods.PushPageModel<EventsPageModel>();
        }
    }
}
