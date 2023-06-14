using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using TaskApp.Sources.Models;
using TaskApp.Sources.Services.Interface;

namespace TaskApp.Sources.ViewModels
{
    public class OnboardingViewModel : ObservableObject
    {
        private IOnboardingService _onboardingService;
        private OnboardingModel _onboarding;
        public OnboardingModel Onboarding
        {
            get { return _onboarding; }
            set { SetProperty(ref _onboarding, value); }
        }

        public ICommand NextCommand { get; }

        public OnboardingViewModel(IOnboardingService onboardingService)
        {
            _onboardingService = onboardingService;
            //
            GetData();
            //
            NextCommand = new Command(() => NextAsync());
        }

        private void GetData()
        {
            Onboarding = _onboardingService.GetDataOnboardingAsync();
        }

        private void NextAsync()
        {
            // Next Screen
        }
    }
}
