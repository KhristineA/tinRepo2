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
    public class RentalHeaderBl : BusinessLayer<tblVMRentalHeader>, IRentalHeaderBl
    {
        public RentalHeaderBl(IVidlyRepository db) : base(db)
        {
        }
        public override async Task<GetObjectResult> GetAsync(GetParameter param)
        {
            var query = _db.GetQuery<tblVMRentalHeader>().Filter(param);
            var data = await query.Select(s => new
            {
                s.intRentalHeaderId,
                s.intCustomerId,
                strCustomerName = s.tblVMCustomer.strCustomerName,
                s.dtmDateRented,
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
            var query = _db.GetQuery<tblVMRentalHeader>().Filter(param, true);
            var data = await query.Select(s => new
            {
                s.intRentalHeaderId,
                strCustomerName = s.tblVMCustomer.strCustomerName,
                s.dtmDateRented
            }).ExecuteProjection(param, "intRentalHeaderId", "DESC").ToListAsync(param.cancellationToken);

            return new SearchResult()
            {
                data = data.AsQueryable(),
                total = await query.CountAsync(param.cancellationToken),
                summaryData = await query.ToAggregateAsync(param.aggregates)
            };
        }
    }
}
