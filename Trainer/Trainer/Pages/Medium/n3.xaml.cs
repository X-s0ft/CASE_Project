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
    /// Interaction logic for n3.xaml
    /// </summary>
    public partial class n3 : Page
    {
        public n3()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            if(Superfluous.IsChecked == true)
            {
                App.Current.Resources["Mn5"] = 1;
            }
            else
            {
                App.Current.Resources["Mn5"] = 0;
            }

            this.NavigationService.Navigate(new Final());
        }
    }
}
