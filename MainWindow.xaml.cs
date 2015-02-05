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
using System.Windows.Threading;

namespace stopwatch_MVP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private EventHandler start;
        private EventHandler stop;
        private EventHandler clear;

        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }
        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }
        public event EventHandler Clear
        {
            add { clear += value; }
            remove { clear -= value; }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            stop.Invoke(sender, e);
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            clear.Invoke(sender, e);
        }


        
    }
}
