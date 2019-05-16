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
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;

namespace EnglishTests
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=englishtest;Integrated Security=True";

        System.Diagnostics.Stopwatch sw;

        string MenuSelect = "Learn";

        FullUserModel user;

        List<int> Word = new List<int>();

        public FirstWindow(FullUserModel user, List<int> Word)
        {
            this.Word = Word;
            this.user = user;
            InitializeComponent();
            sw = new Stopwatch();
            sw.Start();
            #region Chapter Mouse Up
            Chapter1.MouseUp  += Chapter1_MouseUp;
            Chapter2.MouseUp  += Chapter2_MouseUp;
            Chapter3.MouseUp  += Chapter3_MouseUp;
            Chapter4.MouseUp  += Chapter4_MouseUp;
            Chapter5.MouseUp  += Chapter5_MouseUp;
            Chapter6.MouseUp  += Chapter6_MouseUp;
            Chapter7.MouseUp  += Chapter7_MouseUp;
            Chapter8.MouseUp  += Chapter8_MouseUp;
            Chapter9.MouseUp  += Chapter9_MouseUp;
            Chapter10.MouseUp += Chapter10_MouseUp;
            Chapter11.MouseUp += Chapter11_MouseUp;
            Chapter12.MouseUp += Chapter12_MouseUp;
            #endregion
            #region Progress
            Learned_words_num.Content = user.Learned_words;
            Time_in_num.Content = user.Time_in;
            Completed_chapters_num.Content = user.Chapter;
            #endregion
        }

        #region Disign
        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Grid grid = sender as Grid;
            grid.Opacity = 0.8;
        }
        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid grid = sender as Grid;
            grid.Opacity = 1;
        }
        private void MenuLearing_grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MenuSelect != "Learn")
            {
                MenuLearing.Opacity = 0.5;
                MenuLearing.Visibility = Visibility.Visible;
            }
        }
        private void MenuLearing_grid_MouseLeave(object sender, MouseEventArgs e)
        {
            if (MenuSelect != "Learn")
            {
                MenuLearing.Opacity = 1;
                MenuLearing.Visibility = Visibility.Hidden;
            }
        }
        private void MenuProfile_grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MenuSelect != "Prof")
            {
                MenuProfile.Opacity = 0.5;
                MenuProfile.Visibility = Visibility.Visible;
            }
        }
        private void MenuProfile_grid_MouseLeave(object sender, MouseEventArgs e)
        {
            if (MenuSelect != "Prof")
            {
                MenuProfile.Opacity = 1;
                MenuProfile.Visibility = Visibility.Hidden;
            }
        }
        private void MenuAboutUs_grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MenuSelect != "US")
            {
                MenuAboutUs.Opacity = 0.5;
                MenuAboutUs.Visibility = Visibility.Visible;
            }
        }
        private void MenuAboutUs_grid_MouseLeave(object sender, MouseEventArgs e)
        {
            if (MenuSelect != "US")
            {
                MenuAboutUs.Opacity = 1;
                MenuAboutUs.Visibility = Visibility.Hidden;
            }
        }
        private void Dictoinary_MouseEnter(object sender, MouseEventArgs e)
        {
            Dictionary.Opacity = 0.5;
        }

        private void Dictionary_MouseLeave(object sender, MouseEventArgs e)
        {
            Dictionary.Opacity = 1;
        }
        #endregion

        #region Menu Select

        private void MenuLearing_grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MenuSelect != "Learn")
            {
                MenuSelect = "Learn";
                MenuLearing.Opacity = 1;
                MenuLearing.Visibility = Visibility.Visible;
                MenuAboutUs.Visibility = Visibility.Hidden;
                MenuProfile.Visibility = Visibility.Hidden;
                Profile_grid.Visibility = Visibility.Hidden;
                About_us_grid.Visibility = Visibility.Hidden;
                Learning_grid.Visibility = Visibility.Visible;
            }
        }
       
        private void MenuProfile_grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Time_in_num.Content = Math.Round(user.Time_in + ((sw.ElapsedMilliseconds / 1000.0) / 60),2);
            Time_in_SessionT.Content = Math.Round(((sw.ElapsedMilliseconds / 1000.0) / 60), 2);
            if (MenuSelect != "Prof")
            {
                MenuSelect = "Prof";
                MenuProfile.Opacity = 1;
                MenuLearing.Visibility = Visibility.Hidden;
                MenuAboutUs.Visibility = Visibility.Hidden;
                MenuProfile.Visibility = Visibility.Visible;
                Profile_grid.Visibility = Visibility.Visible;
                About_us_grid.Visibility = Visibility.Hidden;
                Learning_grid.Visibility = Visibility.Hidden;

            }
        }
        
        private void MenuAboutUs_grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MenuSelect != "US")
            {
                MenuSelect = "US";
                MenuAboutUs.Opacity = 1;
                MenuLearing.Visibility = Visibility.Hidden;
                MenuAboutUs.Visibility = Visibility.Visible;
                MenuProfile.Visibility = Visibility.Hidden;
                Profile_grid.Visibility = Visibility.Hidden;
                About_us_grid.Visibility = Visibility.Visible;
                Learning_grid.Visibility = Visibility.Hidden;

            }
        }
        #endregion

        #region Chapter Mouse Up
        private void Chapter1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(1,Word, user);
            test.Show();
        }
        private void Chapter2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(2, Word, user);
            test.Show();
        }
        private void Chapter3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(3, Word, user);
            test.Show();
        }
        private void Chapter4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(4, Word, user);
            test.Show();
        }
        private void Chapter5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(5, Word, user);
            test.Show();
        }
        private void Chapter6_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(6, Word, user);
            test.Show();
        }
        private void Chapter7_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(7, Word, user);
            test.Show();
        }
        private void Chapter8_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(8, Word, user);
            test.Show();
        }
        private void Chapter9_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(9, Word, user);
            test.Show();
        }
        private void Chapter10_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(10, Word, user);
            test.Show();
        }
        private void Chapter11_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(11, Word, user);
            test.Show();
        }
        private void Chapter12_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1(12, Word, user);
            test.Show();
        }
        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            sw.Stop();
            user.Time_in += Math.Round(((sw.ElapsedMilliseconds / 1000.0) / 60), 2);
            Save_Changes();
        }

        private void Save_Changes()
        {
            string sqlExpression = $"DECLARE @Last_Chapter tinyint = '{user.Chapter}', @Last_Chapter_page tinyint= '{user.SubChapter}', @Words tinyint= '{user.Learned_words}', @time_i NvarCHAR(50)= '{user.Time_in}', @id_user tinyint= '{user.Id}' exec UpdateProgress @Last_Chapter, @Last_Chapter_page, @Words, @time_i , @id_user";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private void Vocabulary_open(object sender, MouseButtonEventArgs e)
        {
            Vocabulary vocabulary = new Vocabulary(user);
            vocabulary.ShowDialog();
        }
    }
}
