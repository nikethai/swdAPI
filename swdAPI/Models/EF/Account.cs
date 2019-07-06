namespace swdAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccID { get; set; }

        [StringLength(50)]
        public string AccName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? empID { get; set; }

        public virtual Employee Employee { internal get; set; }
    }
}
