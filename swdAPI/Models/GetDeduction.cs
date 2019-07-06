using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace swdAPI.Models.EF
{
    public class GetDeduction
    {
        PayrollDB db;
        public GetDeduction()
        {
            db = new PayrollDB();
        }
        public List<Deduction> getDeduction()
        {
            var allDeduct = db.Deductions.ToList();
            return allDeduct;
        }
        public List<DeductionDTO> getDeduction(int id)
        {
            
            var listDeduct = (from a in db.Deductions
                             where a.empID == id
                             select new DeductionDTO() {deID = a.deID,deName = a.deName,deAmount = a.Amount })
                             .ToList();
            return listDeduct;
        }
    }
    public class DeductionDTO
    {
        public int deID { get; set; }
        public string deName { get; set; }
        public decimal? deAmount { get; set; }
    }
}