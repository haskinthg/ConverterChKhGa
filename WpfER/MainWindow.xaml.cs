using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string languag;
        public MainWindow()
        {

            InitializeComponent();
        }

        private void WinMin(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void WinClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void RateClick(object sender, RoutedEventArgs e)
        {
            RateWindow RateWindow = new RateWindow();
            RateWindow.Show();
        }

        private void ChangeLang(object sender, RoutedEventArgs e)
        {
            if (((ToggleButton)sender).IsChecked == true)
                languag = "ru-RU";
            else languag = "en-US";
            if (languag != null)
            {
                CultureInfo lang = new CultureInfo(languag);
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            AboutApp aboutApp = new AboutApp();
            aboutApp.Show();
        }


        private void LenthClick(object sender, RoutedEventArgs e)
        {
            LengthWindow lengthWindow = new LengthWindow();
            lengthWindow.Show();
        }

        private void TempClick(object sender, RoutedEventArgs e)
        {
            TempWindow tempWindow = new TempWindow();
            tempWindow.Show();
        }
    }
}
