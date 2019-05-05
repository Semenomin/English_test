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

namespace EnglishTests
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow(object id)
        {
            InitializeComponent();
        }
        string MenuSelect = "Learn";
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
        private void MenuProfile_grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
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

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Test1 test = new Test1();
            test.Show();
        }
    }
}
