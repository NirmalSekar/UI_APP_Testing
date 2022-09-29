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

namespace UI_APP_Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "nirmal", LastName = "kumar" });
            people.Add(new Person { FirstName = "Sekar", LastName = "Dh" });

            mycomboBox.ItemsSource = people;
        }

        private void sumbitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hi {firstName.Text} My first presentation");
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string FullName
            {
                get
                {
                    return $"{FirstName} {LastName}";
                }
            } 
        }
    }
}