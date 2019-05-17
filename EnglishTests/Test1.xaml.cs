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
        List<int> goodList = new List<int>();
        List<int> badList = new List<int>();
        List<Grid> VocabularyList = new List<Grid>();
        List<TextBlock> textBlocks = new List<TextBlock>();
        List<ComboBox> ComboBoxes = new List<ComboBox>();
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
                string sqlExpression = $"exec GetCountWords";
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
                string sqlExpression2 = $"Declare @id tinyint = {user.Id} exec GetUserWords @id";
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
            #region Text Blocks
            textBlocks.Add(Test_word1);
            textBlocks.Add(Test_word2);
            textBlocks.Add(Test_word3);
            #endregion
            #region ComboBoxes
            ComboBoxes.Add(Answer1);
            ComboBoxes.Add(Answer2);
            ComboBoxes.Add(Answer3);
            #endregion
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
                    string sqlExpression = $"DECLARE @id tinyint ='{NewRandom}' exec GetRandomWord @id";
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
                string sqlExpression1 = $"Select good,bad from User_vocabulary where Id_User='{User.Id}'";
                SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.HasRows) // если есть данные
                {
                    while (reader1.Read())
                    {
                        goodList.Add(int.Parse(reader1.GetValue(0).ToString()));
                        badList.Add(int.Parse(reader1.GetValue(1).ToString()));
                    }
                }
                reader1.Close();






                string sqlExpression = $"DECLARE @id tinyint ='{User.Id}' exec ClearVacabulary @id";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            for (int i = 0; i < Word_id.Count; i++)
            {

                VocabularyModel model = new VocabularyModel();
                model.Id = Word_id[i];
                model.Id_user = User.Id;
                if (i < Word_id.Count - 6)
                {
                    model.Bad = badList[i];
                    model.Goood = goodList[i];
                }
                else
                {
                    model.Bad = 0;
                    model.Goood = 0;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlExpression = $"DECLARE @id tinyint ='{model.Id}' exec GetWord @id";
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

                    string sqlExpression1 = $"DECLARE @Id_user int ='{model.Id_user}', @Id_Voc int='{model.Id}', @Word NvarCHAR(50)='{model.Word}', @Trans NvarCHAR(50)='{model.Trans}',@good tinyint = '{model.Goood}', @bad tinyint = '{model.Bad}' exec CreateVocabulary @Id_user, @Id_Voc, @Word, @Trans,@good,@bad";
                    SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                    command1.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region Work with Vocabulary Test

        private void OpenVocabularyTest(object sender, RoutedEventArgs e)
        {
            if (Chapter_now == 1)
            {
                Btn2_ch1.IsEnabled = true;
                Chapter1List.Add(Vocabulary_Test);
            }
            if (Chapter_now == 2)
            {
                Chapter2List.Add(Vocabulary_Test);
                Btn2_ch2.IsEnabled = true;
            }
            if (Chapter_now == 3)
            {
                Chapter3List.Add(Vocabulary_Test);
                Btn2_ch3.IsEnabled = true;
            }
            if (Chapter_now == 4)
            {
                Chapter4List.Add(Vocabulary_Test);
                Btn2_ch4.IsEnabled = true;
            }
            if (Chapter_now == 5)
            {
                Chapter5List.Add(Vocabulary_Test);
                Btn2_ch5.IsEnabled = true;
            }
            if (Chapter_now == 6)
            {
                Chapter6List.Add(Vocabulary_Test);
                Btn2_ch6.IsEnabled = true;
            }
            if (Chapter_now == 7)
            {
                Chapter7List.Add(Vocabulary_Test);
                Btn2_ch7.IsEnabled = true;
            }
            if (Chapter_now == 8)
            {
                Chapter8List.Add(Vocabulary_Test);
                Btn2_ch8.IsEnabled = true;
            }
            if (Chapter_now == 9)
            {
                Chapter9List.Add(Vocabulary_Test);
                Btn2_ch9.IsEnabled = true;
            }
            if (Chapter_now == 10)
            {
                Chapter10List.Add(Vocabulary_Test);
                Btn2_ch10.IsEnabled = true;
            }
            if (Chapter_now == 11)
            {
                Chapter11List.Add(Vocabulary_Test);
                Btn2_ch11.IsEnabled = true;
            }
            if (Chapter_now == 12)
            {
                Chapter12List.Add(Vocabulary_Test);
                Btn2_ch12.IsEnabled = true;
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
            TakeWordsInTest();
            TakeAnswersInTest();
            Vocabulary_Test.Visibility = Visibility.Visible;
        }

        private void TakeWordsInTest()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int i = 0;
                connection.Open();
                string sqlExpression = $"DECLARE @id tinyint ='{User.Id}' exec GetWordsToTest @id";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read() && i!=3)
                    {
                        textBlocks[i].Text = reader.GetValue(3).ToString();
                        i++;
                    }
                }
                reader.Close();   
            }
        }

        private void TakeAnswersInTest()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int i = 0;
                connection.Open();
                string sqlExpression = $"DECLARE @id tinyint ='{User.Id}' exec GetAnswersToTest @id";
                while (i != 3)
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            ComboBoxes[i].Items.Add(reader.GetValue(4).ToString());
                        }
                        i++;
                    }
                    reader.Close();
                }
            }
        }

        private void ValidateVocabularyTest()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int i = 0;
                int id_word = 0, id_trans = -1;
                connection.Open();
                while (i != 3)
                {
                    string sqlExpression1 = $"DECLARE @Word NvarCHAR(50) ='{textBlocks[i].Text}' exec GetIdByWord @Word";
                    string sqlExpression2 = $"DECLARE @Trans NvarCHAR(50) ='{ComboBoxes[i].Text}' exec GetIdByTrans @Trans";
                    SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.HasRows) // если есть данные
                    {
                        while (reader1.Read())
                        {
                            id_word = int.Parse(reader1.GetValue(0).ToString());
                        }
                    }
                    reader1.Close();
                    SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.HasRows) // если есть данные
                    {
                        while (reader2.Read())
                        {
                            id_trans = int.Parse(reader2.GetValue(0).ToString());
                        }
                    }
                    reader2.Close();
                    string sqlExpression3 = $"DECLARE @id int ='{id_word}' exec UpdateGoodWord @id";
                    string sqlExpression4 = $"DECLARE @id_word int ='{id_word}',@id_trans int ='{id_trans}' exec UpdateBadWord @id_word,@id_trans";
                    if (id_trans == id_word)
                    {
                        SqlCommand command3 = new SqlCommand(sqlExpression3, connection);
                        command3.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand command4 = new SqlCommand(sqlExpression4, connection);
                        command4.ExecuteNonQuery();
                        MessageBox.Show(textBlocks[i].Text + "!=" + ComboBoxes[i].Text);
                    }
                    i++;
                }
            }
        }

        private void Voc_Test_Click(object sender, RoutedEventArgs e)
        {
            ValidateVocabularyTest();
            this.Close();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $"update progress set Last_Chapter = '{Chapter_now}' where id_user='{User.Id}'";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            } 
        }

        #endregion
        #region Chapter Progress


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
        private void Btn2_ch1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter1List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter2List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter3List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter4List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter5List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch6_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter6List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch7_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter7List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch8_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter8List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch9_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter9List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch10_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter10List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch11_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter11List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
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
        private void Btn2_ch12_MouseUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Grid a in Chapter12List)
            {
                a.Visibility = Visibility.Hidden;
            }
            Vocabulary_Test.Visibility = Visibility.Visible;
        }
        #endregion

    }
}
