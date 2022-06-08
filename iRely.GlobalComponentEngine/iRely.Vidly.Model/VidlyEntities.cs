using iRely.Vidly.Model.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model
{
    public class VidlyEntities : DbContext
    {
        public VidlyEntities() : base(iRely.Common.Security.GetCompanyName())
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new tblVMCustomerMap());
            modelBuilder.Configurations.Add(new tblVMMembershipTypeMap());
            modelBuilder.Configurations.Add(new tblVMMovieMap());
            modelBuilder.Configurations.Add(new tblVMGenreMap());
            modelBuilder.Configurations.Add(new tblVMRentalHeaderMap());
            modelBuilder.Configurations.Add(new tblVMRentalDetailMap());
        }
    }
}
