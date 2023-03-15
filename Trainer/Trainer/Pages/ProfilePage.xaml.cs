using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Trainer.Classes;

namespace Trainer.Pages
{
    /// <summary>
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        IFirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "EM0CVtJwRDTSeBOANYOrBCtxJHZHj6pbEPIUez7m",
            BasePath = "https://base-7f796-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public ProfilePage()
        {
            InitializeComponent();

            client = new FireSharp.FirebaseClient(fbc);

            userName.Content = LoginPage.login.ToString();

            FirebaseResponse eazy = client.Get(@"Users/" + LoginPage.login.ToString() + "/easyTest");
            double eazyObj = eazy.ResultAs<double>();
            switch (eazyObj)
            {
                case 5:
                    EazyProgress.Value = 100;
                    break;
                case 4.5:
                    EazyProgress.Value = 90;
                    break;
                case 4:
                    EazyProgress.Value = 80;
                    break;
                case 3.5:
                    EazyProgress.Value = 70;
                    break;
                case 3:
                    EazyProgress.Value = 60;
                    break;
                case 2.5:
                    EazyProgress.Value = 50;
                    break;
                case 2:
                    EazyProgress.Value = 40;
                    break;
                case 1.5:
                    EazyProgress.Value = 30;
                    break;
                case 1:
                    EazyProgress.Value = 20;
                    break;
                case 0.5:
                    EazyProgress.Value = 10;
                    break;
                case 0:
                    EazyProgress.Value = 0;
                    break;
            }


            FirebaseResponse medium = client.Get(@"Users/" + LoginPage.login.ToString() + "/mediumTest");
            double mediumObj = medium.ResultAs<double>();
            switch (mediumObj)
            {
                case 5:
                    MedProgress.Value = 100;
                    break;
                case 4.5:
                    MedProgress.Value = 90;
                    break;
                case 4:
                    MedProgress.Value = 80;
                    break;
                case 3.5:
                    MedProgress.Value = 70;
                    break;
                case 3:
                    MedProgress.Value = 60;
                    break;
                case 2.5:
                    MedProgress.Value = 50;
                    break;
                case 2:
                    MedProgress.Value = 40;
                    break;
                case 1.5:
                    MedProgress.Value = 30;
                    break;
                case 1:
                    MedProgress.Value = 20;
                    break;
                case 0.5:
                    MedProgress.Value = 10;
                    break;
                case 0:
                    MedProgress.Value = 0;
                    break;
            }

            FirebaseResponse hard = client.Get(@"Users/" + LoginPage.login.ToString() + "/hardTest");
            double hardObj = hard.ResultAs<double>();
            switch (hardObj)
            {
                case 5:
                    HardProgress.Value = 100;
                    break;
                case 4.5:
                    HardProgress.Value = 90;
                    break;
                case 4:
                    HardProgress.Value = 80;
                    break;
                case 3.5:
                    HardProgress.Value = 70;
                    break;
                case 3:
                    HardProgress.Value = 60;
                    break;
                case 2.5:
                    HardProgress.Value = 50;
                    break;
                case 2:
                    HardProgress.Value = 40;
                    break;
                case 1.5:
                    HardProgress.Value = 30;
                    break;
                case 1:
                    HardProgress.Value = 20;
                    break;
                case 0.5:
                    HardProgress.Value = 10;
                    break;
                case 0:
                    HardProgress.Value = 0;
                    break;
            }
        }

        

        private void btnExit(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoginPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
