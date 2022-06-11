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

namespace ImagesView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderimg12Top_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image12.Margin = new Thickness(sliderimg12Left.Value, sliderimg12Top.Value, sliderimg12Right.Value,sliderimg12Buttom.Value);
        }

        private void sliderimg12Buttom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image12.Margin = new Thickness(sliderimg12Left.Value, sliderimg12Top.Value, sliderimg12Right.Value, sliderimg12Buttom.Value);
        }

        private void sliderimg12Left_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image12.Margin = new Thickness(sliderimg12Left.Value, sliderimg12Top.Value, sliderimg12Right.Value, sliderimg12Buttom.Value);
        }

        private void sliderimg12Right_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image12.Margin = new Thickness(sliderimg12Left.Value, sliderimg12Top.Value, sliderimg12Right.Value, sliderimg12Buttom.Value);
        }

        private void sliderimg04Top_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image4.Margin = new Thickness(sliderimg04Left.Value, sliderimg04Top.Value, sliderimg04Right.Value, sliderimg04Bottom.Value);
        }

        private void sliderimg04Bottom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image4.Margin = new Thickness(sliderimg04Left.Value, sliderimg04Top.Value, sliderimg04Right.Value, sliderimg04Bottom.Value);
        }

        private void sliderimg04Left_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image4.Margin = new Thickness(sliderimg04Left.Value, sliderimg04Top.Value, sliderimg04Right.Value, sliderimg04Bottom.Value);
        }

        private void sliderimg04Right_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image4.Margin = new Thickness(sliderimg04Left.Value, sliderimg04Top.Value, sliderimg04Right.Value, sliderimg04Bottom.Value);
        }

        private void sliderimg07Top_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image7.Margin = new Thickness(sliderimg07Left.Value, sliderimg07Top.Value, sliderimg07Right.Value, sliderimg07Bottom.Value);
        }

        private void sliderimg07Bottom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image7.Margin = new Thickness(sliderimg07Left.Value, sliderimg07Top.Value, sliderimg07Right.Value, sliderimg07Bottom.Value);
        }

        private void sliderimg07Left_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image7.Margin = new Thickness(sliderimg07Left.Value, sliderimg07Top.Value, sliderimg07Right.Value, sliderimg07Bottom.Value);
        }

        private void sliderimg07Right_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image7.Margin = new Thickness(sliderimg07Left.Value, sliderimg07Top.Value, sliderimg07Right.Value, sliderimg07Bottom.Value);
        }

        private void sliderimg03Top_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image3.Margin = new Thickness(sliderimg03Left.Value, sliderimg03Top.Value, sliderimg03Right.Value, sliderimg03Bottom.Value);
        }

        private void sliderimg03Bottom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image3.Margin = new Thickness(sliderimg03Left.Value, sliderimg03Top.Value, sliderimg03Right.Value, sliderimg03Bottom.Value);
        }

        private void sliderimg03Left_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image3.Margin = new Thickness(sliderimg03Left.Value, sliderimg03Top.Value, sliderimg03Right.Value, sliderimg03Bottom.Value);
        }

        private void sliderimg03Right_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image3.Margin = new Thickness(sliderimg03Left.Value, sliderimg03Top.Value, sliderimg03Right.Value, sliderimg03Bottom.Value);
        }

        private void sliderimg05Top_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image5.Margin = new Thickness(sliderimg05Left.Value, sliderimg05Top.Value, sliderimg05Right.Value, sliderimg05Bottom.Value);
        }

        private void sliderimg05Bottom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image5.Margin = new Thickness(sliderimg05Left.Value, sliderimg05Top.Value, sliderimg05Right.Value, sliderimg05Bottom.Value);
        }

        private void sliderimg05Left_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image5.Margin = new Thickness(sliderimg05Left.Value, sliderimg05Top.Value, sliderimg05Right.Value, sliderimg05Bottom.Value);
        }

        private void sliderimg05Right_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image5.Margin = new Thickness(sliderimg05Left.Value, sliderimg05Top.Value, sliderimg05Right.Value, sliderimg05Bottom.Value);
        }

        private void sliderimg13Top_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image13.Margin = new Thickness(sliderimg13Left.Value, sliderimg13Top.Value, sliderimg13Right.Value, sliderimg13Bottom.Value);
        }

        private void sliderimg13Botom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image13.Margin = new Thickness(sliderimg13Left.Value, sliderimg13Top.Value, sliderimg13Right.Value, sliderimg13Bottom.Value);
        }

        private void sliderimg13Right_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image13.Margin = new Thickness(sliderimg13Left.Value, sliderimg13Top.Value, sliderimg13Right.Value, sliderimg13Bottom.Value);
        }

        private void sliderimg13Left_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image13.Margin = new Thickness(sliderimg13Left.Value, sliderimg13Top.Value, sliderimg13Right.Value, sliderimg13Bottom.Value);
        }

        private void sliderimg06Top_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image6.Margin = new Thickness(sliderimg06Left.Value, sliderimg06Top.Value, sliderimg06Right.Value, sliderimg06Bottom.Value);
        }

        private void sliderimg06Bottom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image6.Margin = new Thickness(sliderimg06Left.Value, sliderimg06Top.Value, sliderimg06Right.Value, sliderimg06Bottom.Value);
        }

        private void sliderimg06Left_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image6.Margin = new Thickness(sliderimg06Left.Value, sliderimg06Top.Value, sliderimg06Right.Value, sliderimg06Bottom.Value);
        }

        private void sliderimg06Right_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            image6.Margin = new Thickness(sliderimg06Left.Value, sliderimg06Top.Value, sliderimg06Right.Value, sliderimg06Bottom.Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Reset all value sliders
            sliderimg06Left.Value = 0;
            sliderimg06Top.Value = 0;
            sliderimg06Right.Value = 0;
            sliderimg06Bottom.Value = 0;

            sliderimg13Left.Value = 0;
            sliderimg13Top.Value = 0;
            sliderimg13Right.Value = 0;
            sliderimg13Bottom.Value = 0;

            sliderimg05Left.Value = 0;
            sliderimg05Top.Value = 0;
            sliderimg05Right.Value = 0;
            sliderimg05Bottom.Value = 0;

            sliderimg03Left.Value = 0;
            sliderimg03Top.Value = 0;
            sliderimg03Right.Value = 0;
            sliderimg03Bottom.Value = 0;

            sliderimg04Left.Value = 0;
            sliderimg04Top.Value = 0;
            sliderimg04Right.Value = 0;
            sliderimg04Bottom.Value = 0;

            sliderimg07Left.Value = 0;
            sliderimg07Top.Value = 0;
            sliderimg07Right.Value = 0;
            sliderimg07Bottom.Value = 0;

            sliderimg12Left.Value = 0;
            sliderimg12Top.Value = 0;
            sliderimg12Right.Value = 0;
            sliderimg12Buttom.Value = 0;
        }
    }
}
