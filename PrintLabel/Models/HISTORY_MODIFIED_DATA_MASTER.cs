namespace PrintLabel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HISTORY_MODIFIED_DATA_MASTER
    {
        public int ID { get; set; }

        public int? UPD_TYPE { get; set; }

        public DateTime? UPD_TIME { get; set; }

        [StringLength(50)]
        public string UPD_USER { get; set; }

        [StringLength(50)]
        public string MACHINE_NAME { get; set; }

        [StringLength(300)]
        public string DESCRIBE { get; set; }

        public Guid? DATA_ID { get; set; }

        [StringLength(50)]
        public string MODEL { get; set; }

        [StringLength(50)]
        public string CELL { get; set; }

        [StringLength(50)]
        public string DEST { get; set; }

        [StringLength(50)]
        public string START_CODE { get; set; }

        public int? CHAR_NUMBER { get; set; }

        public int? PRINT_TYPE { get; set; }

        [StringLength(100)]
        public string PRINT_PATH { get; set; }

        [StringLength(100)]
        public string DATABASE_PATH { get; set; }
    }
}
