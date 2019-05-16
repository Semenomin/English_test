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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace EnglishTests
{
    /// <summary>
    /// Логика взаимодействия для Vocabulary.xaml
    /// </summary>
    public partial class Vocabulary : Window
    {
        string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=englishtest;Integrated Security=True";
        public Vocabulary(FullUserModel user)
        {
            InitializeComponent();
            FillGrid(user);
        }

        public void FillGrid(FullUserModel user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"DECLARE @id tinyint = '{user.Id}' exec GetDictionary @id";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    List<Dictionary> listincome = new List<Dictionary>();
                    while (sqlDataReader.Read())
                    {
                        Dictionary income = new Dictionary()
                        {
                            Word = sqlDataReader.GetValue(3),
                            Trans = sqlDataReader.GetValue(4),
                            Good = sqlDataReader.GetValue(5),
                            Bad = sqlDataReader.GetValue(6)
                        };
                        listincome.Add(income);
                    }
                    Data.ItemsSource = listincome;
                }
                else
                {
                    MessageBox.Show("No strings!");
                }
            }
        }
    }
}
