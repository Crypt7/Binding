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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee emp;
        //private Employee emp1;
        public MainWindow()
        {
            InitializeComponent();
            emp = new Employee
            {
                Name = "Joe",
                Title = "Qa"
            };
            DataContext = emp;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            emp.Name = "Jessie";
            emp.Title = "Dev";
                
        }
    }
}
