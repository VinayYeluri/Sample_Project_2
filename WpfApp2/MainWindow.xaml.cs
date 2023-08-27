using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AreTabsFillingWidth();
        }

        /// <summary>
        /// This method is used to check if the tab items filled in the tab control or not.
        /// </summary>
        private void AreTabsFillingWidth()
        {   
            //if the tabs are filled the arrow buttons will visisble.
            if((tab1.Items.Count * 100) > tab1.Width)
            {
                LeftButton.Visibility = Visibility.Visible; 
                RightButton.Visibility = Visibility.Visible;
            }       
        }

        /// <summary>
        /// This is the event for left button which scolls the scrollviewer to leftside by 3 lines.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbtn_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                HorizontalTab._Scroll.LineLeft();
            }
        }

        /// <summary>
        /// This is the event for right button which scolls the scrollviewer to rightside by 3 lines.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                HorizontalTab._Scroll.LineRight();
            }
        }
    }
}
