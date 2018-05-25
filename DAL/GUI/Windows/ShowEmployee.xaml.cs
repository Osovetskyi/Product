using DAL;
using BL;
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

namespace GUI.Windows
{
    /// <summary>
    /// Interaction logic for ShowEmployee.xaml
    /// </summary>
    public partial class ShowEmployee : Window
    {
        GetEmployees getEmployees;
        public ShowEmployee()
        {
            InitializeComponent();
            getEmployees = new GetEmployees();
            list.ItemsSource = getEmployees.ReturnEmployees().ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            var result = pd.ShowDialog();
            if (result.HasValue && result.Value)
            {
                pd.PrintVisual(list, "Employees");
            }
        }
    }
}
