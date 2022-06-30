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
using System.Web.Http;

namespace iRely.Vidly.WebApi.Controllers
{
    public class RentalDetailController : BaseApiController<tblVMRentalDetail>
    {
        private IRentalDetailBl _bl;

        public RentalDetailController(IRentalDetailBl bl) : base(bl)
        {
            _bl = bl;
        }

        //public RentalDetailController() : base(new RentalDetailBl(new VidlyRepository()))
        //{

        //}
    }
}
