using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Controls.Primitives;
using System.Globalization;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Rate;

namespace WpfER
{
    /// <summary>
    /// Логика взаимодействия для RateWindow.xaml
    /// </summary>
    public partial class RateWindow : Window
    {
        string languag;
        public RateWindow()
        {
            InitializeComponent();
            languag = "ru-RU";
            Parsing.XmlToList();
            this.TextBox1.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);

        }

        //свернуть окно
        private void WinMin(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        //закрыть окно
        private void WinClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //ввод цифр с кнопок
        private void Numbers(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += ((Button)sender).Name[1];
        }

        //смена языка переключателем
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
        //ввод только цифр
        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Char.IsNumber(e.Text, 0)) && (e.Text != ",")) e.Handled = true;
            else if ((e.Text == ",") && ((TextBox1.Text.IndexOf(",") != -1) || (TextBox1.Text == "")))
                e.Handled = true;
        }

        private void ClearBox(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
        }

        private void CalcCurrency(object sender, RoutedEventArgs e)
        {
            try
            {
                string Temp1 = (ComboBox1.SelectedItem as ComboBoxItem).Content.ToString().Substring(0, 3);
                string Temp2 = (ComboBox2.SelectedItem as ComboBoxItem).Content.ToString().Substring(0, 3);

                CalculatingExchangeRate.ChoiseValute(Temp1, Temp2);
                TextBox2.Text = CalculatingExchangeRate.Calculation(Convert.ToDouble(TextBox1.Text)).ToString();
            }
            catch (NullReferenceException)
            {
                WpfER.Error error = new WpfER.Error();
                error.Show();
            }
        }
    }
}
