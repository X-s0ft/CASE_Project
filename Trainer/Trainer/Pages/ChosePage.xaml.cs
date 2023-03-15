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
using Trainer.Pages;
using Trainer.Pages.Easy;
using Trainer.Pages.Hard;

namespace Trainer.Pages
{
    /// <summary>
    /// Interaction logic for ChosePage.xaml
    /// </summary>
    public partial class ChosePage : Page
    {
        public ChosePage()
        {
            InitializeComponent();

            UserName.Content = LoginPage.login.ToString();
        }

        private void btnGetProfile(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProfilePage());
        }

        private void btnEASY_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Easy.n1());
        }

        private void btnHARD_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Hard.n1());
        }

        private void btnMEDIUM_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Medium.n1());
        }

    }
}
