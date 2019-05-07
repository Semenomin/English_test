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
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {
        List<ScrollViewer> scrollViewers = new List<ScrollViewer>();
        
        public Test1()
        {
            InitializeComponent();
            scrollViewers.Add(Theory1);
            scrollViewers.Add(Theory2);
            scrollViewers.Add(Theory3);
            scrollViewers.Add(Theory4);
            scrollViewers.Add(Theory5);
            scrollViewers.Add(Theory6);
        }

        private void lbl1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);
        }

        private void txtTarget_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
