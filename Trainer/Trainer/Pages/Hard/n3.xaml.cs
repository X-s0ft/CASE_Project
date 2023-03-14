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
using System.Windows.Threading;

namespace Trainer.Pages.Hard
{
    /// <summary>
    /// Interaction logic for n3.xaml
    /// </summary>
    public partial class n3 : Page
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        public n3()
        {
            InitializeComponent();
            InitializeComponent();

            _time = TimeSpan.FromSeconds(30);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
            timer();
        }

        

   

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            if (Final.IsChecked == true)
            {
                App.Current.Resources["Hn5"] = 1;
            }
            else
            {
                App.Current.Resources["Hn5"] = 0;
            }

            this.NavigationService.Navigate(new Final());
        }

        public async void timer()
        {
            await Task.Delay(30000);
            App.Current.Resources["Hn5"] = 0;
            this.NavigationService.Navigate(new Final());
        }
    }
}
