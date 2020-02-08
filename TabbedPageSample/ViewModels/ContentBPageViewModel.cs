using System;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;

namespace TabbedPageSample.ViewModels
{
    public class ContentBPageViewModel : BindableBase, IActiveAware
    {
        public ContentBPageViewModel()
        {
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                SetProperty(ref _isActive, value);
                Debug.WriteLine($"ContentBPageViewModel IsActive Changed => {_isActive}");
            }
        }

        public event EventHandler IsActiveChanged;
    }
}
