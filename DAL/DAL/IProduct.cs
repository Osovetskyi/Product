using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProduct
    {
        DbSet<Report> Reports { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Time> Times { get; set; }
        DbSet<ZP> ZPs { get; set; }
    }
}
