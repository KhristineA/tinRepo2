using iRely.Vidly.Model.Metadata;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Configuration
{
    public class tblVMCustomerMap : EntityTypeConfiguration<tblVMCustomer>
    {
        public tblVMCustomerMap()
        {
            this.HasKey(t => t.intCustomerId);
            this.ToTable("tblVMCustomer");
        }
    }
}
