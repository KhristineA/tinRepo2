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
    public class MembershipTypeBl : BusinessLayer<tblVMMembershipType>, IMembershipTypeBl
    {
        public MembershipTypeBl(IRepository db) : base(db)
        {
        }
    }
}
