using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PrintLabel.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<HISTORY_CONFIG_FILE_PATH> HISTORY_CONFIG_FILE_PATH { get; set; }
        public virtual DbSet<MASTER_DATA> MASTER_DATA { get; set; }
        public virtual DbSet<PRINT_DATA_LOG> PRINT_DATA_LOG { get; set; }
        public virtual DbSet<PRINT_TYPE> PRINT_TYPE { get; set; }
        public virtual DbSet<PRINTED_UPDATE> PRINTED_UPDATE { get; set; }
        public virtual DbSet<RE_PRINT_DATA_LOG> RE_PRINT_DATA_LOG { get; set; }
        public virtual DbSet<USER> USER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HISTORY_CONFIG_FILE_PATH>()
                .Property(e => e.DEST)
                .IsFixedLength();

            modelBuilder.Entity<MASTER_DATA>()
                .Property(e => e.MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_DATA>()
                .Property(e => e.CELL)
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_DATA>()
                .Property(e => e.START_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PRINTED_UPDATE>()
                .Property(e => e.PRINTED_TOTAL)
                .HasPrecision(18, 0);

            modelBuilder.Entity<USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);
        }
    }
}
