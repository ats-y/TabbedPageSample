using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
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
        /// ライセンス行削除コマンド。
        /// </summary>
        public Command RowDeleteCommand { get; }

        /// <summary>
        /// ライセンス行編集コマンド。
        /// </summary>
        public Command RowEditCommand { get; }

        /// <summary>
        /// ダイアログサービス。
        /// </summary>
        private IPageDialogService _dialogService;

        /// <summary>
        /// コンストラクタ。
        /// </summary>
        public ContentBPageViewModel(IPageDialogService dialog)
        {
            // インジェクションオブジェクトを保存。
            _dialogService = dialog;

            // コマンドのイベントハンドラを生成。
            RowDeleteCommand = new Command(x => OnRowDeleteCommand(x));
            RowEditCommand = new Command(async x => await OnRowEditCommandAsync(x));

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
        /// ライセンスを編集する。
        /// </summary>
        /// <param name="x"></param>
        private async Task OnRowEditCommandAsync(object x)
        {
            // 実際はダイアログで対象ライセンス名を表示するだけ。
            License target = x as License;
            if (target == null) return;
            await _dialogService.DisplayAlertAsync("編集", target.Name, "OK");
        }

        /// <summary>
        /// ライセンスを削除する。
        /// </summary>
        /// <param name="x"></param>
        private void OnRowDeleteCommand(object x)
        {
            License target = x as License;
            if (target == null) return;
            Licenses.Remove(target);
        }

        #region タブ切り替え時処理（IActiveAwareの実装）
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
        #endregion
    }
}
