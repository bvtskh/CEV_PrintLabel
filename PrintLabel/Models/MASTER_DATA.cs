namespace PrintLabel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASTER_DATA
    {
        public Guid ID { get; set; }

        [StringLength(50)]
        public string MODEL { get; set; }

        [StringLength(50)]
        public string CELL { get; set; }

        [StringLength(100)]
        public string DEST { get; set; }

        [StringLength(50)]
        public string START_CODE { get; set; }

        public int? CHAR_NUMBER { get; set; }

        public int? PRINT_TYPE { get; set; }

        public DateTime? UPD_TIME { get; set; }

        [StringLength(50)]
        public string USER_UPDATE { get; set; }

        [StringLength(200)]
        public string PRINT_PATH { get; set; }

        [StringLength(200)]
        public string DATABASE_PATH { get; set; }
    }
}
