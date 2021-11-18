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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomNumber = new Random();
        List<int> array = new List<int>();
        private int minimalValue;
        private int maximalValue;
        private int minValueIndex;
        private int maxValueIndex;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FillArray(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(arrayLengthBox.Text); i++)
            {
                array.Add(randomNumber.Next(-30, 100));
            }
            arrayListBox.ItemsSource = array;
        }

        private void SwapValues_Click(object sender, RoutedEventArgs e)
        {
            minimalValue = array.Min();
            maximalValue = array.Max();
            minValueIndex = array.IndexOf(array.Min());
            maxValueIndex = array.IndexOf(array.Max());
            array[minValueIndex] = maximalValue;
            array[maxValueIndex] = minimalValue;
            arrayListBox.Items.Refresh();
            arrayListBox.SelectedIndex = minValueIndex;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Шестаков Артём \nДан массив в диапазоне [-30;100] найти минимальное и максимальное значение и  обменять их местами. ");
        }
    }
}
