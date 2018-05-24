using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TimeRepository : IRepository<Time>
    {
        private Product db;

        public TimeRepository()
        {
            this.db = new Product();
        }

        public IEnumerable<Time> GetList()
        {
            return db.Times;
        }

        public Time Get(int id)
        {
            return db.Times.Find(id);
        }

        public void Create(Time time)
        {
            db.Times.Add(time);
        }

        public void Update(Time time)
        {
            db.Entry(time).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Time time = db.Times.Find(id);
            if (time != null)
                db.Times.Remove(time);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
