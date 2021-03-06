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

        private void treeHeight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            imageContainer.Height = treeHeight.Value;

        }

        private void treeWidth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            imageContainer.Width = treeWidth.Value;
        }
        private void isUniform_Unchecked(object sender, RoutedEventArgs e)
        {
            image12.Stretch = Stretch.None;
            image13.Stretch = Stretch.None;
            image4.Stretch = Stretch.None;
            image7.Stretch = Stretch.None;
        }

        private void isUniform_Checked(object sender, RoutedEventArgs e)
        {
            image12.Stretch = Stretch.Uniform;
            image13.Stretch = Stretch.Uniform;
            image4.Stretch = Stretch.Uniform;
            image7.Stretch = Stretch.Uniform;
        }
    }

}
