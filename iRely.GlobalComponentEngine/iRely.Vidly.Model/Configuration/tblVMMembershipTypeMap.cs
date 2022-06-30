using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Configuration
{
    public class tblVMMembershipTypeMap : EntityTypeConfiguration<tblVMMembershipType>
    {
        public tblVMMembershipTypeMap()
        {
            this.HasKey(t => t.intMembershipTypeId);
            this.Property(x => x.strMembershipTypeName)
                .HasColumnName("strName");
            this.ToTable("tblVMMembershipType");
        }
        
    }
}
