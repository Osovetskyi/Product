using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Report
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public ZP ZP { get; set; }
        public Time Time { get; set; }
    }
}
