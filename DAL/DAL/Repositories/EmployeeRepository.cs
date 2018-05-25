using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private Product db;

        public EmployeeRepository()
        {
            this.db = new Product();
        }

        public virtual IEnumerable<Employee> GetList()
        {
            return db.Employees;
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public virtual void Create(Employee emp)
        {
            db.Employees.Add(emp);
        }

        public void Update(Employee emp)
        {
            db.Entry(emp).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Employee emp = db.Employees.Find(id);
            if (emp != null)
                db.Employees.Remove(emp);
        }

        public virtual void Save()
        {
            db.SaveChanges();
        }
    }
}
