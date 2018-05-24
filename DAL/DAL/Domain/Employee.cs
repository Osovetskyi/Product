using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public int Tub_number { get; set; }
        public int Rahunok { get; set; }
        public ICollection<Report> Report { get; set; }
        public Employee()
        {
            Report = new List<Report>();
        }
    }
}
