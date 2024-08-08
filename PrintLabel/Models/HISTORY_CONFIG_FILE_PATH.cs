namespace PrintLabel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HISTORY_CONFIG_FILE_PATH
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MODEL { get; set; }

        [StringLength(10)]
        public string DEST { get; set; }

        public int? PRINT_TYPE { get; set; }

        [StringLength(50)]
        public string OLD_PRINT_PATH { get; set; }

        [StringLength(50)]
        public string NEW_PRINT_PATH { get; set; }

        [StringLength(50)]
        public string OLD_DATABASE_PATH { get; set; }

        [StringLength(50)]
        public string NEW_DATABASE_PATH { get; set; }

        public DateTime? UPD_TIME { get; set; }

        [StringLength(50)]
        public string USER_CHANGE { get; set; }

        [StringLength(50)]
        public string MACHINE_NAME { get; set; }
    }
}
