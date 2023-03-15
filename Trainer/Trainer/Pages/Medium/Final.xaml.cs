using FireSharp.Config;
using FireSharp.Interfaces;
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
using Trainer.Classes;

namespace Trainer.Pages.Medium
{
    /// <summary>
    /// Interaction logic for Final.xaml
    /// </summary>
    public partial class Final : Page
    {

        IFirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "EM0CVtJwRDTSeBOANYOrBCtxJHZHj6pbEPIUez7m",
            BasePath = "https://base-7f796-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Final()
        {
            InitializeComponent();

            client = new FireSharp.FirebaseClient(fbc);

            Quest1.Content = App.Current.Resources["Mn1"];
            Quest2.Content = App.Current.Resources["Mn2"];
            Quest3.Content = App.Current.Resources["Mn3"];
            Quest4.Content = App.Current.Resources["Mn4"];
            Quest5.Content = App.Current.Resources["Mn5"];

            double questions = Convert.ToDouble(Quest1.Content) + Convert.ToDouble(Quest2.Content) + Convert.ToDouble(Quest3.Content) + Convert.ToDouble(Quest4.Content) + Convert.ToDouble(Quest5.Content);

            client.SetAsync(@"Users/" + LoginPage.login.ToString() + "/mediumTest", questions);

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
