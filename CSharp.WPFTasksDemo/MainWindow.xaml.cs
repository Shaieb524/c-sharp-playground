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
using CSharp.ProblemSolving.Helpers.TaksNo1;

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
        }

        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            PyramidTextArea.Text = dh.GetAstriskPyramidString(7, "Left");

        }

        private void ButtonUp_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            PyramidTextArea.Text = dh.GetAstriskPyramidString(9, "Up");
        }

        private void ButtonRight_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            PyramidTextArea.Text = dh.GetAstriskPyramidString(9, "Right");
        }

        private void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            DisplayHelper dh = new DisplayHelper();
            PyramidTextArea.Text = dh.GetAstriskPyramidString(9, "Down");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
