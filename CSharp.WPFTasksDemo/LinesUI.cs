using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.WPFTasksDemo
{
    public class LinesUI : INotifyPropertyChanged
    {
        private string _TextBox1Text;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string TextBox1Text
        {
            get { return TextBox1Text; } 
            
            set
            {
                if (_TextBox1Text != value)
                {
                    TextBox1Text = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TextBox1Text)));
                }
            }
        }

    }
}
