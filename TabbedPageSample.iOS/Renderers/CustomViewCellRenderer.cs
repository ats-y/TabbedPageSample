using System;
using TabbedPageSample.Controls;
using TabbedPageSample.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]

namespace TabbedPageSample.iOS.Renderers
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            cell.SelectedBackgroundView = new UIView
            {
                BackgroundColor = ((CustomViewCell)item).SelectedBackgroundColor.ToUIColor()
            };
            return cell;
        }
    }
}
