using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Windows;
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
    /// Логика взаимодействия для LengthWindow.xaml
    /// </summary>
    public partial class LengthWindow : Window
    {
        string languag;
        public LengthWindow()
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
                if (languag == "ru-RU")
                {
                    if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Километры")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Мили")
                            TextBox2.Text = ConvertWeight.Weight.KilometersToMiles(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Футы")
                            TextBox2.Text = ConvertWeight.Weight.KilometersToFoots(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Метры")
                            TextBox2.Text = ConvertWeight.Weight.KilometersToMeters(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }

                    else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Метры")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Мили")
                            TextBox2.Text = ConvertWeight.Weight.MetersToMiles(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Футы")
                            TextBox2.Text = ConvertWeight.Weight.MetersToFoots(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Километры")
                            TextBox2.Text = ConvertWeight.Weight.MetersToKilometers(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }

                    else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Футы")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Мили")
                            TextBox2.Text = ConvertWeight.Weight.FootsToMiles(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Метры")
                            TextBox2.Text = ConvertWeight.Weight.FootsToMeters(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Километры")
                            TextBox2.Text = ConvertWeight.Weight.FootsToKilometers(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }

                    else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Мили")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() ==
                        "Футы")
                            TextBox2.Text = ConvertWeight.Weight.MilesToFoots(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Метры")
                            TextBox2.Text = ConvertWeight.Weight.MilesToMeters(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Километры")
                            TextBox2.Text = ConvertWeight.Weight.MilesToKilometers(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }

                    //else TextBox2.Text = TextBox1.Text;
                }

                if (languag == "en-US")
                {
                    if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Kilometers")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Miles")
                            TextBox2.Text = ConvertWeight.Weight.KilometersToMiles(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Foots")
                            TextBox2.Text = ConvertWeight.Weight.KilometersToFoots(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Meters")
                            TextBox2.Text = ConvertWeight.Weight.KilometersToMeters(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }

                    else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Meters")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Miles")
                            TextBox2.Text = ConvertWeight.Weight.MetersToMiles(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Foots")
                            TextBox2.Text = ConvertWeight.Weight.MetersToFoots(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Kilometers")
                            TextBox2.Text = ConvertWeight.Weight.MetersToKilometers(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }

                    else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Foots")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Miles")
                            TextBox2.Text = ConvertWeight.Weight.FootsToMiles(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Meters")
                            TextBox2.Text = ConvertWeight.Weight.FootsToMeters(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Kilometers")
                            TextBox2.Text = ConvertWeight.Weight.FootsToKilometers(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }

                    else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "Miles")
                    {
                        if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Foots")
                            TextBox2.Text = ConvertWeight.Weight.MilesToFoots(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Meters")
                            TextBox2.Text = ConvertWeight.Weight.MilesToMeters(Convert.ToDouble(TextBox1.Text)).ToString();
                        else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "Kilometers")
                            TextBox2.Text = ConvertWeight.Weight.MilesToKilometers(Convert.ToDouble(TextBox1.Text)).ToString();
                        else TextBox2.Text = TextBox1.Text;
                    }
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