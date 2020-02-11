using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace TabbedPageSample.ViewModels
{
    public class ContentAPageViewModel : BindableBase, IActiveAware
    {
        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                SetProperty(ref _isActive, value);
                Debug.WriteLine($"ContentAPageViewModel IsActive Changed => {_isActive}");
            }
        }

        public event EventHandler IsActiveChanged;

        public Command NextPageCommand { get; }

        private INavigationService _navigationService;

        public ContentAPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NextPageCommand = new Command(async () => await OnNextPageCommandAsync());
        }

        private async Task OnNextPageCommandAsync()
        {
            await _navigationService.NavigateAsync("SubPage");
        }
    }
}
