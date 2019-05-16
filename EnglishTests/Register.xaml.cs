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
using System.Threading;

namespace EnglishTests
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=englishtest;Integrated Security=True";

        public Register()
        {
            InitializeComponent();
        }

        string buffer;

        #region Disign
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
        #endregion

        private void Register_button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                RegistrationModel model = GetModel();
                ValidateInputs(model);
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        private RegistrationModel GetModel()
        {
            return new RegistrationModel
            {
                Username = LoginT.Text,
                Name = NameT.Text,
                Password = PassT.Text,
                RepPassword = RPassT.Text
            };
        }

        private void ValidateInputs(RegistrationModel reg)
        {
            string sqlExpression1 = $"DECLARE @user nvarchar(50) ='{reg.Username}' exec ValidateUser @user";

            string sqlExpression2 = $"DECLARE @user nvarchar(50) ='{reg.Username}',@password nvarchar(50) = '{reg.Password}', @name nvarchar(50) = '{reg.Name}' exec CreateUser @user, @password, @name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    throw new Exception("Change login!!!");
                }
                else
                {
                    if (reg.Password != reg.RepPassword)
                    {
                        throw new Exception("Passwords are not the same!!!");
                    }
                    else
                    {
                        reader.Close();
                        SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                        int number = command2.ExecuteNonQuery();
                        Create_progress(reg);
                        this.Close();
                    }
                }
            }
        }

        private void Create_progress(RegistrationModel reg)
        {
            string sqlExpression = $"DECLARE @Login nvarchar(50) ='{reg.Username}' exec GetLogins @Login";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        reg.Id = reader.GetValue(0).ToString();
                    }
                }
                reader.Close();
                string sqlExpression1 = $"DECLARE @ID tinyint ='{reg.Id}' exec CreateProgress @id";
                SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                command1.ExecuteNonQuery();
            }
        }
    }
}
