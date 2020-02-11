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
        public static readonly BindableProperty NameProperty = BindableProperty.Create(
            nameof(Name), typeof(string), typeof(LicenseView), string.Empty);
        public static readonly BindableProperty VersionProperty = BindableProperty.Create(
            nameof(Version), typeof(string), typeof(LicenseView), string.Empty);

        /// <summary>
        /// ライセンス名
        /// </summary>
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        /// <summary>
        /// バージョン
        /// </summary>
        public string Version
        {
            get => (string)GetValue(VersionProperty);
            set => SetValue(VersionProperty, value);
        }

        public LicenseView()
        {
        }
    }
}
