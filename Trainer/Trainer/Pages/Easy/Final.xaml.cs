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
using System.Xml.Linq;

namespace Trainer.Pages.Easy
{
    /// <summary>
    /// Interaction logic for Final.xaml
    /// </summary>
    public partial class Final : Page
    {
        public Final()
        {
            InitializeComponent();

            Quest1.Content = App.Current.Resources["En1"];
            Quest2.Content = App.Current.Resources["En2"];
            Quest3.Content = App.Current.Resources["En3"];
            Quest4.Content = App.Current.Resources["En4"];
            Quest5.Content = App.Current.Resources["En5"];

            if (Quest1.Content.ToString() == "1" && Quest2.Content.ToString() == "1" && Quest3.Content.ToString() == "1" && Quest4.Content.ToString() == "1" && Quest5.Content.ToString() == "1")
            {
                Quest1.Foreground = new SolidColorBrush(Colors.Lime);
                Quest2.Foreground = new SolidColorBrush(Colors.Lime);
                Quest3.Foreground = new SolidColorBrush(Colors.Lime);
                Quest4.Foreground = new SolidColorBrush(Colors.Lime);
                Quest5.Foreground = new SolidColorBrush(Colors.Lime);

                ResultTest.Content = "Ты - молодец!";
                ResultTest.Foreground = new SolidColorBrush(Colors.Gold);
            }
            else if (Quest1.Content.ToString() == "0" && Quest2.Content.ToString() == "0" && Quest3.Content.ToString() == "0" && Quest4.Content.ToString() == "0" && Quest5.Content.ToString() == "0")
            {
                Quest1.Foreground = new SolidColorBrush(Colors.Red);
                Quest2.Foreground = new SolidColorBrush(Colors.Red);
                Quest3.Foreground = new SolidColorBrush(Colors.Red);
                Quest4.Foreground = new SolidColorBrush(Colors.Red);
                Quest5.Foreground = new SolidColorBrush(Colors.Red);
                    
                ResultTest.Content = "В следующий раз у тебя точно получится";
                ResultTest.Foreground = new SolidColorBrush(Colors.Wheat);
            }
            else
            {
                Quest1.Foreground = new SolidColorBrush(Colors.Orange);
                Quest2.Foreground = new SolidColorBrush(Colors.Orange);
                Quest3.Foreground = new SolidColorBrush(Colors.Orange);
                Quest4.Foreground = new SolidColorBrush(Colors.Orange);
                Quest5.Foreground = new SolidColorBrush(Colors.Orange);

                ResultTest.Content = "А ты хорош";
                ResultTest.Foreground = new SolidColorBrush(Colors.OrangeRed);
            }
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ChosePage());
        }
    }
}
