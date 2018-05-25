using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AddReport
    {
        private Product db;
        public AddReport()
        {
            db = new Product();
        }
        public bool AddRep(string nameEmpl, string bonus, string sum, string start_date, string end_date)
        {
            try
            {
                Employee emp = db.Employees.Single(x => x.Name == nameEmpl);
                DAL.ZP zp = new DAL.ZP
                {
                    Bonus = Convert.ToDouble(bonus),
                    Zp = Convert.ToDouble(sum)
                };
                DAL.Time tim = new DAL.Time
                {
                    Start_date = start_date,
                    End_date = end_date
                };
                DAL.Report report = new DAL.Report
                {
                    Time = tim,
                    ZP = zp
                };
                emp.Report.Add(report);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false; ;
            }
        }
    }
}
