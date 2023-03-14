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
    /// Interaction logic for n3.xaml
    /// </summary>
    public partial class n3 : Page
    {
        public n3()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            SeePhoto.Visibility = Visibility.Collapsed;
            Question5.Visibility = Visibility.Visible;
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            if (Quest5A.Text == "8" && Quest5B.Text.ToLower() == "змея")
            {
                App.Current.Resources["En5"] = 1;
            }
            else if (Quest5A.Text != "8" && Quest5B.Text.ToLower() == "змея" || Quest5A.Text == "8" && Quest5B.Text.ToLower() != "змея")
            {
                App.Current.Resources["En5"] = 0.5;
            }
            else
            {
                App.Current.Resources["En5"] = 0;
            }


            this.NavigationService.Navigate(new Final());
        }
    }
}
