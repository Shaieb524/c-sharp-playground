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
using CSharp.ProblemSolving.Tasks.TaskNo2.Taskk;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StarEmitter emitter = new StarEmitter(6, 3);
            emitter.DrawVerticalLine();
            TextBox2.Text = emitter.DrawVerticalLineString();

            //ConsoleDrawer cD = new ConsoleDrawer(6);
            //var xx = cD.SubscribeWPF(emitter);
            //TextBox1.Text = xx;

            //emitter.EmitStars();

            var LinesUi = new LinesUI();
            LinesUi.TextBox1Text = "Start Text";
            TextBox1.Text = LinesUi.TextBox1Text;

            //System.Threading.Thread.Sleep(3000);
            //LinesUi.TextBox1Text = "Updated Text";
            //var xx = cD.DrawAStarString(sender, e);

            //TextBox1.Text = xx;

        }

        public void UpdateTextBox(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;

            TextBox1.Text = "* " + 
                currentTime.Hour.ToString() +
                currentTime.Minute.ToString() +
                currentTime.Second.ToString() ;

        }

        private void TextBox_TextChanged1(object sender, TextChangedEventArgs e)
        {
        }
        private void TextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {
        }
    }
}
