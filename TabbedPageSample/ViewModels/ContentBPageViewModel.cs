using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using TabbedPageSample.Models;
using Xamarin.Forms;

namespace TabbedPageSample.ViewModels
{
    public class ContentBPageViewModel : BindableBase, IActiveAware
    {
        /// <summary>
        /// ライセンスリスト。
        /// </summary>
        public ObservableCollection<License> Licenses { get; }

        /// <summary>
        /// ライセンス行削除コマンド
        /// </summary>
        public Command RowDeleteCommand { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ContentBPageViewModel()
        {
            // ライセンス行削除コマンドのイベントハンドラを生成。
            RowDeleteCommand = new Command(x => OnRowDeleteCommand(x));

            // ライセンス一覧を生成。
            Licenses = new ObservableCollection<License>()
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
                    IsDeletable = false,
                },
                new License
                {
                    Name = "ライブラリ3",
                    Version = "1.0.0.2",
                    IsDeletable = true,
                },
                new License
                {
                    Name = "ライブラリ4",
                    Version = "1.0.0.1",
                    IsDeletable = true,
                },
                new License
                {
                    Name = "ライブラリ5",
                    Version = "1.0.0.1",
                    IsDeletable = true,
                },
            };
        }

        /// <summary>
        /// ライセンス行を削除する。
        /// </summary>
        /// <param name="x"></param>
        private void OnRowDeleteCommand(object x)
        {
            License target = x as License;
            if (target == null) return;
            Licenses.Remove(target);
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
