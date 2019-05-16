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
        List<int> Word_id = new List<int>();

        string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=englishtest;Integrated Security=True";

        string buffer;

        FullUserModel User;

        public MainWindow()
        {
           
            InitializeComponent();
          
        }

        private void Register_button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
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
        private void LogIn_button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                UserModel model = GetModel();
                ValidateInputs(model);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private UserModel GetModel()
        {
            return new UserModel
            {
                Username = LoginT.Text,
                Password = PassT.Text
            };
        }
        private void ValidateInputs(UserModel use)
        {
            string sqlExpression = $"DECLARE @Login nvarchar(50) ='{use.Username}', @password nvarchar(50) ='{use.Password}'  exec LogInUser @Login, @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader  = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                        while (reader.Read()) // построчно считываем данные
                        {
                            User = ConnectUser((byte)reader.GetValue(0), (string)reader.GetValue(1));
                        }
                        FirstWindow fir = new FirstWindow(User,Word_id);
                        fir.Show();
                        this.Close();
                }
                else
                {
                    throw new Exception("Invalid Login or Password");
                }
                reader.Close();
            }
        }
        private FullUserModel ConnectUser(int id, string name)
        {
            string sqlExpression1 = $"DECLARE @id tinyint = '{id}' exec GetProgress @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        return new FullUserModel
                        {
                            Learned_words = (byte)reader.GetValue(3),
                            Time_in = double.Parse(reader.GetValue(4).ToString()),
                            Chapter = (byte)reader.GetValue(1),
                            SubChapter = (byte)reader.GetValue(2),
                            Id = id,
                            Name = name
                        };
                    }
                }
                else
                {
                    return null;
                    throw new Exception("Total Crash!!!");
                }
                reader.Close();
            }
            return null;

        }
    }
}
