using System;
using System.Diagnostics;
using Prism.Navigation;

namespace TabbedPageSample.ViewModels
{
    public class MyTabbedPageViewModel : INavigationAware
    {
        public MyTabbedPageViewModel()
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Debug.WriteLine("MyTabbedPageViewModel OnNavigatedTo()");
        }
    }
}
