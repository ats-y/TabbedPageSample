using Xamarin.Forms;

namespace TabbedPageSample.Controls
{
    /// <summary>
    /// ライセンス表示View。
    /// バインディングプロパティのみ定義し、表示はXamlのControlTemplateで行う。
    /// https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/templates/control-template
    /// </summary>
    public class LicenseView : ContentView
    {
        public static readonly BindableProperty LicenseNameProperty = BindableProperty.Create(
            nameof(LicenseName), typeof(string), typeof(LicenseView), string.Empty);
        public static readonly BindableProperty LicenseVersionProperty = BindableProperty.Create(
            nameof(LicenseVersion), typeof(string), typeof(LicenseView), string.Empty);

        /// <summary>
        /// ライセンス名
        /// </summary>
        public string LicenseName
        {
            get => (string)GetValue(LicenseNameProperty);
            set => SetValue(LicenseNameProperty, value);
        }

        /// <summary>
        /// バージョン
        /// </summary>
        public string LicenseVersion
        {
            get => (string)GetValue(LicenseVersionProperty);
            set => SetValue(LicenseVersionProperty, value);
        }

        public LicenseView()
        {
        }
    }
}
