namespace swdAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BasicSalary")]
    public partial class BasicSalary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int salID { get; set; }

        public int? LevelSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? empID { get; set; }

        public virtual Employee Employee { internal get; set; }
    }
}
