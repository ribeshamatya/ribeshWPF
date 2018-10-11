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

namespace ribeshWPF
{
    /// <summary>
    /// Interaction logic for NewWindow3.xaml
    /// </summary>
    public partial class NewWindow3 : Window
    {
        public NewWindow3()
        {
            InitializeComponent();
            Students = new List<student>
            {
                new student {Name="Ribesh",Age=14 , Image="Hide.jpg"},
                new student {Name="Evan",Age=60 , Image="TokyoGhoul.jpg" },
                new student {Name="Anish",Age=17 , Image="Hide.jpg" },
                new student {Name="Gaurav",Age=16 , Image="Hide.jpg" },
                new student {Name="Salin",Age=16 , Image="Hide.jpg" }
            };
            //LisB.ItemsSource = Students;
            //LisB.DisplayMemberPath = "Image";
        }

        public List<student> Students { get; set; }

    }
    public class student 
        {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
    }
}
