using CommunityToolkit.Mvvm.ComponentModel;

namespace TaskApp.Sources.Models
{
    public class OnboardingModel : ObservableObject
    {
        private string _title;
        private string _description;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }
    }
}
