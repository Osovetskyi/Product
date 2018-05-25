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
        public EmployeeRepository employeeRepository;
        public GetEmployees()
        {
            employeeRepository = new EmployeeRepository();
        }
        public IEnumerable<Employee> ReturnEmployees()
        {
            return employeeRepository.GetList();
        }
    }
}
