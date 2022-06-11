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

namespace ImagesView
{
    /// <summary>
    /// Lógica de interacción para SelectTask.xaml
    /// </summary>
    public partial class SelectTask : Window
    {
        public SelectTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Task1().ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
        }
    }
}
