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

namespace ribeshWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
                if( Convert.ToInt32(textBox.Text)%2==1)
            {
                MessageBox.Show("odd");
            }
            else
            {
                MessageBox.Show("even");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int a= Convert.ToInt32(textBox1.Text);
            int b= Convert.ToInt32(textBox3.Text);
            int c = Convert.ToInt32(textBox2.Text);
            
            int t = a + b + c;
            if(t==180)
            {
                textBlock.Text="it is triangle";
            }
            else
            {
                textBlock.Text = "it is not triangle";
            }
        }
    }
    
}
