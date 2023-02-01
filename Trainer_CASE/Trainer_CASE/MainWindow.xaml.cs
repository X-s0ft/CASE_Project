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
using System.IO;
using Trainer_CASE.Classes;
using FireSharp.Interfaces;
using FireSharp;


namespace Trainer_CASE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameApp.frame = MainFrame;
        }


        /// <summary>
        /// Method moving window
        /// </summary>
        private void Windo_moving(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        /// <summary>
        /// Method rollup window
        /// </summary>
        private void btnRollup_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }




        /// <summary>
        /// Method close window
        /// </summary>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
