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
using System.Data.SqlClient;
using System.Windows.Shapes;

namespace EnglishTests
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        string connectionString = @"Data Source=.\NAMEALINA;Initial Catalog=englishtest;Integrated Security=True";
        public Register()
        {
            InitializeComponent();
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

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Alarma1.Visibility = Visibility.Hidden;
            Alarma2.Visibility = Visibility.Hidden;
            bool good = true;
            string sqlExpression1 = $"INSERT INTO Users (Login_text,Password_text,Name_user) VALUES ('{LoginT.Text}', '{PassT.Text}', '{NameT.Text}')";
            string sqlExpression2= $"Select Login_text from Users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression2, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        if ((string)reader.GetValue(0) == LoginT.Text)
                        {
                            Alarma1.Visibility = Visibility.Visible;
                            good = false;
                            break;
                        };
                        good = true;
                    }
                }
                reader.Close();
                if (good)
                {
                    if (PassT.Text != RPassT.Text)
                    {
                        Alarma2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        SqlCommand command2 = new SqlCommand(sqlExpression1, connection);
                        int number = command2.ExecuteNonQuery();
                        this.Close();
                    }
                }
                
            }
        }
    }
}
