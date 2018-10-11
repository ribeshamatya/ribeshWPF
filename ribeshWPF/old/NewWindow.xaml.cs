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
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {

        public NewWindow()
        {
            InitializeComponent();

            Init();

            EmployGrid.ItemsSource = Employees;
            list.ItemsSource = Employees;
        }

        private void Init()
        {
            Employees = new List<Employee>();
            Employee e = new Employee();
            e.Phone = "(206)5559857";
            e.FirstName = "Nancy";
            e.LastName = "Devolio";
            e.Title = "Sales Representitive";
            e.City = "Seattle";
            e.Country = "USA";

            Employees.Add(e);

            Employee e1 = new Employee();
            e1.Phone = "9818260207";
            e1.FirstName = "Ribesh";
            e1.LastName = "Amatya";
            e1.Title = "Sales Man";
            e1.City = "Kathmandu";
            e1.Country = "Nepal";

            Employees.Add(e1);

            Employee e2 = new Employee();
            e2.Phone = "9849178036";
            e2.FirstName = "Evan";
            e2.LastName = "Dangol";
            e2.Title = "Sales Manager";
            e2.City = "Kathmandu";
            e2.Country = "Nepal";

            Employees.Add(e2);

            Employee e3 = new Employee();
            e3.Phone = "9803317237";
            e3.FirstName = "Anish";
            e3.LastName = "Adhikari";
            e3.Title = "Sales Boy";
            e3.City = "Kathmandu";
            e3.Country = "Nepal";

            Employees.Add(e3);
        }

        public List<Employee> Employees { get; set; }



    }

 public class Employee
{
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

    }
}
