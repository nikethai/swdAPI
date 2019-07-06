namespace swdAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Allowance")]
    public partial class Allowance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int alID { get; set; }

        [StringLength(50)]
        public string alName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int? empID { get; set; }

        public virtual Employee Employee { internal get; set; }
    }
}
