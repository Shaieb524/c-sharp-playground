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
using CSharp.ProblemSolving.Tasks.TaksNo1;

namespace CSharp.WPFTasksDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PyramidTextArea.Visibility = Visibility.Collapsed;
        }

        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            //PyramidTextArea.TextAlignment = TextAlignment.Center;
            PyramidTextArea.TextAlignment = TextAlignment.Left;
            PyramidTextArea.Text = dh.GetAstriskPyramidString(Int32.Parse(PyramidLength.Text), "Left");

        }

        private void ButtonUp_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            PyramidTextArea.TextAlignment = TextAlignment.Center;
            PyramidTextArea.Text = dh.GetAstriskPyramidString(Int32.Parse(PyramidLength.Text), "Up");
        }

        private void ButtonRight_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            PyramidTextArea.TextAlignment = TextAlignment.Right;
            PyramidTextArea.Text = dh.GetAstriskPyramidString(Int32.Parse(PyramidLength.Text), "Right");
        }

        private void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            PyramidTextArea.TextAlignment = TextAlignment.Center;
            PyramidTextArea.Text = dh.GetAstriskPyramidString(Int32.Parse(PyramidLength.Text), "Down");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            PyramidTextArea.Visibility = Visibility.Visible ;
        }
    }
}
