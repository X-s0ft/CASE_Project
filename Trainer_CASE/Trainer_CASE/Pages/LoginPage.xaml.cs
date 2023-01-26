using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
using Trainer_CASE.Classes;

namespace Trainer_CASE.Resourses.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        IFirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "EM0CVtJwRDTSeBOANYOrBCtxJHZHj6pbEPIUez7m",
            BasePath = "https://base-7f796-default-rtdb.firebaseio.com/"
        };
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FirebaseClient client;
            client = new FirebaseClient(fbc);
            if (string.IsNullOrWhiteSpace(LoginTxb.Text) && string.IsNullOrWhiteSpace(Pswb.Password))
            {
                MessageBox.Show("Данные не заполнены");
            }
            else
            {
                try
                {
                    FirebaseResponse response = await client.GetAsync(@"0/Users/" + LoginTxb.Text);
                    GetDATA dATA = response.ResultAs<GetDATA>();
                    GetDATA getDATA = new GetDATA()
                    {
                        login = LoginTxb.Text,
                        password = Pswb.Password
                    };
                    if(GetDATA.IsEqual(dATA, getDATA))
                    {
                        FrameApp.frame.Navigate(new MainPage());
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
