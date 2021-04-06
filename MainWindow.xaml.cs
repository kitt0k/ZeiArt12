using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.IO;


namespace ZeiArt12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void LastName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int d;
            if (int.TryParse(e.Text, out d))
            {
                e.Handled = true;
            }
        }

        private void Age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int w;
            if (!int.TryParse(e.Text, out w))
            {
                e.Handled = true;
            }
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        {


            //MessageBox.Show($"Фамилия: {LastName.Text}\nИмя: {Name.Text}\nВозраст: {Age.Text}");
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {



        }

        private void UsersWin_Click(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            this.Close();
            window1.Show();
            this.Hide();

        }
    }
}






            //        using (StreamReader sr = new StreamReader("openusers.txt"))
            //        {
            //            for (int i = 0; i<File.ReadAllLines("openusers.txt").Count(); i++)
            //            {
            //                string user = sr.ReadLine();

            //}






            // trash



           
            

























//OpenFileDialog openusers = new OpenFileDialog();
//openusers.ShowDialog();
//if (openusers.FileName != "")
//{
//    StreamReader sr = new StreamReader(@"C:\Users\WSR\Desktop\openusers.txt");
//    while (!sr.EndOfStream)
//    {
//        string[] lines = new string[3];
//        for (int i = 0; i < 3; i++)
//        {
//            string line = sr.ReadLine();
//            string[] data = line.Split(':');
//            line = "";
//            if (data.Length >= 2)
//            {
//                for (int j = 0; j < data.Length; j++)
//                {
//                    line += data[j];
//                }
//            }

//            lines[i] = line;

//        }
//        MessageBox.Show("Данные в файле:\n Фамилия: " + lines[0] + "\n Имя: " + lines[1] + "\n Возраст: " + lines[2]);
//    }
//}

//else
//{
//    MessageBox.Show("Файл не выбран");
//}