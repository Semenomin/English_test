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
    /// Логика взаимодействия для MasterWindow.xaml
    /// </summary>
    public partial class MasterWindow : Window
    {
        string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=englishtest;Integrated Security=True";

        public MasterWindow()
        {
            InitializeComponent();
        }

        private void Add_words(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidateTextAdd();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlExpression = $"DECLARE @word NvarCHAR(50) = '{Add_word.Text}',@Trans NvarCHAR(50) = '{Add_Trans.Text}' exec AddWordInVocabulary @word ,@Trans";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Add Completed");

                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void RestorePassword(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidateTextRestore();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlExpression = $"DECLARE @Login NvarCHAR(50) = '{Restore_Login.Text}' exec RestorePassword @Login";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Restore_Password.Text = reader.GetValue(0).ToString();
                            MessageBox.Show("Restore Completed");
                        }
                    }
                    else throw new Exception("Invalid Login");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ResetProgress(object sender, RoutedEventArgs e)
        {
            try
            {
                ValidateTextReset();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlExpression = $"DECLARE @login NvarCHAR(50) = '{Reset_Login.Text}' exec ResetProgress @Login";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Reset Completed");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ValidateTextAdd()
        {
            if (Add_word.Text == "" || Add_Trans.Text == "")
            {
                throw new Exception("Fill all!!");
            }
        }

        private void ValidateTextRestore()
        {
            if (Restore_Login.Text == "")
            {
                throw new Exception("Fill all!!");
            }
        }

        private void ValidateTextReset()
        {
            if (Reset_Login.Text == "")
            {
                throw new Exception("Fill all!!");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
