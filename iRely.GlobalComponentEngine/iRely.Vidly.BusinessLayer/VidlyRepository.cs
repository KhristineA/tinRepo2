using iRely.Common;
using iRely.Vidly.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.BusinessLayer.Implementation
{
    public class VidlyRepository : Repository
    {
        public VidlyRepository() : base(new VidlyEntities())
        {
        }
    }
}
