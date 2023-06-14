using TaskApp.Sources.Models;
using TaskApp.Sources.Services.Interface;

namespace TaskApp.Sources.Services
{
    public class OnboardingService : IOnboardingService
    {
        public OnboardingModel GetDataOnboardingAsync()
        {
            return new OnboardingModel()
            {
                Title = "Remenider Your Task",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris, amet, viverra at dictum"
            };
        }
    }
}
