using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Configuration
{
    public class tblVMGenreMap : EntityTypeConfiguration<tblVMGenre>
    {
        public tblVMGenreMap()
        {
            this.HasKey(t => t.intGenreId);
            this.ToTable("tblVMGenre");
        }
    }
}
