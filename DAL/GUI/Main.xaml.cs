
using GUI.Windows;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            Database.SetInitializer(new CreateDatabaseIfNotExists<DAL.Product>());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.ShowDialog();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Report rep = new Report();
            rep.ShowDialog();
        }

        private void ShowEmployee_Click(object sender, RoutedEventArgs e)
        {
            ShowEmployee show = new ShowEmployee();
            show.ShowDialog();
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            ZP report = new ZP();
            report.ShowDialog();
        }
    }
}
