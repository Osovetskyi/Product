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
    /// Interaction logic for ZP.xaml
    /// </summary>
    public partial class ZP : Window
    {
        private Product db;
        public ZP()
        {
            InitializeComponent();
            db = new Product();
            var query = from rep in db.Reports
                        join name in db.Employees on rep.Employee.Id equals name.Id
                        join zp in db.ZPs on rep.Id equals zp.Id
                        join time in db.Times on zp.Id equals time.Id
                        orderby time.End_date descending
                        select new { Rahunok = name.Rahunok, Bonus = zp.Bonus, Summ = zp.Zp, Date = time.End_date };
            list.ItemsSource = query.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            var pd = new PrintDialog();
            var result = pd.ShowDialog();
            if (result.HasValue && result.Value)
            {
                pd.PrintVisual(list, "Report");
            }
        }
    }
}
