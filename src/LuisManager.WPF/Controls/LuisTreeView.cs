using System.Windows;
using System.Windows.Controls;

namespace LuisManager.WPF.Controls
{
	public class LuisTreeView : TreeView
	{
		public static readonly DependencyProperty SelectedItemReadOnlyProperty =
			DependencyProperty.Register("SelectedItemReadOnly", typeof(object), typeof(LuisTreeView), new PropertyMetadata(null));
		public static readonly DependencyProperty MinimizeItemsProperty =
			DependencyProperty.Register("MinimizeItems", typeof(bool), typeof(LuisTreeView), new PropertyMetadata(true, ResetSelection));

		static void ResetSelection(DependencyObject element, DependencyPropertyChangedEventArgs e)
		{
			if(((LuisTreeView)element).IsLoaded)
			{
				foreach (var item in ((LuisTreeView)element).Items)
				{
					LuisTreeViewItem lbItem = (LuisTreeViewItem)((LuisTreeView)element).ItemContainerGenerator.ContainerFromItem(item);
					if (lbItem.HasItems)
					{
						foreach (var subitem in lbItem.Items)
						{
							LuisTreeViewItem subtiItem = (LuisTreeViewItem)lbItem.ItemContainerGenerator.ContainerFromItem(subitem);
							if (subtiItem != null)
							{
								subtiItem.IsSmall = (bool)e.NewValue;
								if (subtiItem.IsSelected == true && ((bool)e.NewValue) == false) subtiItem.IsSelected = false;
							}
						}
					}
					lbItem.IsSmall = (bool)e.NewValue;
					if (lbItem.IsSelected && ((bool)e.NewValue) == false) lbItem.IsSelected = false;
				}
			}
		}

		protected override DependencyObject GetContainerForItemOverride()
		{
			return new LuisTreeViewItem();
		}

		protected override void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> e)
		{
			SetValue(SelectedItemReadOnlyProperty, e.NewValue);
			base.OnSelectedItemChanged(e);
		}

		public object SelectedItemReadOnly
		{
			set
			{
				if (value == null)
				{
					SetValue(SelectedItemReadOnlyProperty, null);
				}
			}
			get
			{
				return GetValue(SelectedItemReadOnlyProperty);
			}
		}

		public bool MinimizeItems
		{
			set => SetValue(MinimizeItemsProperty, null);
		    get => (bool)GetValue(MinimizeItemsProperty);
		}
	}
}