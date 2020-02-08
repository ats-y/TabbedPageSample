using System;
using System.Diagnostics;
using Prism.Navigation;
using Xamarin.Forms;

namespace TabbedPageSample.ViewModels
{
    public class MainPageViewModel
    {
        public Command ToMyTabbedPageCommand { get; }
        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ToMyTabbedPageCommand = new Command(
                x => OnMyTabbedPageCommand(x));
        }

        private void OnMyTabbedPageCommand(object x)
        {
            Debug.WriteLine("OnMyTabbedPageCommand called.");
            //_navigationService.NavigateAsync("MyTabbedPage?selectedTab=ContentBPage");
            _navigationService.NavigateAsync("MyTabbedPage");
        }
    }
}
