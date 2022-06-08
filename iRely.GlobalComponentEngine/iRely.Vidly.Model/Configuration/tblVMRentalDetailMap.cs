using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Configuration
{
    public class tblVMRentalDetailMap : EntityTypeConfiguration<tblVMRentalDetail>
    {
        public tblVMRentalDetailMap()
        {
            this.HasKey(t => t.intRentalDetailId);
            this.ToTable("tblVMRentalDetail");
        }
    }
}
