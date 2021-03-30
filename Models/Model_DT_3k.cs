using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI_DT_3k.Models
{
    public partial class Model_DT_3k : DbContext
    {
        public Model_DT_3k()
            : base("name=Model_DT_3k")
        {
        }

        public virtual DbSet<TmpDT_3k_Entregas> TmpDT_3k_Entregas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
