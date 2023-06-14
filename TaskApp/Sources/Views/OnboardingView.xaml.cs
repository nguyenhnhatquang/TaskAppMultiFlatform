using TaskApp.Sources.Services;
using TaskApp.Sources.ViewModels;

namespace TaskApp.Sources.Views;

public partial class OnboardingView : ContentPage
{
	private OnboardingViewModel _viewModel;
	public OnboardingView()
	{
		InitializeComponent();
        _viewModel = new OnboardingViewModel(new OnboardingService());
        BindingContext = _viewModel;
    }
}