using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace swdAPI.Models.EF
{
    public class GetAllowance
    {
        PayrollDB db;
        public GetAllowance()
        {
            db = new PayrollDB();
        }
        public List<Allowance> getAllowance()
        {
            var allAllow = db.Allowances.ToList();
            return allAllow;
        }
        public List<AllowanceDTO> getAllowance(int id)
        {
            
            var listAllow = (from a in db.Allowances
                             where a.empID == id
                             select new AllowanceDTO() {alID = a.alID,alName = a.alName,alAmount = a.Amount })
                             .ToList();
            return listAllow;
        }
    }
    public class AllowanceDTO
    {
        public int alID { get; set; }
        public string alName { get; set; }
        public decimal? alAmount { get; set; }
    }
}