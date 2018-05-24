namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Product : DbContext
    {
        public Product()
            : base("name=Product")
        {
        }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Time> Times { get; set; }
        public virtual DbSet<ZP> ZPs { get; set; }
    }
}