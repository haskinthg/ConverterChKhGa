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

        //сворачивание окна
        private void WinMin(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //закрытие окна
        private void WinClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //ввод цифр с кнопок
        private void Numbers(object sender, RoutedEventArgs e)
        {

            TextBox1.Text += ((Button)sender).Name[1];
        }

        //смена языка | если вкл кнопка, то рус, если выкл, то англ
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
        //ввод только цифр и запятой
        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Char.IsNumber(e.Text, 0)) && (e.Text != ",")) e.Handled = true;
            else if ((e.Text == ",") && ((TextBox1.Text.IndexOf(",") != -1) || (TextBox1.Text == "")))
                e.Handled = true;

        }

        // очистка полей текстбоксов
        private void ClearBox(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
        }


        //метод для расчета результата
        private void ResultClick(object sender, RoutedEventArgs e)
        {
            //обработчик исклчений (если вызывается исключение, то идет перенаправление в блок catch)
            try
            {
                //проверка значения первого комбобокса
                if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "C")
                {
                    // проверка значения второго комбобокса 
                    if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "F")
                    TextBox2.Text = ConvertTemperature.ConvertationTemp.CtoF(Convert.ToDouble(TextBox1.Text)).ToString();
                    else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "K")
                    TextBox2.Text = ConvertTemperature.ConvertationTemp.CtoK(Convert.ToDouble(TextBox1.Text)).ToString();
                    else TextBox2.Text = TextBox1.Text;
                }

                //проверка значения первого комбобокса
                else if ((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "F")
                {
                    // проверка значения второго комбобокса 
                    if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "C")
                    TextBox2.Text = ConvertTemperature.ConvertationTemp.FtoC(Convert.ToDouble(TextBox1.Text)).ToString();
                    else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "K")
                        TextBox2.Text = ConvertTemperature.ConvertationTemp.FtoK(Convert.ToDouble(TextBox1.Text)).ToString();
                    else TextBox2.Text = TextBox1.Text;
                }

                //проверка значения первого комбобокса
                else if (((ComboBox1.SelectedItem as ComboBoxItem).Content.ToString() == "K"))
                {
                    // проверка значения второго комбобокса 
                    if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "C")
                        TextBox2.Text = ConvertTemperature.ConvertationTemp.KtoC(Convert.ToDouble(TextBox1.Text)).ToString();
                    else if ((ComboBox2.SelectedItem as ComboBoxItem).Content.ToString() == "F")
                        TextBox2.Text = ConvertTemperature.ConvertationTemp.KtoF(Convert.ToDouble(TextBox1.Text)).ToString();
                    else TextBox2.Text = TextBox1.Text;
                }

                
            }
            // при исключении вызывается окно ошибки
            catch (NullReferenceException)
            {
                WpfER.Error error = new WpfER.Error();
                error.Show();
            }
        }
    }
}
