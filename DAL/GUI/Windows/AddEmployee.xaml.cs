using DAL;
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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if(name.Text == "")
            {
                MessageBox.Show("ПІБ не заповнено!","Помилка",MessageBoxButton.OK);
                return;
            }
            else if (qual.Text == "")
            {
                MessageBox.Show("Кваліфікацію не заповнено!", "Помилка", MessageBoxButton.OK);
                return;
            }
            else if (rahunok.Text == "")
            {
                MessageBox.Show("Рахунок не заповнено!", "Помилка", MessageBoxButton.OK);
                return;
            }
            else if (number.Text == "")
            {
                MessageBox.Show("Номер не заповнено!", "Помилка", MessageBoxButton.OK);
                return;
            }          
            try
            {
                EmployeeRepository employee = new EmployeeRepository();
                employee.Create(new Employee { Name = name.Text, Qualification = qual.Text, Rahunok = Convert.ToInt32(rahunok.Text), Tub_number = Convert.ToInt32(number.Text) });
                employee.Save();
                MessageBox.Show("Користувача додано!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Введено не корректні дані!", "Помилка", MessageBoxButton.OK);
                return;
            }

        }
    }
}
