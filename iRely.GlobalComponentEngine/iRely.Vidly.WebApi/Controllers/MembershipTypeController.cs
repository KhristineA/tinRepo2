using iRely.Common;
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
    public class MembershipTypeController : BaseApiController<tblVMMembershipType>
    {
        private IMembershipTypeBl _bl;
        public MembershipTypeController(IMembershipTypeBl bl) : base(bl)
        {
            _bl = bl;
        }
    }
}
