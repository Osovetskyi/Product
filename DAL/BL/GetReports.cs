using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GetReports
    {
        private Product db;
        public GetReports()
        {
            db = new Product();
        }
        public IEnumerable ReturnReports()
        {
            var query = from rep in db.Reports
                        join name in db.Employees on rep.Employee.Id equals name.Id
                        join zp in db.ZPs on rep.Id equals zp.Id
                        join time in db.Times on zp.Id equals time.Id
                        orderby time.End_date descending
                        select new { Rahunok = name.Rahunok, Bonus = zp.Bonus, Summ = zp.Zp, Date = time.End_date };
            return query.ToList();
        }
    }
}
