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
    /// Lógica de interacción para Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Change Width
            if (image12.Stretch == Stretch.Fill)
            {
                image12.Stretch = Stretch.None;
                image4.Stretch = Stretch.None;
                image13.Stretch = Stretch.None;
                image7.Stretch = Stretch.None;
                buttomWidth.Content = "Set Width";
            }
            else if (image12.Stretch == Stretch.None)
            {
                imageContainer.Height = 320;
                image12.Stretch = Stretch.Fill;
                image4.Stretch = Stretch.Fill;
                image13.Stretch = Stretch.Fill;
                image7.Stretch = Stretch.Fill;
                buttomWidth.Content = "Restore Width";
            }
        }
    }
}
