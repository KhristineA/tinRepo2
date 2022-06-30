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
        public CustomerBl(IVidlyRepository db) : base(db)
        {
        }

        public override async Task<GetObjectResult> GetAsync(GetParameter param) 
        {
            var query = _db.GetQuery<tblVMCustomer>().Filter(param);
            var data = await query.Select(s => new
            {
                s.intCustomerId,
                s.strCustomerName,
                s.ysnIsSubscribedToNewsletter,
                s.intMembershipTypeId,
                strMembershipTypeName = s.tblVMMembershipType.strMembershipTypeName,
                s.dtmBirthdate,
                s.intConcurrencyId
            }).ToListAsync(param.cancellationToken);

            return new GetObjectResult()
            {
                data = data,
                total = await query.CountAsync(param.cancellationToken)
            };
        }

        public override async Task<SearchResult> Search(GetParameter param)
        {
            var query = _db.GetQuery<tblVMCustomer>().Filter(param, true);
            var data = await query.Select(s => new
            {
                s.intCustomerId,
                s.strCustomerName,
                s.intMembershipTypeId,
                strMembershipTypeName = s.tblVMMembershipType.strMembershipTypeName,
            }).ExecuteProjection(param, "intCustomerId", "DESC").ToListAsync(param.cancellationToken);

            return new SearchResult()
            {
                data = data.AsQueryable(),
                total = await query.CountAsync(param.cancellationToken),
                summaryData = await query.ToAggregateAsync(param.aggregates)
            };
        }
    }
}
