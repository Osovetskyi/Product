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
using DAL;
using BL;

namespace GUI.Windows
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        AddReport addReport;
        public Report()
        {
            InitializeComponent();
            AddComb();
            addReport = new AddReport();
        }
        private void AddComb()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            foreach (var item in employeeRepository.GetList())
            {
                Name.Items.Add(item.Name);
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Name.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Працівник не вибраний!", "Помилка", MessageBoxButton.OK);
                return;
            }
            if (Bonus.Text == "")
            {
                MessageBox.Show("Бонус не заповнено!", "Помилка", MessageBoxButton.OK);
                return;
            }
            else if (Sum.Text == "")
            {
                MessageBox.Show("Сумму не заповнено!", "Помилка", MessageBoxButton.OK);
                return;
            }
            else if (Start_date.Text == "" || End_date.Text == "")
            {
                MessageBox.Show("Дату не заповнено!", "Помилка", MessageBoxButton.OK);
                return;
            }
            if (addReport.AddRep(Name.SelectedItem.ToString(), Bonus.Text, Sum.Text, Start_date.Text, End_date.Text))
            {
                MessageBox.Show("ЗП Нараховано!");
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
