using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReportRepository : IRepository<Report>
    {
        private Product db;

        public ReportRepository()
        {
            this.db = new Product();
        }

        public IEnumerable<Report> GetList()
        {
            return db.Reports;
        }

        public Report Get(int id)
        {
            return db.Reports.Find(id);
        }

        public void Create(Report report)
        {
            db.Reports.Add(report);
        }

        public void Update(Report report)
        {
            db.Entry(report).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Report report = db.Reports.Find(id);
            if (report != null)
                db.Reports.Remove(report);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
