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

namespace Practice_6G
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
        private void Multiply2Pair_Click(object sender, RoutedEventArgs e)
        {
            Pair firstPair = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            Pair secondPair = new Pair(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Pair resultPair = firstPair.Multiply(secondPair);
            result.Text = (resultPair.First, resultPair.Second).ToString();
        }

        private void IncrementPair_Click(object sender, RoutedEventArgs e)
        {
            Pair firstPair = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            firstPair++;
            result.Text = (firstPair.First, firstPair.Second).ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дроздов Г.", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
