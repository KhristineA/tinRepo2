using iRely.Common;
using iRely.Vidly.BusinessLayer.Interface;
using iRely.Vidly.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.BusinessLayer
{
    public class VidlyRepository : Repository, IVidlyRepository
    {
        public VidlyRepository() : base(new VidlyEntities())
        {
        }
    }
}
