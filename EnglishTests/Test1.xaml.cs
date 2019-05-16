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
        #region Chapter [n] List New
        List<Grid> ChapterList = new List<Grid>();
        List<Grid> Chapter1List = new List<Grid>();
        List<Grid> Chapter2List = new List<Grid>();
        List<Grid> Chapter3List = new List<Grid>();
        List<Grid> Chapter4List = new List<Grid>();
        List<Grid> Chapter5List = new List<Grid>();
        List<Grid> Chapter6List = new List<Grid>();
        List<Grid> Chapter7List = new List<Grid>();
        List<Grid> Chapter8List = new List<Grid>();
        List<Grid> Chapter9List = new List<Grid>();
        List<Grid> Chapter10List = new List<Grid>();
        List<Grid> Chapter11List = new List<Grid>();
        List<Grid> Chapter12List = new List<Grid>();
        #endregion

        public Test1(int Chapter)
        {
            InitializeComponent();
            #region СhapterList
            ChapterList.Add(Chapter1);
            ChapterList.Add(Chapter2);
            ChapterList.Add(Chapter3);
            ChapterList.Add(Chapter4);
            ChapterList.Add(Chapter5);
            ChapterList.Add(Chapter6);
            ChapterList.Add(Chapter7);
            ChapterList.Add(Chapter8);
            ChapterList.Add(Chapter9);
            ChapterList.Add(Chapter10);
            ChapterList.Add(Chapter11);
            ChapterList.Add(Chapter12);
            #endregion
            #region Chapter[n]List
  
            Chapter1List.Add(Theory1G);
            Chapter1List.Add(Voc1G);

            Chapter2List.Add(Theory2G);
            Chapter2List.Add(Voc2);

            Chapter3List.Add(Theory3G);
            Chapter3List.Add(Voc3);

            Chapter4List.Add(Theory4G);
            Chapter4List.Add(Voc4);

            Chapter5List.Add(Theory5G);
            Chapter5List.Add(Voc5);

            Chapter6List.Add(Theory6G);
            Chapter6List.Add(Voc6);
            
            Chapter7List.Add(Theory7G);
            Chapter7List.Add(Voc7);

            Chapter8List.Add(Theory8G);
            Chapter8List.Add(Voc8);

            Chapter9List.Add(Theory9G);
            Chapter9List.Add(Voc9);

            Chapter10List.Add(Theory10G);
            Chapter10List.Add(Voc10);

            Chapter11List.Add(Theory11G);
            Chapter11List.Add(Voc11);

            Chapter12List.Add(Theory12G);
            Chapter12List.Add(Voc12);
            #endregion
            #region Chapter Visibility
            foreach (Grid a in ChapterList)
            {
                a.Visibility = Visibility.Hidden;
            }

            if (Chapter == 1)
            {
                Chapter1.Visibility = Visibility.Visible;
            }
            else if (Chapter == 2)
            {
                Chapter2.Visibility = Visibility.Visible;
            }
            else if (Chapter == 3)
            {
                Chapter3.Visibility = Visibility.Visible;
            }
            else if (Chapter == 4)
            {
                Chapter4.Visibility = Visibility.Visible;
            }
            else if (Chapter == 5)
            {
                Chapter5.Visibility = Visibility.Visible;
            }
            else if (Chapter == 6)
            {
                Chapter6.Visibility = Visibility.Visible;
            }
            else if (Chapter == 7)
            {
                Chapter7.Visibility = Visibility.Visible;
            }
            else if (Chapter == 8)
            {
                Chapter8.Visibility = Visibility.Visible;
            }
            else if (Chapter == 9)
            {
                Chapter9.Visibility = Visibility.Visible;
            }
            else if (Chapter == 10)
            {
                Chapter10.Visibility = Visibility.Visible;
            }
            else if (Chapter == 11)
            {
                Chapter11.Visibility = Visibility.Visible;
            }
            else if (Chapter == 12)
            {
                Chapter12.Visibility = Visibility.Visible;
            }
            #endregion
        }

        #region Chapter1
        private void Btn0_ch1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter1List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter1List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter1List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter1List[1].Visibility = Visibility.Visible;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch1.IsEnabled = true;
            foreach (Grid a in Chapter1List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter1List[1].Visibility = Visibility.Visible;
        }
        #endregion
        #region Chapter2
        private void Btn0_ch2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter2List[0].Visibility = Visibility.Visible;
        }
        
        private void Btn1_ch2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter2List[1].Visibility = Visibility.Visible;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch2.IsEnabled = true;
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter2List[1].Visibility = Visibility.Visible;
        }
        #endregion
        #region Chapter3
        private void Btn0_ch3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter3List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter3List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter3List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter3List[1].Visibility = Visibility.Visible;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch3.IsEnabled = true;
            foreach (Grid a in Chapter3List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter3List[1].Visibility = Visibility.Visible;
        }
        #endregion
        #region Chapter4
        private void Btn0_ch4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter4List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter4List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter4List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter4List[1].Visibility = Visibility.Visible;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch4.IsEnabled = true;
            foreach (Grid a in Chapter4List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter4List[1].Visibility = Visibility.Visible;
        }
        #endregion 
        #region Chapter5
        private void Btn0_ch5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter5List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter5List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter5List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter5List[1].Visibility = Visibility.Visible;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch5.IsEnabled = true;
            foreach (Grid a in Chapter5List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter5List[1].Visibility = Visibility.Visible;
        }
#endregion
        #region Chapter6
        private void Btn0_ch6_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter6List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter6List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch6_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter6List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter6List[1].Visibility = Visibility.Visible;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch6.IsEnabled = true;
            foreach (Grid a in Chapter6List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter6List[1].Visibility = Visibility.Visible;
        }
        #endregion
        #region Chapter7
        private void Btn0_ch7_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter7List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter7List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch7_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter7List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter7List[1].Visibility = Visibility.Visible;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch7.IsEnabled = true;
            foreach (Grid a in Chapter7List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter7List[1].Visibility = Visibility.Visible;
        }
#endregion 
        #region Chapter8
        private void Btn0_ch8_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter8List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter8List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch8_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter8List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter8List[1].Visibility = Visibility.Visible;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch8.IsEnabled = true;
            foreach (Grid a in Chapter8List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter8List[1].Visibility = Visibility.Visible;
        }
#endregion
        #region Chapter9
        private void Btn0_ch9_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter9List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter9List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch9_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter9List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter9List[1].Visibility = Visibility.Visible;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch9.IsEnabled = true;
            foreach (Grid a in Chapter9List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter9List[1].Visibility = Visibility.Visible;
        }
#endregion 
        #region Chapter10
        private void Btn0_ch10_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter10List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter10List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch10_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter10List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter10List[1].Visibility = Visibility.Visible;
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch10.IsEnabled = true;
            foreach (Grid a in Chapter10List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter10List[1].Visibility = Visibility.Visible;
        }
#endregion
        #region Chapter11
        private void Btn0_ch11_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter11List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter11List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch11_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter11List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter11List[1].Visibility = Visibility.Visible;
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch11.IsEnabled = true;
            foreach (Grid a in Chapter11List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter11List[1].Visibility = Visibility.Visible;
        }
        #endregion
        #region Chapter12
        private void Btn0_ch12_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter12List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter12List[0].Visibility = Visibility.Visible;
        }

        private void Btn1_ch12_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter12List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter12List[1].Visibility = Visibility.Visible;
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            Btn1_ch12.IsEnabled = true;
            foreach (Grid a in Chapter12List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Chapter12List[1].Visibility = Visibility.Visible;
        }
#endregion

    }
}
