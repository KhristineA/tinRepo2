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
    public class RentalHeaderController : BaseApiController<tblVMRentalHeader>
    {
        private IRentalHeaderBl _bl;

        public RentalHeaderController(IRentalHeaderBl bl) : base(bl)
        {
            _bl = bl;
        }

        //public RentalHeaderController() : base(new RentalHeaderBl(new VidlyRepository()))
        //{

        //}
    }
}
