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

namespace Trainer.Pages.Medium
{
    /// <summary>
    /// Interaction logic for n2.xaml
    /// </summary>
    public partial class n2 : Page
    {
        public n2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            ItemHide.Visibility = Visibility.Collapsed;
            Quest3.Visibility = Visibility.Visible;
        }

        private void btnNext_Click_2(object sender, RoutedEventArgs e)
        {
            if(Quest3.Text.ToUpper() == "J, I, M, X, Z, Q")
            {
                App.Current.Resources["Mn3"] = 1;
            }
            else
            {
                App.Current.Resources["Mn3"] = 0;
            }

            if (SecondA.IsChecked == true)
            {
                App.Current.Resources["Mn4"] = 1;
            }
            else
            {
                App.Current.Resources["Mn4"] = 0;
            }

            this.NavigationService.Navigate(new n3());
        }
    }
}
