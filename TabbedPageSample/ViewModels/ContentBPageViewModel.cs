using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using TabbedPageSample.Models;

namespace TabbedPageSample.ViewModels
{
    public class ContentBPageViewModel : BindableBase, IActiveAware
    {
        public ObservableCollection<License> Lisences { get; }

        public ContentBPageViewModel()
        {
            Lisences = new ObservableCollection<License>()
            {
                new License
                {
                    Name = "ライブラリ1",
                    Version = "1.0.0.0",
                    IsDeletable = false,
                },
                new License
                {
                    Name = "ライブラリ2",
                    Version = "1.0.0.1",
                    IsDeletable = true,
                },
                new License
                {
                    Name = "ライブラリ3",
                    Version = "1.0.0.2",
                    IsDeletable = false,
                },
            };
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
