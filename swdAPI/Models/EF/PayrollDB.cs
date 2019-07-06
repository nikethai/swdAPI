namespace swdAPI.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PayrollDB : DbContext
    {
        public PayrollDB()
            : base("name=PayrollDB2")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Allowance> Allowances { get; set; }
        public virtual DbSet<BasicSalary> BasicSalaries { get; set; }
        public virtual DbSet<Deduction> Deductions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Payroll> Payrolls { get; set; }
        public virtual DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allowance>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BasicSalary>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Deduction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payroll>()
                .Property(e => e.NetPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payroll>()
                .Property(e => e.GrossPay)
                .HasPrecision(19, 4);
        }
    }
}
