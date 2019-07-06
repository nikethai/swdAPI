namespace swdAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reID { get; set; }

        public int? empID { get; set; }

        [StringLength(50)]
        public string Message { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual Employee Employee { internal get; set; }
    }
}
