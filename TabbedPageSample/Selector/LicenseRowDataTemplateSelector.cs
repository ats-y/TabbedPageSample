using System;
using Xamarin.Forms;
using TabbedPageSample.Models;

namespace TabbedPageSample.Selector
{
    /// <summary>
    /// ライセンス情報表示リスト行のテンプレートセレクタ
    /// </summary>
    public class LicenseRowDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate UnDeletableRow { get; set; }
        public DataTemplate DeletableRow { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            License license = (License)item;
            if (license.IsDeletable)
            {
                return DeletableRow;
            }
            return UnDeletableRow;
        }
    }
}
