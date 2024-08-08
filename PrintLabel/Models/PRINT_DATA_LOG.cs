namespace PrintLabel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRINT_DATA_LOG
    {
        public int ID { get; set; }

        public Guid? DATA_ID { get; set; }

        public int? PRINT_TYPE { get; set; }

        [StringLength(50)]
        public string PRINT_CODE { get; set; }

        public DateTime? UPD_TIME { get; set; }

        [StringLength(50)]
        public string PRINTER { get; set; }

        [StringLength(50)]
        public string MACHINE_NAME { get; set; }

        public bool? IS_REPRINT { get; set; }

        public int? BASE_REQUEST { get; set; }
    }
}
