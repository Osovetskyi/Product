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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        BL.AddEmployee addEmployee;
        public AddEmployee()
        {
            InitializeComponent();
            addEmployee = new BL.AddEmployee();
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
            if (addEmployee.AddEmp(name.Text, qual.Text, rahunok.Text, number.Text))
            {
                MessageBox.Show("Працівника додано!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Введено не корректні дані!", "Помилка", MessageBoxButton.OK);
                return;
            }

        }
    }
}
