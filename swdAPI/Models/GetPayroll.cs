using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace swdAPI.Models.EF
{
    public class GetPayroll
    {
        PayrollDB db;
        public GetPayroll()
        {
            db = new PayrollDB();
        }
        public List<Payroll> getPayroll()
        {
            var listcomp = db.Payrolls.ToList();
            return listcomp;
        }
        public List<PayrollDTO> getPayroll(int empID)
        {
            var listPayEmp = (from p in db.Payrolls
                             join e in db.Employees on p.empID equals e.empID
                             join a in db.Allowances on p.empID equals a.empID 
                             join d in db.Deductions on p.empID equals d.empID
                             where e.empID == empID
                             select new PayrollDTO(){NetPay = p.NetPay,
                                 EndDate = p.EndDate, EmpName = e.empName, alName = a.alName,
                             alAmount = a.Amount,deName = d.deName,deAmount = d.Amount}).ToList();
            return listPayEmp;
        }
    }
    public class PayrollDTO
    {
        public string EmpName { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? NetPay { get; set; }
        public string alName { get; set; }
        public decimal? alAmount { get; set; }
        public string deName { get; set; }
        public decimal? deAmount { get; set; }
    }
}