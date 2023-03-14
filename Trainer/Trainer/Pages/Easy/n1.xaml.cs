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
    /// Interaction logic for n1.xaml
    /// </summary>
    public partial class n1 : Page
    {
        public n1()
        {
            InitializeComponent();
        }

        private void btnNext_Click_1(object sender, RoutedEventArgs e)
        {
            if(Quest1.Text == "47")
            {
                App.Current.Resources["En1"] = 1;
            }
            else
            {
                App.Current.Resources["En1"] = 0;
            }

            if (Quest2A.Text == "+" && Quest2B.Text == "-")
            {
                App.Current.Resources["En2"] = 1;
            }
            else if (Quest2A.Text == "+" || Quest2B.Text == "-")
            {
                App.Current.Resources["En2"] = 0.5;
            }
            else
            {
                App.Current.Resources["En2"] = 0;
            }

            this.NavigationService.Navigate(new n2());
        }
    }
}
