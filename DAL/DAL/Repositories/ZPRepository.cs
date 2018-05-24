using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ZPRepository : IRepository<ZP>
    {
        private Product db;

        public ZPRepository()
        {
            this.db = new Product();
        }

        public IEnumerable<ZP> GetList()
        {
            return db.ZPs;
        }

        public ZP Get(int id)
        {
            return db.ZPs.Find(id);
        }

        public void Create(ZP zp)
        {
            db.ZPs.Add(zp);
        }

        public void Update(ZP zp)
        {
            db.Entry(zp).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            ZP zp = db.ZPs.Find(id);
            if (zp != null)
                db.ZPs.Remove(zp);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
