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

namespace Trainer.Pages.Hard
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


        private void btnNext_Click_2(object sender, RoutedEventArgs e)
        {
            if (Quest4.Text.ToLower() == "лук")
            {
                App.Current.Resources["Hn4"] = 1;
            }
            else
            {
                App.Current.Resources["Hn4"] = 0;
            }

            if (Final.IsChecked == true) 
            {
                App.Current.Resources["Hn3"] = 1;
            }
            else
            {
                App.Current.Resources["Hn3"] = 0;
            }

            this.NavigationService.Navigate(new n3());
        }
    }
}
