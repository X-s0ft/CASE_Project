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

namespace Trainer.Pages.Easy
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
            if (Quest3.Text.ToLower() == "неправильно")
            {
                App.Current.Resources["En3"] = 1;
            }
            else
            {
                App.Current.Resources["En3"] = 0;
            }

            if (Quest4.Text.ToLower() == "лёд")
            {
                App.Current.Resources["En4"] = 1;
            }
            else
            {
                App.Current.Resources["En4"] = 0;
            }

            this.NavigationService.Navigate(new n3());
        }

    }
}
