using iRely.Common;
using iRely.Vidly.BusinessLayer.Interface;
using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.BusinessLayer.Implementation
{
    public class CustomerBl : BusinessLayer<tblVMCustomer>, ICustomerBl
    {
        public CustomerBl(IRepository db) : base(db)
        {
        }
    }
}
