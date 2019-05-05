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
using System.Configuration;
using System.Data.SqlClient;

namespace EnglishTests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = @"Data Source=.\NAMEALINA;Initial Catalog=englishtest;Integrated Security=True";
        object id;
        public MainWindow()
        {
           
            InitializeComponent();
          
        }

        
        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
        string buffer;
        private void Text_box_Login_text_GotFocus(object sender, RoutedEventArgs e) //очистка поля
        {
                TextBox text = sender as TextBox;
                buffer = text.Text;
                if (text.Text == buffer)
                    text.Text = "";
          
        }

        private void Text_box_Login_text_LostFocus(object sender, RoutedEventArgs e) //возврат если поле пустое
        {
            TextBox text = sender as TextBox;
            if (text.Text == "")
                text.Text = buffer;
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //FirstWindow fir = new FirstWindow();
            //fir.Show();
            //this.Close();
        }

        private void Grid_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Alarm.Visibility = Visibility.Hidden;
            string sqlExpression = $"Select Id from Users where Login_text like '{LoginT.Text}' and Password_text like '{PassT.Text}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        id = reader.GetValue(0);
                    }
                    FirstWindow fir = new FirstWindow(id);
                    fir.Show();
                    this.Close();
                }
                else
                {
                    Alarm.Visibility = Visibility.Visible;
                }
                reader.Close();
            }
            
        }
    }
}
