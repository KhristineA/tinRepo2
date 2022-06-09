using iRely.Common;
using iRely.Vidly.BusinessLayer;
using iRely.Vidly.BusinessLayer.Implementation;
using iRely.Vidly.BusinessLayer.Interface;
using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iRely.Vidly.WebApi.Controllers
{
    public class MovieController : BaseApiController<tblVMMovie>
    {
        private IMovieBl _bl;
        public MovieController(IMovieBl bl) : base(bl)
        {
            _bl = bl;
        }
        public MovieController() : base(new MovieBl(new VidlyRepository()))
        {

        }
    }
}