using iRely.Vidly.Model.Metadata;
using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Configuration
{
    public class tblVMMovieMap : EntityTypeConfiguration<tblVMMovie>
    {
        public tblVMMovieMap()
        {
            this.HasKey(t => t.intMovieId);
            this.ToTable("tblVMMovie");
        }
    }
}
