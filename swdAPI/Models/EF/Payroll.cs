namespace swdAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payroll")]
    public partial class Payroll
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayrollID { get; set; }

        public int? empID { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetPay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public int? HoursWorked { get; set; }

        [Column(TypeName = "money")]
        public decimal? GrossPay { get; set; }

        public virtual Employee Employee { internal get; set; }
    }
}
