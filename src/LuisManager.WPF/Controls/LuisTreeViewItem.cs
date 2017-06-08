using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LuisManager.WPF.Controls
{
	public class LuisTreeViewItem : TreeViewItem
	{
		public static readonly DependencyProperty ImgPathProperty =
			DependencyProperty.Register("ImgPath", typeof(BitmapImage), typeof(LuisTreeViewItem), new PropertyMetadata(null));
		public static readonly DependencyProperty IsSmallProperty =
			DependencyProperty.Register("IsSmall", typeof(bool), typeof(LuisTreeViewItem), new PropertyMetadata(false));
		public static readonly DependencyProperty IsGroupedProperty =
			DependencyProperty.Register("IsGrouped", typeof(bool), typeof(LuisTreeViewItem), new PropertyMetadata(false));

		public BitmapImage ImgPath
		{
			set => SetValue(ImgPathProperty, value);
		    get => (BitmapImage)GetValue(ImgPathProperty);
		}

		public bool IsSmall
		{
			set => SetValue(IsSmallProperty, value);
		    get => (bool)GetValue(IsSmallProperty);
		}

		public bool IsGrouped
		{
			set => SetValue(IsGroupedProperty, value);
		    get => (bool)GetValue(IsGroupedProperty);
		}

		

		protected override DependencyObject GetContainerForItemOverride()
		{
		    var item = new LuisTreeViewItem {IsGrouped = true};
		    return item;
		}
	}
}
