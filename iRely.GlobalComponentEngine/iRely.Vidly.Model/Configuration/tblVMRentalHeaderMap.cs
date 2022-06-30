using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Configuration
{
    public class tblVMRentalHeaderMap : EntityTypeConfiguration<tblVMRentalHeader>
    {
        public tblVMRentalHeaderMap()
        {
            this.HasKey(t => t.intRentalHeaderId);
            this.ToTable("tblVMRentalHeader");
            this.HasMany(x => x.tblVMRentalDetail).WithRequired().HasForeignKey(t => t.intRentalHeaderId);
        }
    }
}
