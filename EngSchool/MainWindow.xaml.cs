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

namespace EngSchool
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

       

        private void PageFirst_Click(object sender, RoutedEventArgs e)
        {
            FrameTable.Navigate(new TableClientPage());
        }

        private void PageSecond_Click(object sender, RoutedEventArgs e)
        {
            FrameTable.Navigate(new TableClientSecondPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FrameTable.Navigate(new TableClientPage());
        }


    }
}

