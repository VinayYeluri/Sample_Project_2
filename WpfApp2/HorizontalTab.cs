using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public class HorizontalTab : TabControl
    {
        public HorizontalTab()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HorizontalTab), new FrameworkPropertyMetadata(typeof(HorizontalTab)));
            this.Loaded += HorizontalTab_Loaded;            
        }

        /// <summary>
        /// It stores the scrollviewer of tabpanel which I made static property to access it from MainWindow.xaml.cs
        /// </summary>
        public static ScrollViewer? _Scroll { get; set; }

        /// <summary>
        /// This method is used to find the scrollviewer in the control template as we can't acess it directly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HorizontalTab_Loaded(object sender, RoutedEventArgs e)
        {
            ScrollViewer? tabScroll = this.Template.FindName("tabscroll", this) as ScrollViewer;    //"tabscroll" is the name of the scrollviewer.
            if (tabScroll != null && tabScroll.ComputedHorizontalScrollBarVisibility == Visibility.Visible)
            {
                _Scroll = tabScroll;
                tabScroll.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            }
        }

        /// <summary>
        /// This dependency property is used as borderbrush.
        /// </summary>
        public System.Windows.Media.Brush FrameColor
        {
            get { return (System.Windows.Media.Brush)GetValue(FrameColorProperty); }
            set { SetValue(FrameColorProperty, value); }
        }

        public static readonly DependencyProperty FrameColorProperty = DependencyProperty.Register(
            "FrameColor",
            typeof(System.Windows.Media.Brush),
            typeof(HorizontalTab),
            new FrameworkPropertyMetadata(System.Windows.Media.Brushes.Orange, FrameworkPropertyMetadataOptions.AffectsRender));       
    }
}
