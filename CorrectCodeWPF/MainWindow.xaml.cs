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
using CorrectCodeLibrary;

namespace CorrectCodeWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string,int> inputData = new Dictionary<string, int>();
        public MainWindow()
        {
            InitializeComponent();
            FileManager();

        }

       private void FileManager()
        {
            string path1 = "testdata\\input_1.txt";

            string[] input = File.ReadAllLines(path1, Encoding.UTF8);
            foreach (var item in input)
            {
                string[] result= item.Split(';');
                // inputData.Add(result[0], Char.GetNumericValue(result[1]));
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string toDo = numOrCorrect.Text;
            bool res = CorrectCodeClass.IsCorrectCode(toDo);
            Result.Text = Convert.ToString(res);
        }
    }
}
