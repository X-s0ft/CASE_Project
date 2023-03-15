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

using Trainer.Classes;
using Trainer.Pages;

namespace Trainer.Pages
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        IFirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "EM0CVtJwRDTSeBOANYOrBCtxJHZHj6pbEPIUez7m",
            BasePath = "https://base-7f796-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void btnCreateUser(object sender, RoutedEventArgs e)
        {
            if (PasswordGet.Text.Length < 8)
            {
                MessageBox.Show("Кол-во символов меньше 8", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    client = new FireSharp.FirebaseClient(fbc);

                    if (PasswordGet.Text != ConfirmPass.Password || string.IsNullOrEmpty(LoginGet.Text) || string.IsNullOrEmpty(ConfirmPass.Password) || string.IsNullOrEmpty(PasswordGet.Text))
                    {
                        MessageBox.Show("Что-то пошло не так", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {

                        GetDATA users = new GetDATA()
                        {
                            login = LoginGet.Text,
                            password = PasswordGet.Text,
                            easyTest = 0,
                            mediumTest = 0,
                            hardTest = 0
                        };

                        SetResponse set = client.Set(@"Users/" + LoginGet.Text, users);

                        MessageBox.Show("Успешная регистрация", "Отличнно", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
