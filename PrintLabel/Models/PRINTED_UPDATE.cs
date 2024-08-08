namespace PrintLabel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRINTED_UPDATE
    {
        [Key]
        public Guid DATA_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRINTED_TOTAL { get; set; }

        public DateTime? UPD_TIME { get; set; }
    }
}
