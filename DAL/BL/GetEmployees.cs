using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GetEmployees
    {
        private Product db;
        public GetEmployees()
        {
            db = new Product();
        }
        public List<Employee> ReturnEmployees()
        {
            return db.Employees.ToList();
        }
    }
}
