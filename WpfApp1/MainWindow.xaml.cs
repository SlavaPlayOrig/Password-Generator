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

namespace Генератор_паролей
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int pass_length_int;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Txt1.Text != "")
            {
                Txt1_l.Visibility = Visibility.Hidden;

                try
                {
                    pass_length_int = Convert.ToInt32(Txt1.Text);
                }
                catch
                {
                    MessageBox.Show("Вводите число!");
                }
            }
            else
            {
                Txt1_l.Visibility = Visibility.Visible;
            }
        }

        private void Txt2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Txt2.Text != "")
            {
                Txt2_l.Visibility = Visibility.Hidden;
            }
            else
            {
                Txt2_l.Visibility = Visibility.Visible;
            }
        }
        private void But_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Txt1.Text != "")
                {
                    Random rnd = new Random();
                    string symbols = Txt2.Text;
                    string prs = "";
                    int i = 0;
                    while (i < pass_length_int)
                    {
                        char psi = Txt2.Text[rnd.Next(symbols.Length)];
                        prs += "" + psi;
                        i++;
                    }
                    Result.Text = prs;
                }
                else MessageBox.Show("Не указана длина строки!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
