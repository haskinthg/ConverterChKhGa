using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfER
{
    /// <summary>
    /// Логика взаимодействия для TempWindow.xaml
    /// </summary>
    public partial class TempWindow : Window
    {
        string languag;
        public TempWindow()
        {
            InitializeComponent();
            languag = "ru-RU";
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



        private void ResultClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (((ComboBox1.SelectedItem as ComboBoxItem).Content != null) & ((ComboBox2.SelectedItem as ComboBoxItem).Content != null))

                if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "C")
                {

                    if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "F")
                    TextBox2.Text = ConvertTemperature.ConvertationTemp.CtoF(Convert.ToDouble(TextBox1.Text)).ToString();
                    else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "K")
                    TextBox2.Text = ConvertTemperature.ConvertationTemp.CtoK(Convert.ToDouble(TextBox1.Text)).ToString();
                    else TextBox2.Text = TextBox1.Text;
                }

                else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "F")
                {
                    if((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "C")
                    TextBox2.Text = ConvertTemperature.ConvertationTemp.FtoC(Convert.ToDouble(TextBox1.Text)).ToString();
                    else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "K")
                        TextBox2.Text = ConvertTemperature.ConvertationTemp.FtoK(Convert.ToDouble(TextBox1.Text)).ToString();
                    else TextBox2.Text = TextBox1.Text;
                }

                else if (((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "K"))
                {
                    if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "C")
                        TextBox2.Text = ConvertTemperature.ConvertationTemp.KtoC(Convert.ToDouble(TextBox1.Text)).ToString();
                    else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "F")
                        TextBox2.Text = ConvertTemperature.ConvertationTemp.KtoF(Convert.ToDouble(TextBox1.Text)).ToString();
                    else TextBox2.Text = TextBox1.Text;
                }

                
            }
            catch (NullReferenceException)
            {
                WpfER.Error error = new WpfER.Error();
                error.Show();
            }
        }
    }
}
