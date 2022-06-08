using iRely.Common;
using iRely.Vidly.BusinessLayer.Interface;
using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.BusinessLayer.Implementation
{
    public class MovieBl : BusinessLayer<tblVMMovie>, IMovieBl
    {
        public MovieBl(IRepository db) : base(db)
        {
        }
    }
}
