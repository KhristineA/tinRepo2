using iRely.Common;
using iRely.Vidly.BusinessLayer;
using iRely.Vidly.BusinessLayer.Implementation;
using iRely.Vidly.BusinessLayer.Interface;
using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace iRely.Vidly.WebApi.Controllers
{
    public class CustomerController : BaseApiController<tblVMCustomer>
    {
        private ICustomerBl _bl;

        public CustomerController(ICustomerBl bl) : base(bl)
        {
            _bl = bl;
        }

        //public CustomerController() : base(new CustomerBl(new VidlyRepository()))
        //{

        //}
    }
}
