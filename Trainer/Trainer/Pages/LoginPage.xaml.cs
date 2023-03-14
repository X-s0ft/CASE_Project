using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using Trainer.Pages;

namespace Trainer.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        public static string login { get; set; }

        IFirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "EM0CVtJwRDTSeBOANYOrBCtxJHZHj6pbEPIUez7m",
            BasePath = "https://base-7f796-default-rtdb.firebaseio.com/"
        };

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FirebaseClient client;
            client = new FirebaseClient(fbc);
            if (string.IsNullOrEmpty(LoginTxb.Text) && string.IsNullOrEmpty(PasswordB.Password))
            {
                MessageBox.Show("Данные не заполнены");
            }
            else
            {
                try
                {
                    FirebaseResponse response = client.Get(@"Users/" + LoginTxb.Text);
                    GetDATA dATA = response.ResultAs<GetDATA>();
                    GetDATA getDATA = new GetDATA()
                    {
                        login = LoginTxb.Text,
                        password = PasswordB.Password
                    };
                    if (GetDATA.IsEqual(dATA, getDATA))
                    {
                        login = LoginTxb.Text;
                        this.NavigationService.Navigate(new ChosePage());
                    }
                    else
                    {
                        MessageBox.Show("Проверьте введённые данные");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
