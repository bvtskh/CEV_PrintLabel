namespace PrintLabel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [Key]
        [StringLength(50)]
        public string ACCOUNT { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        [StringLength(100)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string DEPT { get; set; }

        public int? TYPE { get; set; }

        [StringLength(200)]
        public string DESCRIBE { get; set; }
    }
}
