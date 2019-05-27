using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Xceed.Wpf.Toolkit.PropertyGrid
{
    public class PageItem
    {
        public string Tooltip { get; set; }
        public BitmapImage Icon { get; set; }
        public bool IsChecked { get; set; }
        public bool IsEnabled { get; set; }
        public ICommand Command { get; set; }
    }
}
