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
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {
        List<int> Word_id = new List<int>();
        List<Grid> VocabularyList = new List<Grid>();
        FullUserModel User;
        int Max_id;
        int Chapter_now;
        string connectionString = @"Data Source=.\SQLSERVER;Initial Catalog=englishtest;Integrated Security=True";
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

        public Test1(int Chapter,List<int> word, FullUserModel user)
        {
            Chapter_now = Chapter;
            this.User = user;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $"use englishtest Select Count(id) from Vocabulary";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) // если есть данные
                {
                    Max_id = int.Parse(reader.GetValue(0).ToString());
                }
                reader.Close();
            } //Get Max Id Value
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression2 = $"Select * from User_vocabulary";
                SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.HasRows) // если есть данные
                {
                    while (reader2.Read())
                    {
                        Word_id.Add(int.Parse(reader2.GetValue(2).ToString()));
                    }
                }
                reader2.Close();
            }
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
            Chapter2List.Add(Theory2G);
            Chapter3List.Add(Theory3G);
            Chapter4List.Add(Theory4G);
            Chapter5List.Add(Theory5G);
            Chapter6List.Add(Theory6G);
            Chapter7List.Add(Theory7G);
            Chapter8List.Add(Theory8G);
            Chapter9List.Add(Theory9G);
            Chapter10List.Add(Theory10G);
            Chapter11List.Add(Theory11G);
            Chapter12List.Add(Theory12G);
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

        #region work with vocabulary
        private void Open_Vocabulary(object sender, RoutedEventArgs e)
        {
            if (Chapter_now == 1)
            {
                Btn1_ch1.IsEnabled = true;
                Chapter1List.Add(Vocabulary);
            }
            if (Chapter_now == 2)
            {
                Chapter2List.Add(Vocabulary);
                Btn1_ch2.IsEnabled = true;
            }
            if (Chapter_now == 3)
            {
                Chapter3List.Add(Vocabulary);
                Btn1_ch3.IsEnabled = true;
            }
            if (Chapter_now == 4)
            {
                Chapter4List.Add(Vocabulary);
                Btn1_ch4.IsEnabled = true;
            }
            if (Chapter_now == 5)
            {
                Chapter5List.Add(Vocabulary);
                Btn1_ch5.IsEnabled = true;
            }
            if (Chapter_now == 6)
            {
                Chapter6List.Add(Vocabulary);
                Btn1_ch6.IsEnabled = true;
            }
            if (Chapter_now == 7)
            {
                Chapter7List.Add(Vocabulary);
                Btn1_ch7.IsEnabled = true;
            }
            if (Chapter_now == 8)
            {
                Chapter8List.Add(Vocabulary);
                Btn1_ch8.IsEnabled = true;
            }
            if (Chapter_now == 9)
            {
                Chapter9List.Add(Vocabulary);
                Btn1_ch9.IsEnabled = true;
            }
            if (Chapter_now == 10)
            {
                Chapter10List.Add(Vocabulary);
                Btn1_ch10.IsEnabled = true;
            }
            if (Chapter_now == 11)
            {
                Chapter11List.Add(Vocabulary);
                Btn1_ch11.IsEnabled = true;
            }
            if (Chapter_now == 12)
            {
                Chapter12List.Add(Vocabulary);
                Btn1_ch12.IsEnabled = true;
            }
            foreach (Grid a in Chapter1List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter3List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter4List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter5List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter6List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter7List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter8List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter9List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter10List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter11List)
            {
                a.Visibility = Visibility.Hidden;
            }
            foreach (Grid a in Chapter12List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Create_Vocabulary();
            Vocabulary.Visibility = Visibility.Visible;
            Copy_Vocabulary();

        }

        private void Create_Vocabulary()
        {
            Random random = new Random();
            int i=1;
            while (i < 7)
            {
                bool breaker = false;
                int NewRandom = random.Next(1, Max_id);
                foreach (int a in Word_id)
                {
                    if (a == NewRandom)
                    {
                        breaker = true;
                        break;
                    }
                }
                if (breaker)
                {

                }
                else
                {
                    Word_id.Add(NewRandom);
                    string sqlExpression = $"Select Word,Trans from Vocabulary where Id='{NewRandom}'";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read()) // построчно считываем данные
                            {
                                if (i == 1)
                                {
                                    Word1.FontWeight = FontWeights.Bold;
                                    Word1.Text = reader.GetValue(0).ToString() + " - ";
                                    Word1.FontWeight = FontWeights.Normal;
                                    Word1.Text += reader.GetValue(1).ToString();
                                }
                                if (i == 2)
                                {
                                    Word2.FontWeight = FontWeights.Bold;
                                    Word2.Text = reader.GetValue(0).ToString() + " - ";
                                    Word2.FontWeight = FontWeights.Normal;
                                    Word2.Text += reader.GetValue(1).ToString();
                                }
                                if (i == 3)
                                {
                                    Word3.FontWeight = FontWeights.Bold;
                                    Word3.Text = reader.GetValue(0).ToString() + " - ";
                                    Word3.FontWeight = FontWeights.Normal;
                                    Word3.Text += reader.GetValue(1).ToString();
                                }
                                if (i == 4)
                                {
                                    Word4.FontWeight = FontWeights.Bold;
                                    Word4.Text = reader.GetValue(0).ToString() + " - ";
                                    Word4.FontWeight = FontWeights.Normal;
                                    Word4.Text += reader.GetValue(1).ToString();
                                }
                                if (i == 5)
                                {
                                    Word5.FontWeight = FontWeights.Bold;
                                    Word5.Text = reader.GetValue(0).ToString() + " - ";
                                    Word5.FontWeight = FontWeights.Normal;
                                    Word5.Text += reader.GetValue(1).ToString();
                                }
                                if (i == 6)
                                {
                                    Word6.FontWeight = FontWeights.Bold;
                                    Word6.Text = reader.GetValue(0).ToString() + " - ";
                                    Word6.FontWeight = FontWeights.Normal;
                                    Word6.Text += reader.GetValue(1).ToString();
                                }
                            }
                        }
                        reader.Close();
                        i++;
                    }
                }
                 
            }
        }

        private void Copy_Vocabulary()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $"TRUNCATE TABLE user_vocabulary";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            foreach (int a in Word_id)
            {
                    VocabularyModel model = new VocabularyModel();
                    model.Id = a;
                    model.Id_user = User.Id;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlExpression = $"use englishtest Select * from Vocabulary where Id = '{model.Id}'";
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read())
                            {
                                model.Word = reader.GetValue(1).ToString();
                                model.Trans = reader.GetValue(2).ToString();
                            }
                        }
                        reader.Close();
                        string sqlExpression1 = $"INSERT INTO User_vocabulary (Id_user,Id_Voc,Word,Trans) values ('{model.Id_user}','{model.Id}','{model.Word}','{model.Trans}')";
                        SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                        command1.ExecuteNonQuery();
                    }   
            }
        }
        #endregion

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
        #endregion  
    }
}
