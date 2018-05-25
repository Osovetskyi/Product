using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AddEmployee
    {
        public EmployeeRepository employee;
        public AddEmployee()
        {
            employee = new EmployeeRepository();
        }
        public bool AddEmp(string name, string qual, string rahunok, string number)
        {
            try
            {
                employee.Create(new Employee { Name = name, Qualification = qual, Rahunok = Convert.ToInt32(rahunok), Tub_number = Convert.ToInt32(number) });
                employee.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
