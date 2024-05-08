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

namespace WPFCRUD
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        Person Person;
        PersonContext db;
        
        public WindowAdd()
        {
            InitializeComponent();
            Person = new Person(" ",18);
            spInput.DataContext = Person;
            db = new PersonContext();

        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void btnClose_Click1(object sender, RoutedEventArgs e)
        {
            //Person.Name = "Dezső";
            
            //MessageBox.Show(Person.ToString());
            Person.Id = 0;
            db.Persons.Add(Person);
            await db.SaveChangesAsync();
            Person.Name = "";
            Person.Age = 18;

        }
    }
}
