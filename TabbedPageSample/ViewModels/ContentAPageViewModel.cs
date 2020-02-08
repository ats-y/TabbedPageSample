using System;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace TabbedPageSample.ViewModels
{
    public class ContentAPageViewModel : BindableBase, IActiveAware
    {
        public ContentAPageViewModel()
        {
        }

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
    }
}
