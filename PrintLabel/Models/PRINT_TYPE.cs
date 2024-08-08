namespace PrintLabel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRINT_TYPE
    {
        public Guid ID { get; set; }

        [StringLength(50)]
        public string PRINT_NAME { get; set; }

        [Column("PRINT_TYPE")]
        public int? PRINT_TYPE1 { get; set; }
    }
}
